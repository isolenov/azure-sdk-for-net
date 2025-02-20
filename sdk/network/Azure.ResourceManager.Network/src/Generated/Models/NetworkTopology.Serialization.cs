// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkTopology
    {
        internal static NetworkTopology DeserializeNetworkTopology(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<IReadOnlyList<TopologyResourceInfo>> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TopologyResourceInfo> array = new List<TopologyResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologyResourceInfo.DeserializeTopologyResourceInfo(item));
                    }
                    resources = array;
                    continue;
                }
            }
            return new NetworkTopology(id.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(lastModified), Optional.ToList(resources));
        }
    }
}
