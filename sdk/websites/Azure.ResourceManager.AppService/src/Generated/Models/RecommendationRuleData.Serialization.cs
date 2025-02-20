// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class RecommendationRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RecommendationName))
            {
                writer.WritePropertyName("recommendationName"u8);
                writer.WriteStringValue(RecommendationName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(RecommendationId))
            {
                writer.WritePropertyName("recommendationId"u8);
                writer.WriteStringValue(RecommendationId.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName"u8);
                writer.WriteStringValue(ActionName);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteStringValue(Channels.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (Optional.IsDefined(ExtensionName))
            {
                writer.WritePropertyName("extensionName"u8);
                writer.WriteStringValue(ExtensionName);
            }
            if (Optional.IsDefined(BladeName))
            {
                writer.WritePropertyName("bladeName"u8);
                writer.WriteStringValue(BladeName);
            }
            if (Optional.IsDefined(ForwardLink))
            {
                writer.WritePropertyName("forwardLink"u8);
                writer.WriteStringValue(ForwardLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecommendationRuleData DeserializeRecommendationRuleData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> recommendationName = default;
            Optional<string> displayName = default;
            Optional<string> message = default;
            Optional<Guid> recommendationId = default;
            Optional<string> description = default;
            Optional<string> actionName = default;
            Optional<NotificationLevel> level = default;
            Optional<RecommendationChannel> channels = default;
            Optional<IReadOnlyList<string>> categoryTags = default;
            Optional<bool> isDynamic = default;
            Optional<string> extensionName = default;
            Optional<string> bladeName = default;
            Optional<string> forwardLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recommendationName"u8))
                        {
                            recommendationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            recommendationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actionName"u8))
                        {
                            actionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("level"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            level = property0.Value.GetString().ToNotificationLevel();
                            continue;
                        }
                        if (property0.NameEquals("channels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            channels = property0.Value.GetString().ToRecommendationChannel();
                            continue;
                        }
                        if (property0.NameEquals("categoryTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            categoryTags = array;
                            continue;
                        }
                        if (property0.NameEquals("isDynamic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDynamic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("extensionName"u8))
                        {
                            extensionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bladeName"u8))
                        {
                            bladeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardLink"u8))
                        {
                            forwardLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecommendationRuleData(id, name, type, systemData.Value, recommendationName.Value, displayName.Value, message.Value, Optional.ToNullable(recommendationId), description.Value, actionName.Value, Optional.ToNullable(level), Optional.ToNullable(channels), Optional.ToList(categoryTags), Optional.ToNullable(isDynamic), extensionName.Value, bladeName.Value, forwardLink.Value, kind.Value);
        }
    }
}
