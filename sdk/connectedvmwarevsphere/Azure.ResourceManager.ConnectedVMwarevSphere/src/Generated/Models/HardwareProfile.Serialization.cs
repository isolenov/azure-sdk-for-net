// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class HardwareProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MemorySizeMB))
            {
                writer.WritePropertyName("memorySizeMB"u8);
                writer.WriteNumberValue(MemorySizeMB.Value);
            }
            if (Optional.IsDefined(NumCpus))
            {
                writer.WritePropertyName("numCPUs"u8);
                writer.WriteNumberValue(NumCpus.Value);
            }
            if (Optional.IsDefined(NumCoresPerSocket))
            {
                writer.WritePropertyName("numCoresPerSocket"u8);
                writer.WriteNumberValue(NumCoresPerSocket.Value);
            }
            writer.WriteEndObject();
        }

        internal static HardwareProfile DeserializeHardwareProfile(JsonElement element)
        {
            Optional<int> memorySizeMB = default;
            Optional<int> numCpus = default;
            Optional<int> numCoresPerSocket = default;
            Optional<bool> cpuHotAddEnabled = default;
            Optional<bool> cpuHotRemoveEnabled = default;
            Optional<bool> memoryHotAddEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memorySizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memorySizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numCpus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numCoresPerSocket"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numCoresPerSocket = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuHotAddEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpuHotAddEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuHotRemoveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpuHotRemoveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("memoryHotAddEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryHotAddEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new HardwareProfile(Optional.ToNullable(memorySizeMB), Optional.ToNullable(numCpus), Optional.ToNullable(numCoresPerSocket), Optional.ToNullable(cpuHotAddEnabled), Optional.ToNullable(cpuHotRemoveEnabled), Optional.ToNullable(memoryHotAddEnabled));
        }
    }
}
