﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System;

namespace Azure.Analytics.Synapse.Monitoring
{
    /// <summary>
    /// The options for <see cref="MonitoringClient"/>.
    /// </summary>
    public class MonitoringClientOptions : ClientOptions
    {
        private const ServiceVersion Latest = ServiceVersion.V2019_11_01_preview;

        internal static MonitoringClientOptions Default { get; } = new MonitoringClientOptions();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringClientOptions"/>.
        /// </summary>
        public MonitoringClientOptions(ServiceVersion serviceVersion = Latest)
        {
            VersionString = serviceVersion switch
            {
                ServiceVersion.V2019_11_01_preview => "2019-11-01-preview",
                _ => throw new ArgumentOutOfRangeException(nameof(serviceVersion))
            };
        }

        /// <summary>
        /// API version for Azure Synapse Access Control service.
        /// </summary>
        internal string VersionString { get; }

        /// <summary>
        /// The Synapse service version.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// The 2019-06-01-preview of the template service.
            /// </summary>
#pragma warning disable CA1707
            V2019_11_01_preview = 1
#pragma warning restore CA1707
        }
    }
}
