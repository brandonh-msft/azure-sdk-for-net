// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing the MediaAsset data model.
    /// An Asset.
    /// </summary>
    public partial class MediaAssetData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MediaAssetData"/>. </summary>
        public MediaAssetData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaAssetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="assetId"> The Asset ID. </param>
        /// <param name="createdOn"> The creation date of the Asset. </param>
        /// <param name="lastModifiedOn"> The last modified date of the Asset. </param>
        /// <param name="alternateId"> The alternate ID of the Asset. </param>
        /// <param name="description"> The Asset description. </param>
        /// <param name="container"> The name of the asset blob container. </param>
        /// <param name="storageAccountName"> The name of the storage account. </param>
        /// <param name="storageEncryptionFormat"> The Asset encryption format. One of None or MediaStorageEncryption. </param>
        /// <param name="encryptionScope"> The Asset container encryption scope in the storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaAssetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? assetId, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string alternateId, string description, string container, string storageAccountName, MediaAssetStorageEncryptionFormat? storageEncryptionFormat, string encryptionScope, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AssetId = assetId;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            AlternateId = alternateId;
            Description = description;
            Container = container;
            StorageAccountName = storageAccountName;
            StorageEncryptionFormat = storageEncryptionFormat;
            EncryptionScope = encryptionScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Asset ID. </summary>
        public Guid? AssetId { get; }
        /// <summary> The creation date of the Asset. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The last modified date of the Asset. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The alternate ID of the Asset. </summary>
        public string AlternateId { get; set; }
        /// <summary> The Asset description. </summary>
        public string Description { get; set; }
        /// <summary> The name of the asset blob container. </summary>
        public string Container { get; set; }
        /// <summary> The name of the storage account. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> The Asset encryption format. One of None or MediaStorageEncryption. </summary>
        public MediaAssetStorageEncryptionFormat? StorageEncryptionFormat { get; }
        /// <summary> The Asset container encryption scope in the storage account. </summary>
        public string EncryptionScope { get; set; }
    }
}
