// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownWorkloadItem. </summary>
    internal partial class UnknownWorkloadItem : WorkloadItem
    {
        /// <summary> Initializes a new instance of <see cref="UnknownWorkloadItem"/>. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="workloadItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownWorkloadItem(string backupManagementType, string workloadType, string workloadItemType, string friendlyName, BackupProtectionStatus? protectionState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(backupManagementType, workloadType, workloadItemType, friendlyName, protectionState, serializedAdditionalRawData)
        {
            WorkloadItemType = workloadItemType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownWorkloadItem"/> for deserialization. </summary>
        internal UnknownWorkloadItem()
        {
        }
    }
}
