// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ContainerServiceTrustedAccessRoleBinding data model.
    /// Defines binding between a resource and role
    /// </summary>
    public partial class ContainerServiceTrustedAccessRoleBindingData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleBindingData"/>. </summary>
        /// <param name="sourceResourceId"> The ARM resource ID of source resource that trusted access is configured for. </param>
        /// <param name="roles"> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceResourceId"/> or <paramref name="roles"/> is null. </exception>
        public ContainerServiceTrustedAccessRoleBindingData(ResourceIdentifier sourceResourceId, IEnumerable<string> roles)
        {
            Argument.AssertNotNull(sourceResourceId, nameof(sourceResourceId));
            Argument.AssertNotNull(roles, nameof(roles));

            SourceResourceId = sourceResourceId;
            Roles = roles.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleBindingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The current provisioning state of trusted access role binding. </param>
        /// <param name="sourceResourceId"> The ARM resource ID of source resource that trusted access is configured for. </param>
        /// <param name="roles"> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceTrustedAccessRoleBindingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContainerServiceTrustedAccessRoleBindingProvisioningState? provisioningState, ResourceIdentifier sourceResourceId, IList<string> roles, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            SourceResourceId = sourceResourceId;
            Roles = roles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleBindingData"/> for deserialization. </summary>
        internal ContainerServiceTrustedAccessRoleBindingData()
        {
        }

        /// <summary> The current provisioning state of trusted access role binding. </summary>
        public ContainerServiceTrustedAccessRoleBindingProvisioningState? ProvisioningState { get; }
        /// <summary> The ARM resource ID of source resource that trusted access is configured for. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </summary>
        public IList<string> Roles { get; }
    }
}
