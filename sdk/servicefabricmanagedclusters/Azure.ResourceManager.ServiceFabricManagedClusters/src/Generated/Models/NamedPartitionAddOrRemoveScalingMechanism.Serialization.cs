// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NamedPartitionAddOrRemoveScalingMechanism : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("minPartitionCount"u8);
            writer.WriteNumberValue(MinPartitionCount);
            writer.WritePropertyName("maxPartitionCount"u8);
            writer.WriteNumberValue(MaxPartitionCount);
            writer.WritePropertyName("scaleIncrement"u8);
            writer.WriteNumberValue(ScaleIncrement);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static NamedPartitionAddOrRemoveScalingMechanism DeserializeNamedPartitionAddOrRemoveScalingMechanism(JsonElement element)
        {
            int minPartitionCount = default;
            int maxPartitionCount = default;
            int scaleIncrement = default;
            ServiceScalingMechanismKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minPartitionCount"u8))
                {
                    minPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPartitionCount"u8))
                {
                    maxPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleIncrement"u8))
                {
                    scaleIncrement = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingMechanismKind(property.Value.GetString());
                    continue;
                }
            }
            return new NamedPartitionAddOrRemoveScalingMechanism(kind, minPartitionCount, maxPartitionCount, scaleIncrement);
        }
    }
}
