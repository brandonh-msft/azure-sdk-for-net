// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class OperationalInsightsTableData : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsTableData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("retentionInDays"u8);
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            if (Optional.IsDefined(TotalRetentionInDays))
            {
                writer.WritePropertyName("totalRetentionInDays"u8);
                writer.WriteNumberValue(TotalRetentionInDays.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ArchiveRetentionInDays))
            {
                writer.WritePropertyName("archiveRetentionInDays"u8);
                writer.WriteNumberValue(ArchiveRetentionInDays.Value);
            }
            if (Optional.IsDefined(SearchResults))
            {
                writer.WritePropertyName("searchResults"u8);
                writer.WriteObjectValue(SearchResults);
            }
            if (Optional.IsDefined(RestoredLogs))
            {
                writer.WritePropertyName("restoredLogs"u8);
                writer.WriteObjectValue(RestoredLogs);
            }
            if (options.Format != "W" && Optional.IsDefined(ResultStatistics))
            {
                writer.WritePropertyName("resultStatistics"u8);
                writer.WriteObjectValue(ResultStatistics);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastPlanModifiedDate))
            {
                writer.WritePropertyName("lastPlanModifiedDate"u8);
                writer.WriteStringValue(LastPlanModifiedDate);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsRetentionInDaysAsDefault))
            {
                writer.WritePropertyName("retentionInDaysAsDefault"u8);
                writer.WriteBooleanValue(IsRetentionInDaysAsDefault.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsTotalRetentionInDaysAsDefault))
            {
                writer.WritePropertyName("totalRetentionInDaysAsDefault"u8);
                writer.WriteBooleanValue(IsTotalRetentionInDaysAsDefault.Value);
            }
            writer.WriteEndObject();
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

        OperationalInsightsTableData IJsonModel<OperationalInsightsTableData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableData(document.RootElement, options);
        }

        internal static OperationalInsightsTableData DeserializeOperationalInsightsTableData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> retentionInDays = default;
            Optional<int> totalRetentionInDays = default;
            Optional<int> archiveRetentionInDays = default;
            Optional<OperationalInsightsTableSearchResults> searchResults = default;
            Optional<OperationalInsightsTableRestoredLogs> restoredLogs = default;
            Optional<OperationalInsightsTableResultStatistics> resultStatistics = default;
            Optional<OperationalInsightsTablePlan> plan = default;
            Optional<string> lastPlanModifiedDate = default;
            Optional<OperationalInsightsSchema> schema = default;
            Optional<OperationalInsightsTableProvisioningState> provisioningState = default;
            Optional<bool> retentionInDaysAsDefault = default;
            Optional<bool> totalRetentionInDaysAsDefault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("retentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("archiveRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            archiveRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("searchResults"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            searchResults = OperationalInsightsTableSearchResults.DeserializeOperationalInsightsTableSearchResults(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("restoredLogs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restoredLogs = OperationalInsightsTableRestoredLogs.DeserializeOperationalInsightsTableRestoredLogs(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resultStatistics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resultStatistics = OperationalInsightsTableResultStatistics.DeserializeOperationalInsightsTableResultStatistics(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            plan = new OperationalInsightsTablePlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastPlanModifiedDate"u8))
                        {
                            lastPlanModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schema = OperationalInsightsSchema.DeserializeOperationalInsightsSchema(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new OperationalInsightsTableProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retentionInDaysAsDefault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionInDaysAsDefault = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("totalRetentionInDaysAsDefault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalRetentionInDaysAsDefault = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsTableData(id, name, type, systemData.Value, Optional.ToNullable(retentionInDays), Optional.ToNullable(totalRetentionInDays), Optional.ToNullable(archiveRetentionInDays), searchResults.Value, restoredLogs.Value, resultStatistics.Value, Optional.ToNullable(plan), lastPlanModifiedDate.Value, schema.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(retentionInDaysAsDefault), Optional.ToNullable(totalRetentionInDaysAsDefault), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsTableData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableData)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsTableData IPersistableModel<OperationalInsightsTableData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsTableData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsTableData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
