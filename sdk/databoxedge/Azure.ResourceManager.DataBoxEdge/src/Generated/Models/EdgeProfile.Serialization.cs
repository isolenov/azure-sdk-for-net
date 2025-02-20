// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    internal partial class EdgeProfile
    {
        internal static EdgeProfile DeserializeEdgeProfile(JsonElement element)
        {
            Optional<EdgeProfileSubscription> subscription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscription = EdgeProfileSubscription.DeserializeEdgeProfileSubscription(property.Value);
                    continue;
                }
            }
            return new EdgeProfile(subscription.Value);
        }
    }
}
