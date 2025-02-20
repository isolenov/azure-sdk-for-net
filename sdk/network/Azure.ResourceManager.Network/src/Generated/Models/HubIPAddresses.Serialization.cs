// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubIPAddresses : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicIPs))
            {
                writer.WritePropertyName("publicIPs"u8);
                writer.WriteObjectValue(PublicIPs);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
            }
            writer.WriteEndObject();
        }

        internal static HubIPAddresses DeserializeHubIPAddresses(JsonElement element)
        {
            Optional<HubPublicIPAddresses> publicIPs = default;
            Optional<string> privateIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicIPs = HubPublicIPAddresses.DeserializeHubPublicIPAddresses(property.Value);
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new HubIPAddresses(publicIPs.Value, privateIPAddress.Value);
        }
    }
}
