// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class SecurityPolicyListResult
    {
        internal static SecurityPolicyListResult DeserializeSecurityPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<FrontDoorSecurityPolicyData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FrontDoorSecurityPolicyData> array = new List<FrontDoorSecurityPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FrontDoorSecurityPolicyData.DeserializeFrontDoorSecurityPolicyData(item));
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
            return new SecurityPolicyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
