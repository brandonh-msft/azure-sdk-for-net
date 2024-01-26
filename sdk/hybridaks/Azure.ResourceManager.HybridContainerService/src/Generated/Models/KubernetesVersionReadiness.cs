// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Indicates whether the kubernetes version image is ready or not. </summary>
    public partial class KubernetesVersionReadiness
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

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionReadiness"/>. </summary>
        internal KubernetesVersionReadiness()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionReadiness"/>. </summary>
        /// <param name="osType"> The particular KubernetesVersion Image OS Type (Linux, Windows). </param>
        /// <param name="osSku"> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </param>
        /// <param name="ready"> Whether the kubernetes version image is ready or not. </param>
        /// <param name="errorMessage"> The error message for version not being ready. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesVersionReadiness(HybridContainerServiceOSType? osType, HybridContainerServiceOSSku? osSku, bool? ready, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSType = osType;
            OSSku = osSku;
            Ready = ready;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The particular KubernetesVersion Image OS Type (Linux, Windows). </summary>
        public HybridContainerServiceOSType? OSType { get; }
        /// <summary> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </summary>
        public HybridContainerServiceOSSku? OSSku { get; }
        /// <summary> Whether the kubernetes version image is ready or not. </summary>
        public bool? Ready { get; }
        /// <summary> The error message for version not being ready. </summary>
        public string ErrorMessage { get; }
    }
}
