// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Active message associated with project. </summary>
    public partial class JobStatusMessage
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

        /// <summary> Initializes a new instance of <see cref="JobStatusMessage"/>. </summary>
        internal JobStatusMessage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobStatusMessage"/>. </summary>
        /// <param name="code"> Service-defined message code. </param>
        /// <param name="createdOn"> Time in UTC at which the message was created. </param>
        /// <param name="level"> Severity level of message. </param>
        /// <param name="message"> A human-readable representation of the message code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobStatusMessage(string code, DateTimeOffset? createdOn, JobStatusMessageLevel? level, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            CreatedOn = createdOn;
            Level = level;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Service-defined message code. </summary>
        public string Code { get; }
        /// <summary> Time in UTC at which the message was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Severity level of message. </summary>
        public JobStatusMessageLevel? Level { get; }
        /// <summary> A human-readable representation of the message code. </summary>
        public string Message { get; }
    }
}
