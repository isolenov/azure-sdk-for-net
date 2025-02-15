// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightDiskBillingMeters
    {
        internal static HDInsightDiskBillingMeters DeserializeHDInsightDiskBillingMeters(JsonElement element)
        {
            Optional<string> diskRpMeter = default;
            Optional<string> sku = default;
            Optional<HDInsightTier> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskRpMeter"u8))
                {
                    diskRpMeter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = new HDInsightTier(property.Value.GetString());
                    continue;
                }
            }
            return new HDInsightDiskBillingMeters(diskRpMeter.Value, sku.Value, Optional.ToNullable(tier));
        }
    }
}
