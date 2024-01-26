// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The output configuration of a job step. </summary>
    public partial class JobStepOutput
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

        /// <summary> Initializes a new instance of <see cref="JobStepOutput"/>. </summary>
        /// <param name="serverName"> The output destination server name. </param>
        /// <param name="databaseName"> The output destination database. </param>
        /// <param name="tableName"> The output destination table. </param>
        /// <param name="credential"> The resource ID of the credential to use to connect to the output destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="tableName"/> or <paramref name="credential"/> is null. </exception>
        public JobStepOutput(string serverName, string databaseName, string tableName, string credential)
        {
            Argument.AssertNotNull(serverName, nameof(serverName));
            Argument.AssertNotNull(databaseName, nameof(databaseName));
            Argument.AssertNotNull(tableName, nameof(tableName));
            Argument.AssertNotNull(credential, nameof(credential));

            ServerName = serverName;
            DatabaseName = databaseName;
            TableName = tableName;
            Credential = credential;
        }

        /// <summary> Initializes a new instance of <see cref="JobStepOutput"/>. </summary>
        /// <param name="outputType"> The output destination type. </param>
        /// <param name="subscriptionId"> The output destination subscription id. </param>
        /// <param name="resourceGroupName"> The output destination resource group. </param>
        /// <param name="serverName"> The output destination server name. </param>
        /// <param name="databaseName"> The output destination database. </param>
        /// <param name="schemaName"> The output destination schema. </param>
        /// <param name="tableName"> The output destination table. </param>
        /// <param name="credential"> The resource ID of the credential to use to connect to the output destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobStepOutput(JobStepOutputType? outputType, Guid? subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string credential, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OutputType = outputType;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            ServerName = serverName;
            DatabaseName = databaseName;
            SchemaName = schemaName;
            TableName = tableName;
            Credential = credential;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JobStepOutput"/> for deserialization. </summary>
        internal JobStepOutput()
        {
        }

        /// <summary> The output destination type. </summary>
        public JobStepOutputType? OutputType { get; set; }
        /// <summary> The output destination subscription id. </summary>
        public Guid? SubscriptionId { get; set; }
        /// <summary> The output destination resource group. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> The output destination server name. </summary>
        public string ServerName { get; set; }
        /// <summary> The output destination database. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The output destination schema. </summary>
        public string SchemaName { get; set; }
        /// <summary> The output destination table. </summary>
        public string TableName { get; set; }
        /// <summary> The resource ID of the credential to use to connect to the output destination. </summary>
        public string Credential { get; set; }
    }
}
