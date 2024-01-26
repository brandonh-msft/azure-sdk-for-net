// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> CS Accounts Details. </summary>
    public partial class SiteRecoveryRunAsAccount
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRunAsAccount"/>. </summary>
        internal SiteRecoveryRunAsAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRunAsAccount"/>. </summary>
        /// <param name="accountId"> The CS RunAs account Id. </param>
        /// <param name="accountName"> The CS RunAs account name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryRunAsAccount(string accountId, string accountName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountId = accountId;
            AccountName = accountName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The CS RunAs account Id. </summary>
        public string AccountId { get; }
        /// <summary> The CS RunAs account name. </summary>
        public string AccountName { get; }
    }
}
