// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ExecuteDataFlowActivityTypePropertiesCompute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType.Value.ToString());
            }
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExecuteDataFlowActivityTypePropertiesCompute DeserializeExecuteDataFlowActivityTypePropertiesCompute(JsonElement element)
        {
            Optional<DataFlowComputeType> computeType = default;
            Optional<int> coreCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    computeType = new DataFlowComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExecuteDataFlowActivityTypePropertiesCompute(Optional.ToNullable(computeType), Optional.ToNullable(coreCount));
        }
    }
}
