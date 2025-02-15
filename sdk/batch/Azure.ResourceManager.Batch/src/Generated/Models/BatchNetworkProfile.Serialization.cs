// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountAccess))
            {
                writer.WritePropertyName("accountAccess"u8);
                writer.WriteObjectValue(AccountAccess);
            }
            if (Optional.IsDefined(NodeManagementAccess))
            {
                writer.WritePropertyName("nodeManagementAccess"u8);
                writer.WriteObjectValue(NodeManagementAccess);
            }
            writer.WriteEndObject();
        }

        internal static BatchNetworkProfile DeserializeBatchNetworkProfile(JsonElement element)
        {
            Optional<BatchEndpointAccessProfile> accountAccess = default;
            Optional<BatchEndpointAccessProfile> nodeManagementAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountAccess = BatchEndpointAccessProfile.DeserializeBatchEndpointAccessProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeManagementAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeManagementAccess = BatchEndpointAccessProfile.DeserializeBatchEndpointAccessProfile(property.Value);
                    continue;
                }
            }
            return new BatchNetworkProfile(accountAccess.Value, nodeManagementAccess.Value);
        }
    }
}
