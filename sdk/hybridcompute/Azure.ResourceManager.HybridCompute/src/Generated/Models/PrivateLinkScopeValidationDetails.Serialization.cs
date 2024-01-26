// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class PrivateLinkScopeValidationDetails : IUtf8JsonSerializable, IJsonModel<PrivateLinkScopeValidationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateLinkScopeValidationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateLinkScopeValidationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkScopeValidationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkScopeValidationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ConnectionDetails))
            {
                writer.WritePropertyName("connectionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionDetails)
                {
                    writer.WriteObjectValue(item);
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

        PrivateLinkScopeValidationDetails IJsonModel<PrivateLinkScopeValidationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkScopeValidationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkScopeValidationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkScopeValidationDetails(document.RootElement, options);
        }

        internal static PrivateLinkScopeValidationDetails DeserializePrivateLinkScopeValidationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<HybridComputePublicNetworkAccessType> publicNetworkAccess = default;
            Optional<IReadOnlyList<HybridComputeConnectionDetail>> connectionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HybridComputePublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConnectionDetail> array = new List<HybridComputeConnectionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConnectionDetail.DeserializeHybridComputeConnectionDetail(item));
                    }
                    connectionDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateLinkScopeValidationDetails(id.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(connectionDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateLinkScopeValidationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkScopeValidationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkScopeValidationDetails)} does not support '{options.Format}' format.");
            }
        }

        PrivateLinkScopeValidationDetails IPersistableModel<PrivateLinkScopeValidationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkScopeValidationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateLinkScopeValidationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkScopeValidationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateLinkScopeValidationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
