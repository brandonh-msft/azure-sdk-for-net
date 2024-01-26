// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkGateway data model.
    /// NSX Gateway.
    /// </summary>
    public partial class WorkloadNetworkGatewayData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkGatewayData"/>. </summary>
        public WorkloadNetworkGatewayData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkGatewayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="path"> NSX Gateway Path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string path, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Display name of the DHCP entity. </summary>
        public string DisplayName { get; set; }
        /// <summary> NSX Gateway Path. </summary>
        public string Path { get; }
    }
}
