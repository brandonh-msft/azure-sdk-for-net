// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Generic object modeling results of script execution. </summary>
    public partial class ScriptStatus
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

        /// <summary> Initializes a new instance of <see cref="ScriptStatus"/>. </summary>
        internal ScriptStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptStatus"/>. </summary>
        /// <param name="containerInstanceId"> ACI resource Id. </param>
        /// <param name="storageAccountId"> Storage account resource Id. </param>
        /// <param name="startOn"> Start time of the script execution. </param>
        /// <param name="endOn"> End time of the script execution. </param>
        /// <param name="expireOn"> Time the deployment script resource will expire. </param>
        /// <param name="error"> Error that is relayed from the script execution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptStatus(string containerInstanceId, string storageAccountId, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? expireOn, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerInstanceId = containerInstanceId;
            StorageAccountId = storageAccountId;
            StartOn = startOn;
            EndOn = endOn;
            ExpireOn = expireOn;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ACI resource Id. </summary>
        public string ContainerInstanceId { get; }
        /// <summary> Storage account resource Id. </summary>
        public string StorageAccountId { get; }
        /// <summary> Start time of the script execution. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the script execution. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Time the deployment script resource will expire. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Error that is relayed from the script execution. </summary>
        public ResponseError Error { get; }
    }
}
