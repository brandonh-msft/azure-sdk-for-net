// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Properties used to create a user account on a Windows node. </summary>
    internal partial class BatchWindowsUserConfiguration
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

        /// <summary> Initializes a new instance of <see cref="BatchWindowsUserConfiguration"/>. </summary>
        public BatchWindowsUserConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchWindowsUserConfiguration"/>. </summary>
        /// <param name="loginMode"> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchWindowsUserConfiguration(BatchWindowsLoginMode? loginMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoginMode = loginMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </summary>
        public BatchWindowsLoginMode? LoginMode { get; set; }
    }
}
