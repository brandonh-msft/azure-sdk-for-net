// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownJobLimits. </summary>
    internal partial class UnknownJobLimits : MachineLearningJobLimits
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJobLimits"/>. </summary>
        /// <param name="jobLimitsType"> [Required] JobLimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownJobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(jobLimitsType, timeout, serializedAdditionalRawData)
        {
            JobLimitsType = jobLimitsType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownJobLimits"/> for deserialization. </summary>
        internal UnknownJobLimits()
        {
        }
    }
}
