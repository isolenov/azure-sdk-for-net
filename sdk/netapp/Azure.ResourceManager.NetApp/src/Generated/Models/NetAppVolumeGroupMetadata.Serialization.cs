// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeGroupMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupDescription))
            {
                writer.WritePropertyName("groupDescription"u8);
                writer.WriteStringValue(GroupDescription);
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationIdentifier))
            {
                writer.WritePropertyName("applicationIdentifier"u8);
                writer.WriteStringValue(ApplicationIdentifier);
            }
            if (Optional.IsCollectionDefined(GlobalPlacementRules))
            {
                writer.WritePropertyName("globalPlacementRules"u8);
                writer.WriteStartArray();
                foreach (var item in GlobalPlacementRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DeploymentSpecId))
            {
                writer.WritePropertyName("deploymentSpecId"u8);
                writer.WriteStringValue(DeploymentSpecId);
            }
            writer.WriteEndObject();
        }

        internal static NetAppVolumeGroupMetadata DeserializeNetAppVolumeGroupMetadata(JsonElement element)
        {
            Optional<string> groupDescription = default;
            Optional<NetAppApplicationType> applicationType = default;
            Optional<string> applicationIdentifier = default;
            Optional<IList<NetAppVolumePlacementRule>> globalPlacementRules = default;
            Optional<string> deploymentSpecId = default;
            Optional<long> volumesCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupDescription"u8))
                {
                    groupDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationType = new NetAppApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationIdentifier"u8))
                {
                    applicationIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("globalPlacementRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NetAppVolumePlacementRule> array = new List<NetAppVolumePlacementRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumePlacementRule.DeserializeNetAppVolumePlacementRule(item));
                    }
                    globalPlacementRules = array;
                    continue;
                }
                if (property.NameEquals("deploymentSpecId"u8))
                {
                    deploymentSpecId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    volumesCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new NetAppVolumeGroupMetadata(groupDescription.Value, Optional.ToNullable(applicationType), applicationIdentifier.Value, Optional.ToList(globalPlacementRules), deploymentSpecId.Value, Optional.ToNullable(volumesCount));
        }
    }
}
