// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The minimum per-database performance level capability. </summary>
    public partial class ElasticPoolPerDatabaseMinPerformanceLevelCapability
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

        /// <summary> Initializes a new instance of <see cref="ElasticPoolPerDatabaseMinPerformanceLevelCapability"/>. </summary>
        internal ElasticPoolPerDatabaseMinPerformanceLevelCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticPoolPerDatabaseMinPerformanceLevelCapability"/>. </summary>
        /// <param name="limit"> The minimum performance level per database. </param>
        /// <param name="unit"> Unit type used to measure performance level. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticPoolPerDatabaseMinPerformanceLevelCapability(double? limit, PerformanceLevelUnit? unit, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Limit = limit;
            Unit = unit;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The minimum performance level per database. </summary>
        public double? Limit { get; }
        /// <summary> Unit type used to measure performance level. </summary>
        public PerformanceLevelUnit? Unit { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
