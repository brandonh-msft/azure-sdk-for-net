// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of an artifact source. </summary>
    public partial class DevTestLabArtifactSourcePatch : DevTestLabResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabArtifactSourcePatch"/>. </summary>
        public DevTestLabArtifactSourcePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabArtifactSourcePatch"/>. </summary>
        /// <param name="tags"> The tags of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabArtifactSourcePatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(tags, serializedAdditionalRawData)
        {
        }
    }
}
