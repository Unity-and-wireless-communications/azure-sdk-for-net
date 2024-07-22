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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayData : IUtf8JsonSerializable, IJsonModel<VirtualNetworkGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkGatewayData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualNetworkGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoScaleConfiguration))
            {
                writer.WritePropertyName("autoScaleConfiguration"u8);
                writer.WriteObjectValue(AutoScaleConfiguration, options);
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GatewayType))
            {
                writer.WritePropertyName("gatewayType"u8);
                writer.WriteStringValue(GatewayType.Value.ToString());
            }
            if (Optional.IsDefined(VpnType))
            {
                writer.WritePropertyName("vpnType"u8);
                writer.WriteStringValue(VpnType.Value.ToString());
            }
            if (Optional.IsDefined(VpnGatewayGeneration))
            {
                writer.WritePropertyName("vpnGatewayGeneration"u8);
                writer.WriteStringValue(VpnGatewayGeneration.Value.ToString());
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsDefined(EnablePrivateIPAddress))
            {
                writer.WritePropertyName("enablePrivateIpAddress"u8);
                writer.WriteBooleanValue(EnablePrivateIPAddress.Value);
            }
            if (Optional.IsDefined(Active))
            {
                writer.WritePropertyName("activeActive"u8);
                writer.WriteBooleanValue(Active.Value);
            }
            if (Optional.IsDefined(DisableIPSecReplayProtection))
            {
                writer.WritePropertyName("disableIPSecReplayProtection"u8);
                writer.WriteBooleanValue(DisableIPSecReplayProtection.Value);
            }
            if (Optional.IsDefined(GatewayDefaultSite))
            {
                writer.WritePropertyName("gatewayDefaultSite"u8);
                JsonSerializer.Serialize(writer, GatewayDefaultSite);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(VpnClientConfiguration))
            {
                writer.WritePropertyName("vpnClientConfiguration"u8);
                writer.WriteObjectValue(VpnClientConfiguration, options);
            }
            if (Optional.IsCollectionDefined(VirtualNetworkGatewayPolicyGroups))
            {
                writer.WritePropertyName("virtualNetworkGatewayPolicyGroups"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkGatewayPolicyGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BgpSettings))
            {
                writer.WritePropertyName("bgpSettings"u8);
                writer.WriteObjectValue(BgpSettings, options);
            }
            if (Optional.IsDefined(CustomRoutes))
            {
                writer.WritePropertyName("customRoutes"u8);
                writer.WriteObjectValue(CustomRoutes, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(EnableDnsForwarding))
            {
                writer.WritePropertyName("enableDnsForwarding"u8);
                writer.WriteBooleanValue(EnableDnsForwarding.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InboundDnsForwardingEndpoint))
            {
                writer.WritePropertyName("inboundDnsForwardingEndpoint"u8);
                writer.WriteStringValue(InboundDnsForwardingEndpoint);
            }
            if (Optional.IsDefined(VNetExtendedLocationResourceId))
            {
                writer.WritePropertyName("vNetExtendedLocationResourceId"u8);
                writer.WriteStringValue(VNetExtendedLocationResourceId);
            }
            if (Optional.IsCollectionDefined(NatRules))
            {
                writer.WritePropertyName("natRules"u8);
                writer.WriteStartArray();
                foreach (var item in NatRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableBgpRouteTranslationForNat))
            {
                writer.WritePropertyName("enableBgpRouteTranslationForNat"u8);
                writer.WriteBooleanValue(EnableBgpRouteTranslationForNat.Value);
            }
            if (Optional.IsDefined(AllowVirtualWanTraffic))
            {
                writer.WritePropertyName("allowVirtualWanTraffic"u8);
                writer.WriteBooleanValue(AllowVirtualWanTraffic.Value);
            }
            if (Optional.IsDefined(AllowRemoteVnetTraffic))
            {
                writer.WritePropertyName("allowRemoteVnetTraffic"u8);
                writer.WriteBooleanValue(AllowRemoteVnetTraffic.Value);
            }
            if (Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState"u8);
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            if (Optional.IsDefined(ResiliencyModel))
            {
                writer.WritePropertyName("resiliencyModel"u8);
                writer.WriteStringValue(ResiliencyModel.Value.ToString());
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

        VirtualNetworkGatewayData IJsonModel<VirtualNetworkGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkGatewayData(document.RootElement, options);
        }

        internal static VirtualNetworkGatewayData DeserializeVirtualNetworkGatewayData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            ETag? etag = default;
            ManagedServiceIdentity identity = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            VirtualNetworkGatewayAutoScaleConfiguration autoScaleConfiguration = default;
            IList<VirtualNetworkGatewayIPConfiguration> ipConfigurations = default;
            VirtualNetworkGatewayType? gatewayType = default;
            VpnType? vpnType = default;
            VpnGatewayGeneration? vpnGatewayGeneration = default;
            bool? enableBgp = default;
            bool? enablePrivateIPAddress = default;
            bool? activeActive = default;
            bool? disableIPSecReplayProtection = default;
            WritableSubResource gatewayDefaultSite = default;
            VirtualNetworkGatewaySku sku = default;
            VpnClientConfiguration vpnClientConfiguration = default;
            IList<VirtualNetworkGatewayPolicyGroup> virtualNetworkGatewayPolicyGroups = default;
            BgpSettings bgpSettings = default;
            AddressSpace customRoutes = default;
            Guid? resourceGuid = default;
            NetworkProvisioningState? provisioningState = default;
            bool? enableDnsForwarding = default;
            string inboundDnsForwardingEndpoint = default;
            ResourceIdentifier vNetExtendedLocationResourceId = default;
            IList<VirtualNetworkGatewayNatRuleData> natRules = default;
            bool? enableBgpRouteTranslationForNat = default;
            bool? allowVirtualWanTraffic = default;
            bool? allowRemoteVnetTraffic = default;
            ExpressRouteGatewayAdminState? adminState = default;
            ResiliencyModel? resiliencyModel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
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
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("autoScaleConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScaleConfiguration = VirtualNetworkGatewayAutoScaleConfiguration.DeserializeVirtualNetworkGatewayAutoScaleConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkGatewayIPConfiguration> array = new List<VirtualNetworkGatewayIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkGatewayIPConfiguration.DeserializeVirtualNetworkGatewayIPConfiguration(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("gatewayType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayType = new VirtualNetworkGatewayType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnType = new VpnType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGatewayGeneration = new VpnGatewayGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePrivateIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePrivateIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("activeActive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            activeActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableIPSecReplayProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableIPSecReplayProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gatewayDefaultSite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayDefaultSite = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = VirtualNetworkGatewaySku.DeserializeVirtualNetworkGatewaySku(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnClientConfiguration = VpnClientConfiguration.DeserializeVpnClientConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGatewayPolicyGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkGatewayPolicyGroup> array = new List<VirtualNetworkGatewayPolicyGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkGatewayPolicyGroup.DeserializeVirtualNetworkGatewayPolicyGroup(item, options));
                            }
                            virtualNetworkGatewayPolicyGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customRoutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customRoutes = AddressSpace.DeserializeAddressSpace(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableDnsForwarding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDnsForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("inboundDnsForwardingEndpoint"u8))
                        {
                            inboundDnsForwardingEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vNetExtendedLocationResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vNetExtendedLocationResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("natRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkGatewayNatRuleData> array = new List<VirtualNetworkGatewayNatRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkGatewayNatRuleData.DeserializeVirtualNetworkGatewayNatRuleData(item, options));
                            }
                            natRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableBgpRouteTranslationForNat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgpRouteTranslationForNat = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowVirtualWanTraffic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowVirtualWanTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowRemoteVnetTraffic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowRemoteVnetTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("adminState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new ExpressRouteGatewayAdminState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resiliencyModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resiliencyModel = new ResiliencyModel(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualNetworkGatewayData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                extendedLocation,
                etag,
                identity,
                autoScaleConfiguration,
                ipConfigurations ?? new ChangeTrackingList<VirtualNetworkGatewayIPConfiguration>(),
                gatewayType,
                vpnType,
                vpnGatewayGeneration,
                enableBgp,
                enablePrivateIPAddress,
                activeActive,
                disableIPSecReplayProtection,
                gatewayDefaultSite,
                sku,
                vpnClientConfiguration,
                virtualNetworkGatewayPolicyGroups ?? new ChangeTrackingList<VirtualNetworkGatewayPolicyGroup>(),
                bgpSettings,
                customRoutes,
                resourceGuid,
                provisioningState,
                enableDnsForwarding,
                inboundDnsForwardingEndpoint,
                vNetExtendedLocationResourceId,
                natRules ?? new ChangeTrackingList<VirtualNetworkGatewayNatRuleData>(),
                enableBgpRouteTranslationForNat,
                allowVirtualWanTraffic,
                allowRemoteVnetTraffic,
                adminState,
                resiliencyModel);
        }

        BinaryData IPersistableModel<VirtualNetworkGatewayData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkGatewayData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualNetworkGatewayData IPersistableModel<VirtualNetworkGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkGatewayData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkGatewayData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
