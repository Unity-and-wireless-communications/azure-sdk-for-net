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

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVolumeGroupPatch : IUtf8JsonSerializable, IJsonModel<ElasticSanVolumeGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticSanVolumeGroupPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticSanVolumeGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolType))
            {
                writer.WritePropertyName("protocolType"u8);
                writer.WriteStringValue(ProtocolType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteStringValue(Encryption.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionProperties))
            {
                writer.WritePropertyName("encryptionProperties"u8);
                writer.WriteObjectValue(EncryptionProperties, options);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkAcls, options);
            }
            if (Optional.IsDefined(EnforceDataIntegrityCheckForIscsi))
            {
                writer.WritePropertyName("enforceDataIntegrityCheckForIscsi"u8);
                writer.WriteBooleanValue(EnforceDataIntegrityCheckForIscsi.Value);
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

        ElasticSanVolumeGroupPatch IJsonModel<ElasticSanVolumeGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanVolumeGroupPatch(document.RootElement, options);
        }

        internal static ElasticSanVolumeGroupPatch DeserializeElasticSanVolumeGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            ElasticSanStorageTargetType? protocolType = default;
            ElasticSanEncryptionType? encryption = default;
            ElasticSanEncryptionProperties encryptionProperties = default;
            NetworkRuleSet networkAcls = default;
            bool? enforceDataIntegrityCheckForIscsi = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("protocolType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocolType = new ElasticSanStorageTargetType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = new ElasticSanEncryptionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProperties = ElasticSanEncryptionProperties.DeserializeElasticSanEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enforceDataIntegrityCheckForIscsi"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enforceDataIntegrityCheckForIscsi = property0.Value.GetBoolean();
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
            return new ElasticSanVolumeGroupPatch(
                identity,
                protocolType,
                encryption,
                encryptionProperties,
                networkAcls,
                enforceDataIntegrityCheckForIscsi,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticSanVolumeGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticSanVolumeGroupPatch IPersistableModel<ElasticSanVolumeGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanVolumeGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticSanVolumeGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticSanVolumeGroupPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticSanVolumeGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
