// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class StoreReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreReadSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableMetricsCollection);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableMetricsCollection.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static StoreReadSettings DeserializeStoreReadSettings(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3CompatibleReadSettings": return AmazonS3CompatibleReadSettings.DeserializeAmazonS3CompatibleReadSettings(element);
                    case "AmazonS3ReadSettings": return AmazonS3ReadSettings.DeserializeAmazonS3ReadSettings(element);
                    case "AzureBlobFSReadSettings": return AzureBlobFSReadSettings.DeserializeAzureBlobFSReadSettings(element);
                    case "AzureBlobStorageReadSettings": return AzureBlobStorageReadSettings.DeserializeAzureBlobStorageReadSettings(element);
                    case "AzureDataLakeStoreReadSettings": return AzureDataLakeStoreReadSettings.DeserializeAzureDataLakeStoreReadSettings(element);
                    case "AzureFileStorageReadSettings": return AzureFileStorageReadSettings.DeserializeAzureFileStorageReadSettings(element);
                    case "FileServerReadSettings": return FileServerReadSettings.DeserializeFileServerReadSettings(element);
                    case "FtpReadSettings": return FtpReadSettings.DeserializeFtpReadSettings(element);
                    case "GoogleCloudStorageReadSettings": return GoogleCloudStorageReadSettings.DeserializeGoogleCloudStorageReadSettings(element);
                    case "HdfsReadSettings": return HdfsReadSettings.DeserializeHdfsReadSettings(element);
                    case "HttpReadSettings": return HttpReadSettings.DeserializeHttpReadSettings(element);
                    case "OracleCloudStorageReadSettings": return OracleCloudStorageReadSettings.DeserializeOracleCloudStorageReadSettings(element);
                    case "SftpReadSettings": return SftpReadSettings.DeserializeSftpReadSettings(element);
                }
            }
            return UnknownStoreReadSettings.DeserializeUnknownStoreReadSettings(element);
        }
    }
}
