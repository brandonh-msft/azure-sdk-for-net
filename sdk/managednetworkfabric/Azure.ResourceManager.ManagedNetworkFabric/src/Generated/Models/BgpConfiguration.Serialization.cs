// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class BgpConfiguration : IUtf8JsonSerializable, IJsonModel<BgpConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BgpConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BgpConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
            }
            if (Optional.IsDefined(DefaultRouteOriginate))
            {
                writer.WritePropertyName("defaultRouteOriginate"u8);
                writer.WriteStringValue(DefaultRouteOriginate.Value.ToString());
            }
            if (Optional.IsDefined(AllowAS))
            {
                writer.WritePropertyName("allowAS"u8);
                writer.WriteNumberValue(AllowAS.Value);
            }
            if (Optional.IsDefined(AllowASOverride))
            {
                writer.WritePropertyName("allowASOverride"u8);
                writer.WriteStringValue(AllowASOverride.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FabricAsn))
            {
                writer.WritePropertyName("fabricASN"u8);
                writer.WriteNumberValue(FabricAsn.Value);
            }
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsCollectionDefined(IPv4ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv4ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv6ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv4NeighborAddress))
            {
                writer.WritePropertyName("ipv4NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4NeighborAddress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6NeighborAddress))
            {
                writer.WritePropertyName("ipv6NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6NeighborAddress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
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

        BgpConfiguration IJsonModel<BgpConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpConfiguration(document.RootElement, options);
        }

        internal static BgpConfiguration DeserializeBgpConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdConfiguration> bfdConfiguration = default;
            Optional<NetworkFabricBooleanValue> defaultRouteOriginate = default;
            Optional<int> allowAS = default;
            Optional<AllowASOverride> allowASOverride = default;
            Optional<long> fabricAsn = default;
            Optional<long> peerAsn = default;
            Optional<IList<string>> ipv4ListenRangePrefixes = default;
            Optional<IList<string>> ipv6ListenRangePrefixes = default;
            Optional<IList<NeighborAddress>> ipv4NeighborAddress = default;
            Optional<IList<NeighborAddress>> ipv6NeighborAddress = default;
            Optional<string> annotation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultRouteOriginate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRouteOriginate = new NetworkFabricBooleanValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowAS = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowASOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowASOverride = new AllowASOverride(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipv4ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv6ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv4NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv4NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("ipv6NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv6NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    annotation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BgpConfiguration(annotation.Value, serializedAdditionalRawData, bfdConfiguration.Value, Optional.ToNullable(defaultRouteOriginate), Optional.ToNullable(allowAS), Optional.ToNullable(allowASOverride), Optional.ToNullable(fabricAsn), Optional.ToNullable(peerAsn), Optional.ToList(ipv4ListenRangePrefixes), Optional.ToList(ipv6ListenRangePrefixes), Optional.ToList(ipv4NeighborAddress), Optional.ToList(ipv6NeighborAddress));
        }

        BinaryData IPersistableModel<BgpConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BgpConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BgpConfiguration IPersistableModel<BgpConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBgpConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BgpConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BgpConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
