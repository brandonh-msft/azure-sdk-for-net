// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FeatureSetVersionBackfillContent : IUtf8JsonSerializable, IJsonModel<FeatureSetVersionBackfillContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FeatureSetVersionBackfillContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FeatureSetVersionBackfillContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(FeatureWindow))
            {
                if (FeatureWindow != null)
                {
                    writer.WritePropertyName("featureWindow"u8);
                    writer.WriteObjectValue(FeatureWindow);
                }
                else
                {
                    writer.WriteNull("featureWindow");
                }
            }
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteObjectValue(Resource);
            }
            if (Optional.IsCollectionDefined(SparkConfiguration))
            {
                writer.WritePropertyName("sparkConfiguration"u8);
                writer.WriteStartObject();
                foreach (var item in SparkConfiguration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        FeatureSetVersionBackfillContent IJsonModel<FeatureSetVersionBackfillContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFeatureSetVersionBackfillContent(document.RootElement, options);
        }

        internal static FeatureSetVersionBackfillContent DeserializeFeatureSetVersionBackfillContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<FeatureWindow> featureWindow = default;
            Optional<MaterializationComputeResource> resource = default;
            Optional<IDictionary<string, string>> sparkConfiguration = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureWindow = null;
                        continue;
                    }
                    featureWindow = FeatureWindow.DeserializeFeatureWindow(property.Value);
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resource = MaterializationComputeResource.DeserializeMaterializationComputeResource(property.Value);
                    continue;
                }
                if (property.NameEquals("sparkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sparkConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FeatureSetVersionBackfillContent(description.Value, displayName.Value, featureWindow.Value, resource.Value, Optional.ToDictionary(sparkConfiguration), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FeatureSetVersionBackfillContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support '{options.Format}' format.");
            }
        }

        FeatureSetVersionBackfillContent IPersistableModel<FeatureSetVersionBackfillContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFeatureSetVersionBackfillContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FeatureSetVersionBackfillContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
