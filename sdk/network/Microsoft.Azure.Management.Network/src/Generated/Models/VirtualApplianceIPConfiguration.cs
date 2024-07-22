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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a single IP configuration.
    /// </summary>
    public partial class VirtualApplianceIPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VirtualApplianceIPConfiguration
        /// class.
        /// </summary>
        public VirtualApplianceIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualApplianceIPConfiguration
        /// class.
        /// </summary>
        /// <param name="name">Name of the IP configuration.</param>
        public VirtualApplianceIPConfiguration(string name = default(string), VirtualApplianceIPConfigurationProperties properties = default(VirtualApplianceIPConfigurationProperties))
        {
            Name = name;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VirtualApplianceIPConfigurationProperties Properties { get; set; }

    }
}
