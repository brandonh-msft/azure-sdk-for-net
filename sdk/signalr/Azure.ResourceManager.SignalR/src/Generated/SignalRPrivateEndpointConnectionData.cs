// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing the SignalRPrivateEndpointConnection data model.
    /// A private endpoint connection to an azure resource
    /// </summary>
    public partial class SignalRPrivateEndpointConnectionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointConnectionData"/>. </summary>
        public SignalRPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="privateEndpoint"> Private endpoint. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SignalRProvisioningState? provisioningState, WritableSubResource privateEndpoint, IReadOnlyList<string> groupIds, SignalRPrivateLinkServiceConnectionState connectionState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public SignalRProvisioningState? ProvisioningState { get; }
        /// <summary> Private endpoint. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> Group IDs. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public SignalRPrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}
