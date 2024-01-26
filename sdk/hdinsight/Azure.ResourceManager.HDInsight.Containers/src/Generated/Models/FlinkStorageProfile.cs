// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The storage profile. </summary>
    public partial class FlinkStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="FlinkStorageProfile"/>. </summary>
        /// <param name="storageUriString"> Storage account uri which is used for savepoint and checkpoint state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageUriString"/> is null. </exception>
        public FlinkStorageProfile(string storageUriString)
        {
            Argument.AssertNotNull(storageUriString, nameof(storageUriString));

            StorageUriString = storageUriString;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkStorageProfile"/>. </summary>
        /// <param name="storageUriString"> Storage account uri which is used for savepoint and checkpoint state. </param>
        /// <param name="storagekey"> Storage key is only required for wasb(s) storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FlinkStorageProfile(string storageUriString, string storagekey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageUriString = storageUriString;
            Storagekey = storagekey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkStorageProfile"/> for deserialization. </summary>
        internal FlinkStorageProfile()
        {
        }

        /// <summary> Storage account uri which is used for savepoint and checkpoint state. </summary>
        public string StorageUriString { get; set; }
        /// <summary> Storage key is only required for wasb(s) storage. </summary>
        public string Storagekey { get; set; }
    }
}
