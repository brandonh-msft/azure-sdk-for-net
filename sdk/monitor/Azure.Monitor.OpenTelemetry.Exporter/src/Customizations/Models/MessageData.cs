// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter.Internals;

using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MessageData
    {
        public MessageData(int version, LogRecord logRecord, AzureMonitorResource? resource = null) : base(version)
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
            Message = LogsHelper.GetMessageAndSetProperties(logRecord, Properties, resource).Truncate(SchemaConstants.MessageData_Message_MaxLength);
            SeverityLevel = LogsHelper.GetSeverityLevel(logRecord.LogLevel);
        }
    }
}
