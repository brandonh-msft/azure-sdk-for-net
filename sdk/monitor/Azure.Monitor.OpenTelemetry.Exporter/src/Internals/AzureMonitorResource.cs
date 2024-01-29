// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Monitor.OpenTelemetry.Exporter.Models;

using OpenTelemetry.Resources;

namespace Azure.Monitor.OpenTelemetry.Exporter.Internals
{
    internal sealed class AzureMonitorResource
    {
        public AzureMonitorResource() : this(ResourceBuilder.CreateEmpty()) { }

        public AzureMonitorResource(ResourceBuilder resourceBuilder) : this(resourceBuilder.Build()) { }

        public AzureMonitorResource(Resource otelResource) => OtelResource = otelResource;

        internal string? RoleName { get; set; }

        internal string? RoleInstance { get; set; }

        internal TelemetryItem? MetricTelemetry { get; set; }

        internal Resource OtelResource { get; private set; }
    }
}
