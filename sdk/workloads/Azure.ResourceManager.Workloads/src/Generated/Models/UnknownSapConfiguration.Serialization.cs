// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSapConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownSapConfiguration DeserializeUnknownSapConfiguration(JsonElement element)
        {
            SapConfigurationType configurationType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSapConfiguration(configurationType);
        }
    }
}
