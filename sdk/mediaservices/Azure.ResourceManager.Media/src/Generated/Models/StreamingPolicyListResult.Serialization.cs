// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingPolicyListResult : IUtf8JsonSerializable, IJsonModel<StreamingPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingPolicyListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OdataNextLink))
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(OdataNextLink);
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

        StreamingPolicyListResult IJsonModel<StreamingPolicyListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyListResult(document.RootElement, options);
        }

        internal static StreamingPolicyListResult DeserializeStreamingPolicyListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StreamingPolicyData>> value = default;
            Optional<string> odataNextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingPolicyData> array = new List<StreamingPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingPolicyData.DeserializeStreamingPolicyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingPolicyListResult(Optional.ToList(value), odataNextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyListResult)} does not support '{options.Format}' format.");
            }
        }

        StreamingPolicyListResult IPersistableModel<StreamingPolicyListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingPolicyListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPolicyListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
