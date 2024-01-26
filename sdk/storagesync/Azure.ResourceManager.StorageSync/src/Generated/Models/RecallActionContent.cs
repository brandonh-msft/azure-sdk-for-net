// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when calling recall action on server endpoint. </summary>
    public partial class RecallActionContent
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

        /// <summary> Initializes a new instance of <see cref="RecallActionContent"/>. </summary>
        public RecallActionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecallActionContent"/>. </summary>
        /// <param name="pattern"> Pattern of the files. </param>
        /// <param name="recallPath"> Recall path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecallActionContent(string pattern, string recallPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Pattern = pattern;
            RecallPath = recallPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Pattern of the files. </summary>
        public string Pattern { get; set; }
        /// <summary> Recall path. </summary>
        public string RecallPath { get; set; }
    }
}
