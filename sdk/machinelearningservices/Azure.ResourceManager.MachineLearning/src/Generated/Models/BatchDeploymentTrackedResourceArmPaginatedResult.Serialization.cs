// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class BatchDeploymentTrackedResourceArmPaginatedResult : IUtf8JsonSerializable, IJsonModel<BatchDeploymentTrackedResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchDeploymentTrackedResourceArmPaginatedResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchDeploymentTrackedResourceArmPaginatedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchDeploymentTrackedResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
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

        BatchDeploymentTrackedResourceArmPaginatedResult IJsonModel<BatchDeploymentTrackedResourceArmPaginatedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchDeploymentTrackedResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchDeploymentTrackedResourceArmPaginatedResult(document.RootElement, options);
        }

        internal static BatchDeploymentTrackedResourceArmPaginatedResult DeserializeBatchDeploymentTrackedResourceArmPaginatedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningBatchDeploymentData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningBatchDeploymentData> array = new List<MachineLearningBatchDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningBatchDeploymentData.DeserializeMachineLearningBatchDeploymentData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchDeploymentTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchDeploymentTrackedResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        BatchDeploymentTrackedResourceArmPaginatedResult IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchDeploymentTrackedResourceArmPaginatedResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchDeploymentTrackedResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchDeploymentTrackedResourceArmPaginatedResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
