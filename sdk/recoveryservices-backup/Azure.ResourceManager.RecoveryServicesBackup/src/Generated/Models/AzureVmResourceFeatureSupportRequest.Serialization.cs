// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureVmResourceFeatureSupportRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmSku))
            {
                writer.WritePropertyName("vmSku"u8);
                writer.WriteStringValue(VmSku);
            }
            writer.WritePropertyName("featureType"u8);
            writer.WriteStringValue(FeatureType);
            writer.WriteEndObject();
        }
    }
}
