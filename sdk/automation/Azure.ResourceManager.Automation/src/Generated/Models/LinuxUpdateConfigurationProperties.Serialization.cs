// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class LinuxUpdateConfigurationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IncludedPackageClassifications))
            {
                writer.WritePropertyName("includedPackageClassifications"u8);
                writer.WriteStringValue(IncludedPackageClassifications.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExcludedPackageNameMasks))
            {
                writer.WritePropertyName("excludedPackageNameMasks"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPackageNameMasks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedPackageNameMasks))
            {
                writer.WritePropertyName("includedPackageNameMasks"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedPackageNameMasks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting);
            }
            writer.WriteEndObject();
        }

        internal static LinuxUpdateConfigurationProperties DeserializeLinuxUpdateConfigurationProperties(JsonElement element)
        {
            Optional<LinuxUpdateClassification> includedPackageClassifications = default;
            Optional<IList<string>> excludedPackageNameMasks = default;
            Optional<IList<string>> includedPackageNameMasks = default;
            Optional<string> rebootSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includedPackageClassifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includedPackageClassifications = new LinuxUpdateClassification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("excludedPackageNameMasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedPackageNameMasks = array;
                    continue;
                }
                if (property.NameEquals("includedPackageNameMasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedPackageNameMasks = array;
                    continue;
                }
                if (property.NameEquals("rebootSetting"u8))
                {
                    rebootSetting = property.Value.GetString();
                    continue;
                }
            }
            return new LinuxUpdateConfigurationProperties(Optional.ToNullable(includedPackageClassifications), Optional.ToList(excludedPackageNameMasks), Optional.ToList(includedPackageNameMasks), rebootSetting.Value);
        }
    }
}
