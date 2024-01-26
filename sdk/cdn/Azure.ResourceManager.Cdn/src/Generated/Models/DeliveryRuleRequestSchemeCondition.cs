// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the RequestScheme condition for the delivery rule. </summary>
    public partial class DeliveryRuleRequestSchemeCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestSchemeCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleRequestSchemeCondition(RequestSchemeMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.RequestScheme;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestSchemeCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleRequestSchemeCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, RequestSchemeMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestSchemeCondition"/> for deserialization. </summary>
        internal DeliveryRuleRequestSchemeCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public RequestSchemeMatchCondition Properties { get; set; }
    }
}
