// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesRegionSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsDefined(Customsubdomain))
            {
                writer.WritePropertyName("customsubdomain"u8);
                writer.WriteStringValue(Customsubdomain);
            }
            writer.WriteEndObject();
        }

        internal static CognitiveServicesRegionSetting DeserializeCognitiveServicesRegionSetting(JsonElement element)
        {
            Optional<string> name = default;
            Optional<float> value = default;
            Optional<string> customsubdomain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("customsubdomain"u8))
                {
                    customsubdomain = property.Value.GetString();
                    continue;
                }
            }
            return new CognitiveServicesRegionSetting(name.Value, Optional.ToNullable(value), customsubdomain.Value);
        }
    }
}
