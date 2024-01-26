// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterBackupSchedule : IUtf8JsonSerializable, IJsonModel<CassandraClusterBackupSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterBackupSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterBackupSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleName))
            {
                writer.WritePropertyName("scheduleName"u8);
                writer.WriteStringValue(ScheduleName);
            }
            if (Optional.IsDefined(CronExpression))
            {
                writer.WritePropertyName("cronExpression"u8);
                writer.WriteStringValue(CronExpression);
            }
            if (Optional.IsDefined(RetentionInHours))
            {
                writer.WritePropertyName("retentionInHours"u8);
                writer.WriteNumberValue(RetentionInHours.Value);
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

        CassandraClusterBackupSchedule IJsonModel<CassandraClusterBackupSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterBackupSchedule(document.RootElement, options);
        }

        internal static CassandraClusterBackupSchedule DeserializeCassandraClusterBackupSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scheduleName = default;
            Optional<string> cronExpression = default;
            Optional<int> retentionInHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleName"u8))
                {
                    scheduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cronExpression"u8))
                {
                    cronExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInHours = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterBackupSchedule(scheduleName.Value, cronExpression.Value, Optional.ToNullable(retentionInHours), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraClusterBackupSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterBackupSchedule IPersistableModel<CassandraClusterBackupSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterBackupSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterBackupSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
