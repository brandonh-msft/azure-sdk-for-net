// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for the quota submission request.
    /// </summary>
    public partial class QuotaRequestSubmitResponse : IResource
    {
        /// <summary>
        /// Initializes a new instance of the QuotaRequestSubmitResponse class.
        /// </summary>
        public QuotaRequestSubmitResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaRequestSubmitResponse class.
        /// </summary>
        /// <param name="id">The quota request ID.</param>
        /// <param name="name">The name of the quota request.</param>
        /// <param name="properties">The quota request details.</param>
        /// <param name="type">Type of resource.
        /// "Microsoft.Capacity/serviceLimits"</param>
        public QuotaRequestSubmitResponse(string id = default(string), string name = default(string), QuotaRequestProperties properties = default(QuotaRequestProperties), string type = default(string))
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the quota request ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the quota request.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the quota request details.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public QuotaRequestProperties Properties { get; set; }

        /// <summary>
        /// Gets type of resource. "Microsoft.Capacity/serviceLimits"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
