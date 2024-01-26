// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the MarketplaceApprovalRequest data model.
    /// Request approval resource.
    /// </summary>
    public partial class MarketplaceApprovalRequestData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MarketplaceApprovalRequestData"/>. </summary>
        public MarketplaceApprovalRequestData()
        {
            PlansDetails = new ChangeTrackingList<PrivateStorePlanDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceApprovalRequestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId"> Gets or sets unique offer id. </param>
        /// <param name="offerDisplayName"> Gets offer display name. </param>
        /// <param name="publisherId"> The offer's publisher id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="isClosed"> Gets a value indicating whether the request is closed. </param>
        /// <param name="messageCode"> Gets or sets the request approval message code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MarketplaceApprovalRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string offerId, string offerDisplayName, string publisherId, IList<PrivateStorePlanDetails> plansDetails, bool? isClosed, long? messageCode, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OfferId = offerId;
            OfferDisplayName = offerDisplayName;
            PublisherId = publisherId;
            PlansDetails = plansDetails;
            IsClosed = isClosed;
            MessageCode = messageCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets unique offer id. </summary>
        public string OfferId { get; set; }
        /// <summary> Gets offer display name. </summary>
        public string OfferDisplayName { get; }
        /// <summary> The offer's publisher id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Gets or sets the plans details. </summary>
        public IList<PrivateStorePlanDetails> PlansDetails { get; }
        /// <summary> Gets a value indicating whether the request is closed. </summary>
        public bool? IsClosed { get; }
        /// <summary> Gets or sets the request approval message code. </summary>
        public long? MessageCode { get; set; }
    }
}
