// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorWorkspaceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (WorkspaceResourceId != null)
            {
                writer.WritePropertyName("workspaceResourceId");
                writer.WriteStringValue(WorkspaceResourceId);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorWorkspaceSettings DeserializeConnectionMonitorWorkspaceSettings(JsonElement element)
        {
            string workspaceResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectionMonitorWorkspaceSettings(workspaceResourceId);
        }
    }
}
