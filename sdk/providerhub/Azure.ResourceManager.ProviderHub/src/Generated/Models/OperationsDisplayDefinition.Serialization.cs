// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class OperationsDisplayDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("provider"u8);
            writer.WriteStringValue(Provider);
            writer.WritePropertyName("resource"u8);
            writer.WriteStringValue(Resource);
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation);
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            writer.WriteEndObject();
        }

        internal static OperationsDisplayDefinition DeserializeOperationsDisplayDefinition(JsonElement element)
        {
            string provider = default;
            string resource = default;
            string operation = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new OperationsDisplayDefinition(provider, resource, operation, description);
        }
    }
}
