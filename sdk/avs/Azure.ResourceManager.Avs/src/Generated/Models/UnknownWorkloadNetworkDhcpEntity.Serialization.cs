// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class UnknownWorkloadNetworkDhcpEntity : IUtf8JsonSerializable, IJsonModel<WorkloadNetworkDhcpEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadNetworkDhcpEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadNetworkDhcpEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dhcpType"u8);
            writer.WriteStringValue(DhcpType.ToString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (var item in Segments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision"u8);
                writer.WriteNumberValue(Revision.Value);
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

        WorkloadNetworkDhcpEntity IJsonModel<WorkloadNetworkDhcpEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownWorkloadNetworkDhcpEntity(document.RootElement, options);
        }

        internal static UnknownWorkloadNetworkDhcpEntity DeserializeUnknownWorkloadNetworkDhcpEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DhcpTypeEnum dhcpType = "Unknown";
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> segments = default;
            Optional<WorkloadNetworkDhcpProvisioningState> provisioningState = default;
            Optional<long> revision = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dhcpType"u8))
                {
                    dhcpType = new DhcpTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    segments = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new WorkloadNetworkDhcpProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("revision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    revision = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownWorkloadNetworkDhcpEntity(dhcpType, displayName.Value, Optional.ToList(segments), Optional.ToNullable(provisioningState), Optional.ToNullable(revision), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadNetworkDhcpEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support '{options.Format}' format.");
            }
        }

        WorkloadNetworkDhcpEntity IPersistableModel<WorkloadNetworkDhcpEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownWorkloadNetworkDhcpEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadNetworkDhcpEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
