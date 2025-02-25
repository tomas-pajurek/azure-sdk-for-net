// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NextHopResult
    {
        internal static NextHopResult DeserializeNextHopResult(JsonElement element)
        {
            Optional<NextHopType> nextHopType = default;
            Optional<string> nextHopIpAddress = default;
            Optional<ResourceIdentifier> routeTableId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextHopType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextHopType = new NextHopType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"))
                {
                    nextHopIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeTableId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routeTableId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new NextHopResult(Optional.ToNullable(nextHopType), nextHopIpAddress.Value, routeTableId.Value);
        }
    }
}
