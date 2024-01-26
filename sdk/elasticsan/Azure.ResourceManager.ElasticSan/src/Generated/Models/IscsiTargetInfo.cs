// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Iscsi target information. </summary>
    public partial class IscsiTargetInfo
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

        /// <summary> Initializes a new instance of <see cref="IscsiTargetInfo"/>. </summary>
        internal IscsiTargetInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IscsiTargetInfo"/>. </summary>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="targetPortalHostname"> iSCSI Target Portal Host Name. </param>
        /// <param name="targetPortalPort"> iSCSI Target Portal Port. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="status"> Operational status of the iSCSI Target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IscsiTargetInfo(string targetIqn, string targetPortalHostname, int? targetPortalPort, ElasticSanProvisioningState? provisioningState, ResourceOperationalStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetIqn = targetIqn;
            TargetPortalHostname = targetPortalHostname;
            TargetPortalPort = targetPortalPort;
            ProvisioningState = provisioningState;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </summary>
        public string TargetIqn { get; }
        /// <summary> iSCSI Target Portal Host Name. </summary>
        public string TargetPortalHostname { get; }
        /// <summary> iSCSI Target Portal Port. </summary>
        public int? TargetPortalPort { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ElasticSanProvisioningState? ProvisioningState { get; }
        /// <summary> Operational status of the iSCSI Target. </summary>
        public ResourceOperationalStatus? Status { get; }
    }
}
