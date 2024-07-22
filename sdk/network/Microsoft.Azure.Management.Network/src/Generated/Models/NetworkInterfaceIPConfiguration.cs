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
    /// IPConfiguration in a network interface.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkInterfaceIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceIPConfiguration
        /// class.
        /// </summary>
        public NetworkInterfaceIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceIPConfiguration
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="gatewayLoadBalancer">The reference to gateway load
        /// balancer frontend IP.</param>
        /// <param name="virtualNetworkTaps">The reference to Virtual Network
        /// Taps.</param>
        /// <param name="applicationGatewayBackendAddressPools">The reference
        /// to ApplicationGatewayBackendAddressPool resource.</param>
        /// <param name="loadBalancerBackendAddressPools">The reference to
        /// LoadBalancerBackendAddressPool resource.</param>
        /// <param name="loadBalancerInboundNatRules">A list of references of
        /// LoadBalancerInboundNatRules.</param>
        /// <param name="privateIPAddress">Private IP address of the IP
        /// configuration. It can be a single IP address or a CIDR block in the
        /// format &lt;address&gt;/&lt;prefix-length&gt;.</param>
        /// <param name="privateIPAddressPrefixLength">The private IP address
        /// prefix length. If specified and the allocation method is dynamic,
        /// the service will allocate a CIDR block instead of a single IP
        /// address.</param>
        /// <param name="privateIPAllocationMethod">The private IP address
        /// allocation method. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="privateIPAddressVersion">Whether the specific IP
        /// configuration is IPv4 or IPv6. Default is IPv4. Possible values
        /// include: 'IPv4', 'IPv6'</param>
        /// <param name="subnet">Subnet bound to the IP configuration.</param>
        /// <param name="primary">Whether this is a primary customer address on
        /// the network interface.</param>
        /// <param name="publicIPAddress">Public IP address bound to the IP
        /// configuration.</param>
        /// <param name="applicationSecurityGroups">Application security groups
        /// in which the IP configuration is included.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// network interface IP configuration. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="privateLinkConnectionProperties">PrivateLinkConnection
        /// properties for the network interface.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Resource type.</param>
        public NetworkInterfaceIPConfiguration(string id = default(string), SubResource gatewayLoadBalancer = default(SubResource), IList<VirtualNetworkTap> virtualNetworkTaps = default(IList<VirtualNetworkTap>), IList<ApplicationGatewayBackendAddressPool> applicationGatewayBackendAddressPools = default(IList<ApplicationGatewayBackendAddressPool>), IList<BackendAddressPool> loadBalancerBackendAddressPools = default(IList<BackendAddressPool>), IList<InboundNatRule> loadBalancerInboundNatRules = default(IList<InboundNatRule>), string privateIPAddress = default(string), int? privateIPAddressPrefixLength = default(int?), string privateIPAllocationMethod = default(string), string privateIPAddressVersion = default(string), Subnet subnet = default(Subnet), bool? primary = default(bool?), PublicIPAddress publicIPAddress = default(PublicIPAddress), IList<ApplicationSecurityGroup> applicationSecurityGroups = default(IList<ApplicationSecurityGroup>), string provisioningState = default(string), NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties privateLinkConnectionProperties = default(NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            GatewayLoadBalancer = gatewayLoadBalancer;
            VirtualNetworkTaps = virtualNetworkTaps;
            ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAddressPrefixLength = privateIPAddressPrefixLength;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateIPAddressVersion = privateIPAddressVersion;
            Subnet = subnet;
            Primary = primary;
            PublicIPAddress = publicIPAddress;
            ApplicationSecurityGroups = applicationSecurityGroups;
            ProvisioningState = provisioningState;
            PrivateLinkConnectionProperties = privateLinkConnectionProperties;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference to gateway load balancer frontend IP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayLoadBalancer")]
        public SubResource GatewayLoadBalancer { get; set; }

        /// <summary>
        /// Gets or sets the reference to Virtual Network Taps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkTaps")]
        public IList<VirtualNetworkTap> VirtualNetworkTaps { get; set; }

        /// <summary>
        /// Gets or sets the reference to ApplicationGatewayBackendAddressPool
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationGatewayBackendAddressPools")]
        public IList<ApplicationGatewayBackendAddressPool> ApplicationGatewayBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets the reference to LoadBalancerBackendAddressPool
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerBackendAddressPools")]
        public IList<BackendAddressPool> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets a list of references of LoadBalancerInboundNatRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerInboundNatRules")]
        public IList<InboundNatRule> LoadBalancerInboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets private IP address of the IP configuration. It can be
        /// a single IP address or a CIDR block in the format
        /// &amp;lt;address&amp;gt;/&amp;lt;prefix-length&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the private IP address prefix length. If specified and
        /// the allocation method is dynamic, the service will allocate a CIDR
        /// block instead of a single IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddressPrefixLength")]
        public int? PrivateIPAddressPrefixLength { get; set; }

        /// <summary>
        /// Gets or sets the private IP address allocation method. Possible
        /// values include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets whether the specific IP configuration is IPv4 or IPv6.
        /// Default is IPv4. Possible values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddressVersion")]
        public string PrivateIPAddressVersion { get; set; }

        /// <summary>
        /// Gets or sets subnet bound to the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Gets or sets whether this is a primary customer address on the
        /// network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets public IP address bound to the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public PublicIPAddress PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets application security groups in which the IP
        /// configuration is included.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationSecurityGroups")]
        public IList<ApplicationSecurityGroup> ApplicationSecurityGroups { get; set; }

        /// <summary>
        /// Gets the provisioning state of the network interface IP
        /// configuration. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets privateLinkConnection properties for the network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkConnectionProperties")]
        public NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties PrivateLinkConnectionProperties { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkTaps != null)
            {
                foreach (var element in VirtualNetworkTaps)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LoadBalancerInboundNatRules != null)
            {
                foreach (var element1 in LoadBalancerInboundNatRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (PrivateIPAddressPrefixLength > 128)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PrivateIPAddressPrefixLength", 128);
            }
            if (PrivateIPAddressPrefixLength < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PrivateIPAddressPrefixLength", 1);
            }
        }
    }
}
