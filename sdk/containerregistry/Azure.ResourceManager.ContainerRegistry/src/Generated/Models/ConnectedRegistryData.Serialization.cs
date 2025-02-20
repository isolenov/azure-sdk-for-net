// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ConnectedRegistryData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent"u8);
                writer.WriteObjectValue(Parent);
            }
            if (Optional.IsCollectionDefined(ClientTokenIds))
            {
                writer.WritePropertyName("clientTokenIds"u8);
                writer.WriteStartArray();
                foreach (var item in ClientTokenIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LoginServer))
            {
                writer.WritePropertyName("loginServer"u8);
                writer.WriteObjectValue(LoginServer);
            }
            if (Optional.IsDefined(Logging))
            {
                writer.WritePropertyName("logging"u8);
                writer.WriteObjectValue(Logging);
            }
            if (Optional.IsCollectionDefined(NotificationsList))
            {
                writer.WritePropertyName("notificationsList"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationsList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConnectedRegistryData DeserializeConnectedRegistryData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ContainerRegistryProvisioningState> provisioningState = default;
            Optional<ConnectedRegistryMode> mode = default;
            Optional<string> version = default;
            Optional<ConnectedRegistryConnectionState> connectionState = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<ConnectedRegistryActivation> activation = default;
            Optional<ConnectedRegistryParent> parent = default;
            Optional<IList<ResourceIdentifier>> clientTokenIds = default;
            Optional<ConnectedRegistryLoginServer> loginServer = default;
            Optional<ConnectedRegistryLogging> logging = default;
            Optional<IReadOnlyList<ConnectedRegistryStatusDetail>> statusDetails = default;
            Optional<IList<string>> notificationsList = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ContainerRegistryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mode = new ConnectedRegistryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionState = new ConnectedRegistryConnectionState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastActivityTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastActivityTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("activation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            activation = ConnectedRegistryActivation.DeserializeConnectedRegistryActivation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            parent = ConnectedRegistryParent.DeserializeConnectedRegistryParent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientTokenIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ResourceIdentifier(item.GetString()));
                            }
                            clientTokenIds = array;
                            continue;
                        }
                        if (property0.NameEquals("loginServer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            loginServer = ConnectedRegistryLoginServer.DeserializeConnectedRegistryLoginServer(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logging = ConnectedRegistryLogging.DeserializeConnectedRegistryLogging(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConnectedRegistryStatusDetail> array = new List<ConnectedRegistryStatusDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedRegistryStatusDetail.DeserializeConnectedRegistryStatusDetail(item));
                            }
                            statusDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("notificationsList"u8))
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
                            notificationsList = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectedRegistryData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(mode), version.Value, Optional.ToNullable(connectionState), Optional.ToNullable(lastActivityTime), activation.Value, parent.Value, Optional.ToList(clientTokenIds), loginServer.Value, logging.Value, Optional.ToList(statusDetails), Optional.ToList(notificationsList));
        }
    }
}
