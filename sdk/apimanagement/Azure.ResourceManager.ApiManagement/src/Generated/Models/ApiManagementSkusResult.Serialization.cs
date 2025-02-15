// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiManagementSkusResult
    {
        internal static ApiManagementSkusResult DeserializeApiManagementSkusResult(JsonElement element)
        {
            IReadOnlyList<ApiManagementSku> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ApiManagementSku> array = new List<ApiManagementSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSku.DeserializeApiManagementSku(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementSkusResult(value, nextLink.Value);
        }
    }
}
