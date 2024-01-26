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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DataCollectionEndpointData : IUtf8JsonSerializable, IJsonModel<DataCollectionEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionEndpointData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ImmutableId))
            {
                writer.WritePropertyName("immutableId"u8);
                writer.WriteStringValue(ImmutableId);
            }
            if (Optional.IsDefined(ConfigurationAccess))
            {
                writer.WritePropertyName("configurationAccess"u8);
                writer.WriteObjectValue(ConfigurationAccess);
            }
            if (Optional.IsDefined(LogsIngestion))
            {
                writer.WritePropertyName("logsIngestion"u8);
                writer.WriteObjectValue(LogsIngestion);
            }
            if (Optional.IsDefined(MetricsIngestion))
            {
                writer.WritePropertyName("metricsIngestion"u8);
                writer.WriteObjectValue(MetricsIngestion);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkAcls);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateLinkScopedResources))
            {
                writer.WritePropertyName("privateLinkScopedResources"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkScopedResources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(FailoverConfiguration))
            {
                writer.WritePropertyName("failoverConfiguration"u8);
                writer.WriteObjectValue(FailoverConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
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

        DataCollectionEndpointData IJsonModel<DataCollectionEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointData(document.RootElement, options);
        }

        internal static DataCollectionEndpointData DeserializeDataCollectionEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataCollectionEndpointResourceKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> immutableId = default;
            Optional<DataCollectionEndpointConfigurationAccess> configurationAccess = default;
            Optional<DataCollectionEndpointLogsIngestion> logsIngestion = default;
            Optional<DataCollectionEndpointMetricsIngestion> metricsIngestion = default;
            Optional<DataCollectionEndpointNetworkAcls> networkAcls = default;
            Optional<DataCollectionEndpointProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<DataCollectionRulePrivateLinkScopedResourceInfo>> privateLinkScopedResources = default;
            Optional<DataCollectionEndpointFailoverConfiguration> failoverConfiguration = default;
            Optional<DataCollectionEndpointMetadata> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DataCollectionEndpointResourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("immutableId"u8))
                        {
                            immutableId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationAccess = DataCollectionEndpointConfigurationAccess.DeserializeDataCollectionEndpointConfigurationAccess(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logsIngestion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logsIngestion = DataCollectionEndpointLogsIngestion.DeserializeDataCollectionEndpointLogsIngestion(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("metricsIngestion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metricsIngestion = DataCollectionEndpointMetricsIngestion.DeserializeDataCollectionEndpointMetricsIngestion(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = DataCollectionEndpointNetworkAcls.DeserializeDataCollectionEndpointNetworkAcls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataCollectionEndpointProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataCollectionRulePrivateLinkScopedResourceInfo> array = new List<DataCollectionRulePrivateLinkScopedResourceInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataCollectionRulePrivateLinkScopedResourceInfo.DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(item));
                            }
                            privateLinkScopedResources = array;
                            continue;
                        }
                        if (property0.NameEquals("failoverConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverConfiguration = DataCollectionEndpointFailoverConfiguration.DeserializeDataCollectionEndpointFailoverConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = DataCollectionEndpointMetadata.DeserializeDataCollectionEndpointMetadata(property0.Value);
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
            return new DataCollectionEndpointData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(kind), identity, Optional.ToNullable(etag), description.Value, immutableId.Value, configurationAccess.Value, logsIngestion.Value, metricsIngestion.Value, networkAcls.Value, Optional.ToNullable(provisioningState), Optional.ToList(privateLinkScopedResources), failoverConfiguration.Value, metadata.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionEndpointData IPersistableModel<DataCollectionEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
