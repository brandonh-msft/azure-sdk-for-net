// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class CloudCapacity : IUtf8JsonSerializable, IJsonModel<CloudCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudCapacity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuCount))
            {
                writer.WritePropertyName("cpuCount"u8);
                writer.WriteNumberValue(CpuCount.Value);
            }
            if (Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Optional.IsDefined(VmCount))
            {
                writer.WritePropertyName("vmCount"u8);
                writer.WriteNumberValue(VmCount.Value);
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

        CloudCapacity IJsonModel<CloudCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudCapacity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudCapacity(document.RootElement, options);
        }

        internal static CloudCapacity DeserializeCloudCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> cpuCount = default;
            Optional<long> memoryMB = default;
            Optional<long> vmCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vmCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudCapacity(Optional.ToNullable(cpuCount), Optional.ToNullable(memoryMB), Optional.ToNullable(vmCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudCapacity)} does not support '{options.Format}' format.");
            }
        }

        CloudCapacity IPersistableModel<CloudCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudCapacity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
