// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The service resource for patch operations. </summary>
    public partial class ServiceFabricServicePatch : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ServiceFabricServicePatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricServicePatch(AzureLocation location) : base(location)
        {
            CorrelationScheme = new ChangeTrackingList<ServiceCorrelationDescription>();
            ServiceLoadMetrics = new ChangeTrackingList<ServiceLoadMetricDescription>();
            ServicePlacementPolicies = new ChangeTrackingList<ServicePlacementPolicyDescription>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricServicePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="placementConstraints"> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: "NodeColor == blue)". </param>
        /// <param name="correlationScheme"> A list that describes the correlation of the service with other services. </param>
        /// <param name="serviceLoadMetrics"> The service load metrics is given as an array of ServiceLoadMetricDescription objects. </param>
        /// <param name="servicePlacementPolicies"> A list that describes the correlation of the service with other services. </param>
        /// <param name="defaultMoveCost"> Specifies the move cost for the service. </param>
        /// <param name="serviceKind"> The kind of service (Stateless or Stateful). </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricServicePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string placementConstraints, IList<ServiceCorrelationDescription> correlationScheme, IList<ServiceLoadMetricDescription> serviceLoadMetrics, IList<ServicePlacementPolicyDescription> servicePlacementPolicies, ApplicationMoveCost? defaultMoveCost, ApplicationServiceKind? serviceKind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            PlacementConstraints = placementConstraints;
            CorrelationScheme = correlationScheme;
            ServiceLoadMetrics = serviceLoadMetrics;
            ServicePlacementPolicies = servicePlacementPolicies;
            DefaultMoveCost = defaultMoveCost;
            ServiceKind = serviceKind;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricServicePatch"/> for deserialization. </summary>
        internal ServiceFabricServicePatch()
        {
        }

        /// <summary> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: "NodeColor == blue)". </summary>
        public string PlacementConstraints { get; set; }
        /// <summary> A list that describes the correlation of the service with other services. </summary>
        public IList<ServiceCorrelationDescription> CorrelationScheme { get; }
        /// <summary> The service load metrics is given as an array of ServiceLoadMetricDescription objects. </summary>
        public IList<ServiceLoadMetricDescription> ServiceLoadMetrics { get; }
        /// <summary> A list that describes the correlation of the service with other services. </summary>
        public IList<ServicePlacementPolicyDescription> ServicePlacementPolicies { get; }
        /// <summary> Specifies the move cost for the service. </summary>
        public ApplicationMoveCost? DefaultMoveCost { get; set; }
        /// <summary> The kind of service (Stateless or Stateful). </summary>
        internal ApplicationServiceKind? ServiceKind { get; set; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
