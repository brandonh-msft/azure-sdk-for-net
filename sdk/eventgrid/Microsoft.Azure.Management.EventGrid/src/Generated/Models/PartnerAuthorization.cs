// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The partner authorization details.
    /// </summary>
    public partial class PartnerAuthorization
    {
        /// <summary>
        /// Initializes a new instance of the PartnerAuthorization class.
        /// </summary>
        public PartnerAuthorization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerAuthorization class.
        /// </summary>
        /// <param name="defaultMaximumExpirationTimeInDays">Time used to
        /// validate the authorization expiration time for each authorized
        /// partner. If DefaultMaximumExpirationTimeInDays is
        /// not specified, the default is 7 days. Otherwise, allowed values are
        /// between 1 and 365 days.</param>
        /// <param name="authorizedPartnersList">The list of authorized
        /// partners.</param>
        public PartnerAuthorization(int? defaultMaximumExpirationTimeInDays = default(int?), IList<Partner> authorizedPartnersList = default(IList<Partner>))
        {
            DefaultMaximumExpirationTimeInDays = defaultMaximumExpirationTimeInDays;
            AuthorizedPartnersList = authorizedPartnersList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time used to validate the authorization expiration
        /// time for each authorized partner. If
        /// DefaultMaximumExpirationTimeInDays is
        /// not specified, the default is 7 days. Otherwise, allowed values are
        /// between 1 and 365 days.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMaximumExpirationTimeInDays")]
        public int? DefaultMaximumExpirationTimeInDays { get; set; }

        /// <summary>
        /// Gets or sets the list of authorized partners.
        /// </summary>
        [JsonProperty(PropertyName = "authorizedPartnersList")]
        public IList<Partner> AuthorizedPartnersList { get; set; }

    }
}
