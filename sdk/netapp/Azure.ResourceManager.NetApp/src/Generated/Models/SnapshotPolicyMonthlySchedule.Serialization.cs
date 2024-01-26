// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyMonthlySchedule : IUtf8JsonSerializable, IJsonModel<SnapshotPolicyMonthlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotPolicyMonthlySchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotPolicyMonthlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotPolicyMonthlySchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SnapshotsToKeep))
            {
                writer.WritePropertyName("snapshotsToKeep"u8);
                writer.WriteNumberValue(SnapshotsToKeep.Value);
            }
            if (Optional.IsDefined(DaysOfMonth))
            {
                writer.WritePropertyName("daysOfMonth"u8);
                writer.WriteStringValue(DaysOfMonth);
            }
            if (Optional.IsDefined(Hour))
            {
                writer.WritePropertyName("hour"u8);
                writer.WriteNumberValue(Hour.Value);
            }
            if (Optional.IsDefined(Minute))
            {
                writer.WritePropertyName("minute"u8);
                writer.WriteNumberValue(Minute.Value);
            }
            if (Optional.IsDefined(UsedBytes))
            {
                writer.WritePropertyName("usedBytes"u8);
                writer.WriteNumberValue(UsedBytes.Value);
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

        SnapshotPolicyMonthlySchedule IJsonModel<SnapshotPolicyMonthlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotPolicyMonthlySchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotPolicyMonthlySchedule(document.RootElement, options);
        }

        internal static SnapshotPolicyMonthlySchedule DeserializeSnapshotPolicyMonthlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> snapshotsToKeep = default;
            Optional<string> daysOfMonth = default;
            Optional<int> hour = default;
            Optional<int> minute = default;
            Optional<long> usedBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotsToKeep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotsToKeep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("daysOfMonth"u8))
                {
                    daysOfMonth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotPolicyMonthlySchedule(Optional.ToNullable(snapshotsToKeep), daysOfMonth.Value, Optional.ToNullable(hour), Optional.ToNullable(minute), Optional.ToNullable(usedBytes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotPolicyMonthlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotPolicyMonthlySchedule)} does not support '{options.Format}' format.");
            }
        }

        SnapshotPolicyMonthlySchedule IPersistableModel<SnapshotPolicyMonthlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotPolicyMonthlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotPolicyMonthlySchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotPolicyMonthlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
