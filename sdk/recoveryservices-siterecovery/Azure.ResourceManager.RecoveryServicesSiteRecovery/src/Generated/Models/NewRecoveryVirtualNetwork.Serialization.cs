// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class NewRecoveryVirtualNetwork : IUtf8JsonSerializable, IJsonModel<NewRecoveryVirtualNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRecoveryVirtualNetwork>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRecoveryVirtualNetwork>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRecoveryVirtualNetwork)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryVirtualNetworkResourceGroupName))
            {
                writer.WritePropertyName("recoveryVirtualNetworkResourceGroupName"u8);
                writer.WriteStringValue(RecoveryVirtualNetworkResourceGroupName);
            }
            if (Optional.IsDefined(RecoveryVirtualNetworkName))
            {
                writer.WritePropertyName("recoveryVirtualNetworkName"u8);
                writer.WriteStringValue(RecoveryVirtualNetworkName);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        NewRecoveryVirtualNetwork IJsonModel<NewRecoveryVirtualNetwork>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRecoveryVirtualNetwork)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRecoveryVirtualNetwork(document.RootElement, options);
        }

        internal static NewRecoveryVirtualNetwork DeserializeNewRecoveryVirtualNetwork(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryVirtualNetworkResourceGroupName = default;
            Optional<string> recoveryVirtualNetworkName = default;
            string resourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryVirtualNetworkResourceGroupName"u8))
                {
                    recoveryVirtualNetworkResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryVirtualNetworkName"u8))
                {
                    recoveryVirtualNetworkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRecoveryVirtualNetwork(resourceType, serializedAdditionalRawData, recoveryVirtualNetworkResourceGroupName.Value, recoveryVirtualNetworkName.Value);
        }

        BinaryData IPersistableModel<NewRecoveryVirtualNetwork>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRecoveryVirtualNetwork)} does not support '{options.Format}' format.");
            }
        }

        NewRecoveryVirtualNetwork IPersistableModel<NewRecoveryVirtualNetwork>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRecoveryVirtualNetwork(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRecoveryVirtualNetwork)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRecoveryVirtualNetwork>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
