// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownProtectionPolicy))]
    public partial class BackupGenericProtectionPolicy : IUtf8JsonSerializable, IJsonModel<BackupGenericProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericProtectionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupGenericProtectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType"u8);
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BackupGenericProtectionPolicy IJsonModel<BackupGenericProtectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectionPolicy(document.RootElement, options);
        }

        internal static BackupGenericProtectionPolicy DeserializeBackupGenericProtectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("backupManagementType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureIaasVM": return IaasVmProtectionPolicy.DeserializeIaasVmProtectionPolicy(element);
                    case "AzureSql": return SqlProtectionPolicy.DeserializeSqlProtectionPolicy(element);
                    case "AzureStorage": return FileShareProtectionPolicy.DeserializeFileShareProtectionPolicy(element);
                    case "AzureWorkload": return VmWorkloadProtectionPolicy.DeserializeVmWorkloadProtectionPolicy(element);
                    case "GenericProtectionPolicy": return GenericProtectionPolicy.DeserializeGenericProtectionPolicy(element);
                    case "MAB": return MabProtectionPolicy.DeserializeMabProtectionPolicy(element);
                }
            }
            return UnknownProtectionPolicy.DeserializeUnknownProtectionPolicy(element);
        }

        BinaryData IPersistableModel<BackupGenericProtectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        BackupGenericProtectionPolicy IPersistableModel<BackupGenericProtectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupGenericProtectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericProtectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
