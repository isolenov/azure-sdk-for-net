// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxSkuCapacity
    {
        internal static DataBoxSkuCapacity DeserializeDataBoxSkuCapacity(JsonElement element)
        {
            Optional<string> usable = default;
            Optional<string> maximum = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usable"u8))
                {
                    usable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    maximum = property.Value.GetString();
                    continue;
                }
            }
            return new DataBoxSkuCapacity(usable.Value, maximum.Value);
        }
    }
}
