// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentActionConfiguration : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentActionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentActionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIncidentActionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentActionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Classification))
            {
                writer.WritePropertyName("classification"u8);
                writer.WriteStringValue(Classification.Value.ToString());
            }
            if (Optional.IsDefined(ClassificationReason))
            {
                writer.WritePropertyName("classificationReason"u8);
                writer.WriteStringValue(ClassificationReason.Value.ToString());
            }
            if (Optional.IsDefined(ClassificationComment))
            {
                writer.WritePropertyName("classificationComment"u8);
                writer.WriteStringValue(ClassificationComment);
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteObjectValue(Owner);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
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

        SecurityInsightsIncidentActionConfiguration IJsonModel<SecurityInsightsIncidentActionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentActionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentActionConfiguration(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentActionConfiguration DeserializeSecurityInsightsIncidentActionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityInsightsIncidentSeverity> severity = default;
            Optional<SecurityInsightsIncidentStatus> status = default;
            Optional<SecurityInsightsIncidentClassification> classification = default;
            Optional<SecurityInsightsIncidentClassificationReason> classificationReason = default;
            Optional<string> classificationComment = default;
            Optional<SecurityInsightsIncidentOwnerInfo> owner = default;
            Optional<IList<SecurityInsightsIncidentLabel>> labels = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new SecurityInsightsIncidentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SecurityInsightsIncidentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    classification = new SecurityInsightsIncidentClassification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classificationReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    classificationReason = new SecurityInsightsIncidentClassificationReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classificationComment"u8))
                {
                    classificationComment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    owner = SecurityInsightsIncidentOwnerInfo.DeserializeSecurityInsightsIncidentOwnerInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsIncidentLabel> array = new List<SecurityInsightsIncidentLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsIncidentLabel.DeserializeSecurityInsightsIncidentLabel(item));
                    }
                    labels = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentActionConfiguration(Optional.ToNullable(severity), Optional.ToNullable(status), Optional.ToNullable(classification), Optional.ToNullable(classificationReason), classificationComment.Value, owner.Value, Optional.ToList(labels), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIncidentActionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentActionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsIncidentActionConfiguration IPersistableModel<SecurityInsightsIncidentActionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIncidentActionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentActionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIncidentActionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
