// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> A proxy only azure resource object. </summary>
    public partial class ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ProxyOnlyResource. </summary>
        public ProxyOnlyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyOnlyResource. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <param name="type"> Azure resource type. </param>
        internal ProxyOnlyResource(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> Azure resource Id. </summary>
        public string Id { get; }
        /// <summary> Azure resource name. </summary>
        public string Name { get; }
        /// <summary> Azure resource type. </summary>
        public string Type { get; }
    }
}
