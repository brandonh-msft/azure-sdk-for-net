// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    [PersistableModelProxy(typeof(UnknownLimitJsonObject))]
    public partial class QuotaLimitJsonObject : IUtf8JsonSerializable, IJsonModel<QuotaLimitJsonObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaLimitJsonObject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaLimitJsonObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaLimitJsonObject)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("limitObjectType"u8);
            writer.WriteStringValue(LimitObjectType.ToString());
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

        QuotaLimitJsonObject IJsonModel<QuotaLimitJsonObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitJsonObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaLimitJsonObject)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaLimitJsonObject(document.RootElement, options);
        }

        internal static QuotaLimitJsonObject DeserializeQuotaLimitJsonObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("limitObjectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LimitValue": return QuotaLimitObject.DeserializeQuotaLimitObject(element);
                }
            }
            return UnknownLimitJsonObject.DeserializeUnknownLimitJsonObject(element);
        }

        BinaryData IPersistableModel<QuotaLimitJsonObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitJsonObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaLimitJsonObject)} does not support '{options.Format}' format.");
            }
        }

        QuotaLimitJsonObject IPersistableModel<QuotaLimitJsonObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitJsonObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaLimitJsonObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaLimitJsonObject)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaLimitJsonObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
