// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The Upgrade Graph Properties for appliance. </summary>
    public partial class ApplianceUpgradeGraphProperties
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

        /// <summary> Initializes a new instance of <see cref="ApplianceUpgradeGraphProperties"/>. </summary>
        internal ApplianceUpgradeGraphProperties()
        {
            SupportedVersions = new ChangeTrackingList<ApplianceSupportedVersion>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceUpgradeGraphProperties"/>. </summary>
        /// <param name="applianceVersion"> The current appliance version. </param>
        /// <param name="supportedVersions"> This contains the current version and supported upgrade versions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceUpgradeGraphProperties(string applianceVersion, IReadOnlyList<ApplianceSupportedVersion> supportedVersions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplianceVersion = applianceVersion;
            SupportedVersions = supportedVersions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current appliance version. </summary>
        public string ApplianceVersion { get; }
        /// <summary> This contains the current version and supported upgrade versions. </summary>
        public IReadOnlyList<ApplianceSupportedVersion> SupportedVersions { get; }
    }
}
