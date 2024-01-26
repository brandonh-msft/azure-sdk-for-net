// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AudioTranscriptionSegment : IUtf8JsonSerializable, IJsonModel<AudioTranscriptionSegment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AudioTranscriptionSegment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AudioTranscriptionSegment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscriptionSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscriptionSegment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            writer.WritePropertyName("start"u8);
            writer.WriteNumberValue(Convert.ToDouble(Start.ToString("s\\.fff")));
            writer.WritePropertyName("end"u8);
            writer.WriteNumberValue(Convert.ToDouble(End.ToString("s\\.fff")));
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("temperature"u8);
            writer.WriteNumberValue(Temperature);
            writer.WritePropertyName("avg_logprob"u8);
            writer.WriteNumberValue(AverageLogProbability);
            writer.WritePropertyName("compression_ratio"u8);
            writer.WriteNumberValue(CompressionRatio);
            writer.WritePropertyName("no_speech_prob"u8);
            writer.WriteNumberValue(NoSpeechProbability);
            writer.WritePropertyName("tokens"u8);
            writer.WriteStartArray();
            foreach (var item in Tokens)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("seek"u8);
            writer.WriteNumberValue(Seek);
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

        AudioTranscriptionSegment IJsonModel<AudioTranscriptionSegment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscriptionSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscriptionSegment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranscriptionSegment(document.RootElement, options);
        }

        internal static AudioTranscriptionSegment DeserializeAudioTranscriptionSegment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int id = default;
            TimeSpan start = default;
            TimeSpan end = default;
            string text = default;
            float temperature = default;
            float avgLogprob = default;
            float compressionRatio = default;
            float noSpeechProb = default;
            IReadOnlyList<int> tokens = default;
            int seek = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("avg_logprob"u8))
                {
                    avgLogprob = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("compression_ratio"u8))
                {
                    compressionRatio = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("no_speech_prob"u8))
                {
                    noSpeechProb = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tokens"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    tokens = array;
                    continue;
                }
                if (property.NameEquals("seek"u8))
                {
                    seek = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AudioTranscriptionSegment(id, start, end, text, temperature, avgLogprob, compressionRatio, noSpeechProb, tokens, seek, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AudioTranscriptionSegment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscriptionSegment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranscriptionSegment)} does not support '{options.Format}' format.");
            }
        }

        AudioTranscriptionSegment IPersistableModel<AudioTranscriptionSegment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscriptionSegment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioTranscriptionSegment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranscriptionSegment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranscriptionSegment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AudioTranscriptionSegment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAudioTranscriptionSegment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
