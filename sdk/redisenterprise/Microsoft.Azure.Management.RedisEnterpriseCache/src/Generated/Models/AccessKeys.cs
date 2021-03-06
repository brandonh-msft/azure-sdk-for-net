// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisEnterprise.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Access keys
    /// </summary>
    /// <remarks>
    /// The secret access keys used for authenticating connections to redis
    /// </remarks>
    public partial class AccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        public AccessKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        /// <param name="primaryKey">The current primary key that clients can
        /// use to authenticate</param>
        /// <param name="secondaryKey">The current secondary key that clients
        /// can use to authenticate</param>
        public AccessKeys(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current primary key that clients can use to authenticate
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets the current secondary key that clients can use to authenticate
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

    }
}
