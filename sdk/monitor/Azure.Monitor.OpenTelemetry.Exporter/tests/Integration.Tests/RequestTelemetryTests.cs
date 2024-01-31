﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Azure.Monitor.OpenTelemetry.Exporter.Integration.Tests.TestFramework;
using Azure.Monitor.OpenTelemetry.Exporter.Models;
using Azure.Monitor.OpenTelemetry.Exporter.Tests.CommonTestFramework;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

using Xunit;
using Xunit.Abstractions;

namespace Azure.Monitor.OpenTelemetry.Exporter.Integration.Tests
{
    public class RequestTelemetryTests : WebApplicationTestsBase
    {
        private const string TestServerUrl = "http://localhost:9997/";

        public RequestTelemetryTests(ITestOutputHelper output) : base(output)
        {
        }

#if !NET462
        /// <summary>
        /// This test validates that when an app instrumented with the AzureMonitorExporter receives an HTTP request,
        /// A TelemetryItem is created matching that request.
        /// </summary>
        [Fact]
        public async Task VerifyRequestTelemetry()
        {
            string testValue = Guid.NewGuid().ToString();

            List<TelemetryItem>? telemetryItems = null;

            // SETUP WEBAPPLICATION WITH OPENTELEMETRY
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddOpenTelemetry()
                .WithTracing(builder => builder
                    .AddAspNetCoreInstrumentation()
                    .AddAzureMonitorTraceExporterForTest(out telemetryItems));

            var app = builder.Build();
            app.MapGet("/", () =>
            {
                return "Response from Test Server";
            });

            _ = app.RunAsync(TestServerUrl);

            // ACT
            using var httpClient = new HttpClient();
            var res = await httpClient.GetStringAsync(TestServerUrl).ConfigureAwait(false);
            Assert.True(res.Equals("Response from Test Server"), "If this assert fails, the in-process test server is not running.");

            // Shutdown
            //response.EnsureSuccessStatusCode();
            Assert.NotNull(telemetryItems);
            this.WaitForActivityExport(telemetryItems);

            // Assert
            Assert.True(telemetryItems.Any(), "test project did not capture telemetry");
            var telemetryItem = telemetryItems.Last()!;
            this.telemetryOutput.Write(telemetryItem);

            AssertRequestTelemetry(
                telemetryItem: telemetryItem,
                expectedResponseCode: "200",
                expectedUrl: TestServerUrl);
        }

        /// <summary>
        /// This test validates that when an app instrumented with the AzureMonitorExporter receives an HTTP request,
        /// A TelemetryItem is created matching that request.
        /// </summary>
        [Fact]
        public async Task VerifyRequestTelemetryWithResourceAttributes()
        {
            string testValue = Guid.NewGuid().ToString();

            List<TelemetryItem>? telemetryItems = null;

            // SETUP WEBAPPLICATION WITH OPENTELEMETRY
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddOpenTelemetry()
                .WithTracing(builder => builder
                    .AddAspNetCoreInstrumentation()
                    .AddAzureMonitorTraceExporterForTest(out telemetryItems))
                // Add a custom service to the otel pipeline; this service's attributes should decorate everything
                // pushing through otel automatically.
                .ConfigureResource(rb => rb
                    .AddService("my-service", "my-namespace", "my-version", serviceInstanceId: "my-instance-id")
                    // Add some custom attributes, too.
                    .AddAttributes(new[] {
                        new KeyValuePair<string, object>("my-attribute", "unittest"),
                        new KeyValuePair<string, object>("my-flag", false)
                    }));

            var app = builder.Build();
            app.MapGet("/", () =>
            {
                return "Response from Test Server";
            });

            _ = app.RunAsync(TestServerUrl);

            // ACT
            using var httpClient = new HttpClient();
            var res = await httpClient.GetStringAsync(TestServerUrl).ConfigureAwait(false);
            Assert.True(res.Equals("Response from Test Server"), "If this assert fails, the in-process test server is not running.");

            // Shutdown
            //response.EnsureSuccessStatusCode();
            Assert.NotNull(telemetryItems);
            this.WaitForActivityExport(telemetryItems);

            // Assert
            Assert.True(telemetryItems.Any(), "test project did not capture telemetry");
            var telemetryItem = telemetryItems.Last()!;
            this.telemetryOutput.Write(telemetryItem);

            AssertRequestTelemetry(
                telemetryItem: telemetryItem,
                expectedResponseCode: "200",
                expectedUrl: TestServerUrl);

            var md = telemetryItem.Data.BaseData as MessageData;
            Assert.NotNull(md);
            Assert.Equal("my-service", md.Properties["service.name"]);
            Assert.Equal("my-namespace", md.Properties["service.namespace"]);
            Assert.Equal("my-version", md.Properties["service.version"]);
            Assert.Equal("my-instance-id", md.Properties["service.instance.id"]);
            Assert.Equal("unittest", md.Properties["my-attribute"]);
            Assert.Equal(bool.FalseString, md.Properties["my-flag"]);
        }
#endif
    }
}
