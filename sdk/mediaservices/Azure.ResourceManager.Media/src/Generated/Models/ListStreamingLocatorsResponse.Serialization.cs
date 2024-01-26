// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class ListStreamingLocatorsResponse : IUtf8JsonSerializable, IJsonModel<ListStreamingLocatorsResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ListStreamingLocatorsResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ListStreamingLocatorsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListStreamingLocatorsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListStreamingLocatorsResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(StreamingLocators))
            {
                writer.WritePropertyName("streamingLocators"u8);
                writer.WriteStartArray();
                foreach (var item in StreamingLocators)
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

        ListStreamingLocatorsResponse IJsonModel<ListStreamingLocatorsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListStreamingLocatorsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListStreamingLocatorsResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListStreamingLocatorsResponse(document.RootElement, options);
        }

        internal static ListStreamingLocatorsResponse DeserializeListStreamingLocatorsResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MediaAssetStreamingLocator>> streamingLocators = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingLocators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaAssetStreamingLocator> array = new List<MediaAssetStreamingLocator>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaAssetStreamingLocator.DeserializeMediaAssetStreamingLocator(item));
                    }
                    streamingLocators = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ListStreamingLocatorsResponse(Optional.ToList(streamingLocators), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ListStreamingLocatorsResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListStreamingLocatorsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ListStreamingLocatorsResponse)} does not support '{options.Format}' format.");
            }
        }

        ListStreamingLocatorsResponse IPersistableModel<ListStreamingLocatorsResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListStreamingLocatorsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeListStreamingLocatorsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ListStreamingLocatorsResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ListStreamingLocatorsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
