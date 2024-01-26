// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ExportDefinition : IUtf8JsonSerializable, IJsonModel<ExportDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExportDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExportType.ToString());
            writer.WritePropertyName("timeframe"u8);
            writer.WriteStringValue(Timeframe.ToString());
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod);
            }
            if (Optional.IsDefined(DataSet))
            {
                writer.WritePropertyName("dataSet"u8);
                writer.WriteObjectValue(DataSet);
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

        ExportDefinition IJsonModel<ExportDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportDefinition(document.RootElement, options);
        }

        internal static ExportDefinition DeserializeExportDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExportType type = default;
            TimeframeType timeframe = default;
            Optional<ExportTimePeriod> timePeriod = default;
            Optional<ExportDataset> dataSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ExportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeframe"u8))
                {
                    timeframe = new TimeframeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timePeriod = ExportTimePeriod.DeserializeExportTimePeriod(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSet = ExportDataset.DeserializeExportDataset(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExportDefinition(type, timeframe, timePeriod.Value, dataSet.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportDefinition)} does not support '{options.Format}' format.");
            }
        }

        ExportDefinition IPersistableModel<ExportDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
