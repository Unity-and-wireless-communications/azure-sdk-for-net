// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnServerConfigurationPolicyGroup Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VpnServerConfigurationPolicyGroup : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VpnServerConfigurationPolicyGroup
        /// class.
        /// </summary>
        public VpnServerConfigurationPolicyGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnServerConfigurationPolicyGroup
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="isDefault">Shows if this is a Default
        /// VpnServerConfigurationPolicyGroup or not.</param>
        /// <param name="priority">Priority for
        /// VpnServerConfigurationPolicyGroup.</param>
        /// <param name="policyMembers">Multiple PolicyMembers for
        /// VpnServerConfigurationPolicyGroup.</param>
        /// <param name="p2SConnectionConfigurations">List of references to
        /// P2SConnectionConfigurations.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// VpnServerConfigurationPolicyGroup resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="type">Resource type.</param>
        public VpnServerConfigurationPolicyGroup(string id = default(string), bool? isDefault = default(bool?), int? priority = default(int?), IList<VpnServerConfigurationPolicyGroupMember> policyMembers = default(IList<VpnServerConfigurationPolicyGroupMember>), IList<SubResource> p2SConnectionConfigurations = default(IList<SubResource>), string provisioningState = default(string), string etag = default(string), string name = default(string), string type = default(string))
            : base(id)
        {
            IsDefault = isDefault;
            Priority = priority;
            PolicyMembers = policyMembers;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            Etag = etag;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows if this is a Default
        /// VpnServerConfigurationPolicyGroup or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or sets priority for VpnServerConfigurationPolicyGroup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets multiple PolicyMembers for
        /// VpnServerConfigurationPolicyGroup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyMembers")]
        public IList<VpnServerConfigurationPolicyGroupMember> PolicyMembers { get; set; }

        /// <summary>
        /// Gets list of references to P2SConnectionConfigurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2SConnectionConfigurations")]
        public IList<SubResource> P2SConnectionConfigurations { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the
        /// VpnServerConfigurationPolicyGroup resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
