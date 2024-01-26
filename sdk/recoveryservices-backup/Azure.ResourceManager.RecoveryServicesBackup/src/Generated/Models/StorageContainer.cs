// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure Storage Account workload-specific container. </summary>
    public partial class StorageContainer : BackupGenericProtectionContainer
    {
        /// <summary> Initializes a new instance of <see cref="StorageContainer"/>. </summary>
        public StorageContainer()
        {
            ContainerType = ProtectableContainerType.StorageContainer;
        }

        /// <summary> Initializes a new instance of <see cref="StorageContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM url. </param>
        /// <param name="storageAccountVersion"> Storage account version. </param>
        /// <param name="resourceGroup"> Resource group name of Recovery Services Vault. </param>
        /// <param name="protectedItemCount"> Number of items backed up in this container. </param>
        /// <param name="acquireStorageAccountLock"> Whether storage account lock is to be acquired for this container or not. </param>
        internal StorageContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier sourceResourceId, string storageAccountVersion, string resourceGroup, long? protectedItemCount, AcquireStorageAccountLock? acquireStorageAccountLock) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType, serializedAdditionalRawData)
        {
            SourceResourceId = sourceResourceId;
            StorageAccountVersion = storageAccountVersion;
            ResourceGroup = resourceGroup;
            ProtectedItemCount = protectedItemCount;
            AcquireStorageAccountLock = acquireStorageAccountLock;
            ContainerType = containerType;
        }

        /// <summary> Fully qualified ARM url. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> Storage account version. </summary>
        public string StorageAccountVersion { get; set; }
        /// <summary> Resource group name of Recovery Services Vault. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Number of items backed up in this container. </summary>
        public long? ProtectedItemCount { get; set; }
        /// <summary> Whether storage account lock is to be acquired for this container or not. </summary>
        public AcquireStorageAccountLock? AcquireStorageAccountLock { get; set; }
    }
}
