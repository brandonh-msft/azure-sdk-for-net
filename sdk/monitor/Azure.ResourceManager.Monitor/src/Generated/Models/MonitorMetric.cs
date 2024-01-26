// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The result data of a query. </summary>
    public partial class MonitorMetric
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorMetric"/>. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="metricType"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="metricType"/>, <paramref name="name"/> or <paramref name="timeseries"/> is null. </exception>
        internal MonitorMetric(string id, string metricType, MonitorLocalizableString name, MonitorMetricUnit unit, IEnumerable<MonitorTimeSeriesElement> timeseries)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(metricType, nameof(metricType));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(timeseries, nameof(timeseries));

            Id = id;
            MetricType = metricType;
            Name = name;
            Unit = unit;
            Timeseries = timeseries.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorMetric"/>. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="metricType"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="displayDescription"> Detailed description of this metric. </param>
        /// <param name="errorCode"> 'Success' or the error details on query failures for this metric. </param>
        /// <param name="errorMessage"> Error message encountered querying this specific metric. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorMetric(string id, string metricType, MonitorLocalizableString name, string displayDescription, string errorCode, string errorMessage, MonitorMetricUnit unit, IReadOnlyList<MonitorTimeSeriesElement> timeseries, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            MetricType = metricType;
            Name = name;
            DisplayDescription = displayDescription;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Unit = unit;
            Timeseries = timeseries;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorMetric"/> for deserialization. </summary>
        internal MonitorMetric()
        {
        }

        /// <summary> the metric Id. </summary>
        public string Id { get; }
        /// <summary> the resource type of the metric resource. </summary>
        public string MetricType { get; }
        /// <summary> the name and the display name of the metric, i.e. it is localizable string. </summary>
        public MonitorLocalizableString Name { get; }
        /// <summary> Detailed description of this metric. </summary>
        public string DisplayDescription { get; }
        /// <summary> 'Success' or the error details on query failures for this metric. </summary>
        public string ErrorCode { get; }
        /// <summary> Error message encountered querying this specific metric. </summary>
        public string ErrorMessage { get; }
        /// <summary> The unit of the metric. </summary>
        public MonitorMetricUnit Unit { get; }
        /// <summary> the time series returned when a data query is performed. </summary>
        public IReadOnlyList<MonitorTimeSeriesElement> Timeseries { get; }
    }
}
