// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem
        /// class.
        /// </summary>
        public ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem
        /// class.
        /// </summary>
        public ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(string database = default(string), IList<string> schemas = default(IList<string>))
        {
            Database = database;
            Schemas = schemas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "database")]
        public string Database { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemas")]
        public IList<string> Schemas { get; set; }

    }
}
