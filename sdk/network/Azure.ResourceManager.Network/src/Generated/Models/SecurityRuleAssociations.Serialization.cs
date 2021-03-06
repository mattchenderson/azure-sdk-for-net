// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SecurityRuleAssociations
    {
        internal static SecurityRuleAssociations DeserializeSecurityRuleAssociations(JsonElement element)
        {
            Optional<NetworkInterfaceAssociation> networkInterfaceAssociation = default;
            Optional<SubnetAssociation> subnetAssociation = default;
            Optional<IReadOnlyList<SecurityRule>> defaultSecurityRules = default;
            Optional<IReadOnlyList<EffectiveNetworkSecurityRule>> effectiveSecurityRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceAssociation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkInterfaceAssociation = NetworkInterfaceAssociation.DeserializeNetworkInterfaceAssociation(property.Value);
                    continue;
                }
                if (property.NameEquals("subnetAssociation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subnetAssociation = SubnetAssociation.DeserializeSubnetAssociation(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultSecurityRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecurityRule> array = new List<SecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityRule.DeserializeSecurityRule(item));
                    }
                    defaultSecurityRules = array;
                    continue;
                }
                if (property.NameEquals("effectiveSecurityRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EffectiveNetworkSecurityRule> array = new List<EffectiveNetworkSecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveNetworkSecurityRule.DeserializeEffectiveNetworkSecurityRule(item));
                    }
                    effectiveSecurityRules = array;
                    continue;
                }
            }
            return new SecurityRuleAssociations(networkInterfaceAssociation.Value, subnetAssociation.Value, Optional.ToList(defaultSecurityRules), Optional.ToList(effectiveSecurityRules));
        }
    }
}
