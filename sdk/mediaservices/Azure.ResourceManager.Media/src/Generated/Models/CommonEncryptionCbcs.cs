// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for CommonEncryptionCbcs encryption scheme. </summary>
    public partial class CommonEncryptionCbcs
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

        /// <summary> Initializes a new instance of <see cref="CommonEncryptionCbcs"/>. </summary>
        public CommonEncryptionCbcs()
        {
            ClearTracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="CommonEncryptionCbcs"/>. </summary>
        /// <param name="enabledProtocols"> Representing supported protocols. </param>
        /// <param name="clearTracks"> Representing which tracks should not be encrypted. </param>
        /// <param name="contentKeys"> Representing default content key for each encryption scheme and separate content keys for specific tracks. </param>
        /// <param name="drm"> Configuration of DRMs for current encryption scheme. </param>
        /// <param name="clearKeyEncryptionConfiguration"> Optional configuration supporting ClearKey in CommonEncryptionCbcs encryption scheme. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommonEncryptionCbcs(MediaEnabledProtocols enabledProtocols, IList<MediaTrackSelection> clearTracks, StreamingPolicyContentKeys contentKeys, CbcsDrmConfiguration drm, ClearKeyEncryptionConfiguration clearKeyEncryptionConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnabledProtocols = enabledProtocols;
            ClearTracks = clearTracks;
            ContentKeys = contentKeys;
            Drm = drm;
            ClearKeyEncryptionConfiguration = clearKeyEncryptionConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols EnabledProtocols { get; set; }
        /// <summary> Representing which tracks should not be encrypted. </summary>
        public IList<MediaTrackSelection> ClearTracks { get; }
        /// <summary> Representing default content key for each encryption scheme and separate content keys for specific tracks. </summary>
        public StreamingPolicyContentKeys ContentKeys { get; set; }
        /// <summary> Configuration of DRMs for current encryption scheme. </summary>
        public CbcsDrmConfiguration Drm { get; set; }
        /// <summary> Optional configuration supporting ClearKey in CommonEncryptionCbcs encryption scheme. </summary>
        internal ClearKeyEncryptionConfiguration ClearKeyEncryptionConfiguration { get; set; }
        /// <summary> Template for the URL of the custom service delivering content keys to end user players. Not required when using Azure Media Services for issuing licenses. The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token value is {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId. </summary>
        public string ClearKeyEncryptionCustomKeysAcquisitionUriTemplate
        {
            get => ClearKeyEncryptionConfiguration is null ? default : ClearKeyEncryptionConfiguration.CustomKeysAcquisitionUriTemplate;
            set
            {
                if (ClearKeyEncryptionConfiguration is null)
                    ClearKeyEncryptionConfiguration = new ClearKeyEncryptionConfiguration();
                ClearKeyEncryptionConfiguration.CustomKeysAcquisitionUriTemplate = value;
            }
        }
    }
}
