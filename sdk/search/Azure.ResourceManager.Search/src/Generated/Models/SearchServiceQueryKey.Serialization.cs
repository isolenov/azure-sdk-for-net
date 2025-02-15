// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchServiceQueryKey
    {
        internal static SearchServiceQueryKey DeserializeSearchServiceQueryKey(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> key = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
            }
            return new SearchServiceQueryKey(name.Value, key.Value);
        }
    }
}
