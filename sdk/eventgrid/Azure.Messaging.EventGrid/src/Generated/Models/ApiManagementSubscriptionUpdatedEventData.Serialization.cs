// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementSubscriptionUpdatedEventDataConverter))]
    public partial class ApiManagementSubscriptionUpdatedEventData
    {
        internal static ApiManagementSubscriptionUpdatedEventData DeserializeApiManagementSubscriptionUpdatedEventData(JsonElement element)
        {
            Optional<string> resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementSubscriptionUpdatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementSubscriptionUpdatedEventDataConverter : JsonConverter<ApiManagementSubscriptionUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementSubscriptionUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementSubscriptionUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementSubscriptionUpdatedEventData(document.RootElement);
            }
        }
    }
}
