// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactProfileLinkChannel : IUtf8JsonSerializable, IJsonModel<OrbitalContactProfileLinkChannel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalContactProfileLinkChannel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrbitalContactProfileLinkChannel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactProfileLinkChannel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactProfileLinkChannel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("centerFrequencyMHz"u8);
            writer.WriteNumberValue(CenterFrequencyMHz);
            writer.WritePropertyName("bandwidthMHz"u8);
            writer.WriteNumberValue(BandwidthMHz);
            writer.WritePropertyName("endPoint"u8);
            writer.WriteObjectValue(EndPoint);
            if (Optional.IsDefined(ModulationConfiguration))
            {
                writer.WritePropertyName("modulationConfiguration"u8);
                writer.WriteStringValue(ModulationConfiguration);
            }
            if (Optional.IsDefined(DemodulationConfiguration))
            {
                writer.WritePropertyName("demodulationConfiguration"u8);
                writer.WriteStringValue(DemodulationConfiguration);
            }
            if (Optional.IsDefined(EncodingConfiguration))
            {
                writer.WritePropertyName("encodingConfiguration"u8);
                writer.WriteStringValue(EncodingConfiguration);
            }
            if (Optional.IsDefined(DecodingConfiguration))
            {
                writer.WritePropertyName("decodingConfiguration"u8);
                writer.WriteStringValue(DecodingConfiguration);
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

        OrbitalContactProfileLinkChannel IJsonModel<OrbitalContactProfileLinkChannel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactProfileLinkChannel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactProfileLinkChannel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalContactProfileLinkChannel(document.RootElement, options);
        }

        internal static OrbitalContactProfileLinkChannel DeserializeOrbitalContactProfileLinkChannel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float centerFrequencyMHz = default;
            float bandwidthMHz = default;
            OrbitalContactEndpoint endPoint = default;
            Optional<string> modulationConfiguration = default;
            Optional<string> demodulationConfiguration = default;
            Optional<string> encodingConfiguration = default;
            Optional<string> decodingConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("centerFrequencyMHz"u8))
                {
                    centerFrequencyMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bandwidthMHz"u8))
                {
                    bandwidthMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("endPoint"u8))
                {
                    endPoint = OrbitalContactEndpoint.DeserializeOrbitalContactEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("modulationConfiguration"u8))
                {
                    modulationConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("demodulationConfiguration"u8))
                {
                    demodulationConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodingConfiguration"u8))
                {
                    encodingConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("decodingConfiguration"u8))
                {
                    decodingConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrbitalContactProfileLinkChannel(name, centerFrequencyMHz, bandwidthMHz, endPoint, modulationConfiguration.Value, demodulationConfiguration.Value, encodingConfiguration.Value, decodingConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalContactProfileLinkChannel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactProfileLinkChannel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactProfileLinkChannel)} does not support '{options.Format}' format.");
            }
        }

        OrbitalContactProfileLinkChannel IPersistableModel<OrbitalContactProfileLinkChannel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactProfileLinkChannel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrbitalContactProfileLinkChannel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactProfileLinkChannel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrbitalContactProfileLinkChannel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
