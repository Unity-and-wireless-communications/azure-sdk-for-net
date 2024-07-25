// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAzureFileDatastore : IUtf8JsonSerializable, IJsonModel<MachineLearningAzureFileDatastore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAzureFileDatastore>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningAzureFileDatastore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureFileDatastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureFileDatastore)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            if (Optional.IsDefined(Endpoint))
            {
                if (Endpoint != null)
                {
                    writer.WritePropertyName("endpoint"u8);
                    writer.WriteStringValue(Endpoint);
                }
                else
                {
                    writer.WriteNull("endpoint");
                }
            }
            writer.WritePropertyName("fileShareName"u8);
            writer.WriteStringValue(FileShareName);
            if (Optional.IsDefined(Protocol))
            {
                if (Protocol != null)
                {
                    writer.WritePropertyName("protocol"u8);
                    writer.WriteStringValue(Protocol);
                }
                else
                {
                    writer.WriteNull("protocol");
                }
            }
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity"u8);
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                if (ResourceGroup != null)
                {
                    writer.WritePropertyName("resourceGroup"u8);
                    writer.WriteStringValue(ResourceGroup);
                }
                else
                {
                    writer.WriteNull("resourceGroup");
                }
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                if (SubscriptionId != null)
                {
                    writer.WritePropertyName("subscriptionId"u8);
                    writer.WriteStringValue(SubscriptionId);
                }
                else
                {
                    writer.WriteNull("subscriptionId");
                }
            }
            writer.WritePropertyName("credentials"u8);
            writer.WriteObjectValue(Credentials, options);
            writer.WritePropertyName("datastoreType"u8);
            writer.WriteStringValue(DatastoreType.ToString());
            if (options.Format != "W" && Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
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

        MachineLearningAzureFileDatastore IJsonModel<MachineLearningAzureFileDatastore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureFileDatastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureFileDatastore)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAzureFileDatastore(document.RootElement, options);
        }

        internal static MachineLearningAzureFileDatastore DeserializeMachineLearningAzureFileDatastore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            string endpoint = default;
            string fileShareName = default;
            string protocol = default;
            MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity = default;
            string resourceGroup = default;
            string subscriptionId = default;
            MachineLearningDatastoreCredentials credentials = default;
            DatastoreType datastoreType = default;
            bool? isDefault = default;
            string description = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileShareName"u8))
                {
                    fileShareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        protocol = null;
                        continue;
                    }
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceDataAccessAuthIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new MachineLearningServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceGroup = null;
                        continue;
                    }
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subscriptionId = null;
                        continue;
                    }
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = MachineLearningDatastoreCredentials.DeserializeMachineLearningDatastoreCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datastoreType"u8))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningAzureFileDatastore(
                description,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                credentials,
                datastoreType,
                isDefault,
                accountName,
                endpoint,
                fileShareName,
                protocol,
                serviceDataAccessAuthIdentity,
                resourceGroup,
                subscriptionId);
        }

        BinaryData IPersistableModel<MachineLearningAzureFileDatastore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureFileDatastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureFileDatastore)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAzureFileDatastore IPersistableModel<MachineLearningAzureFileDatastore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureFileDatastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAzureFileDatastore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureFileDatastore)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAzureFileDatastore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
