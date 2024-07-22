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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The private IP addresses/IP ranges to which traffic will not be SNAT.
    /// </summary>
    public partial class FirewallPolicySNAT
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicySNAT class.
        /// </summary>
        public FirewallPolicySNAT()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicySNAT class.
        /// </summary>
        /// <param name="privateRanges">List of private IP addresses/IP address
        /// ranges to not be SNAT.</param>
        /// <param name="autoLearnPrivateRanges">The operation mode for
        /// automatically learning private ranges to not be SNAT. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        public FirewallPolicySNAT(IList<string> privateRanges = default(IList<string>), string autoLearnPrivateRanges = default(string))
        {
            PrivateRanges = privateRanges;
            AutoLearnPrivateRanges = autoLearnPrivateRanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of private IP addresses/IP address ranges to not
        /// be SNAT.
        /// </summary>
        [JsonProperty(PropertyName = "privateRanges")]
        public IList<string> PrivateRanges { get; set; }

        /// <summary>
        /// Gets or sets the operation mode for automatically learning private
        /// ranges to not be SNAT. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "autoLearnPrivateRanges")]
        public string AutoLearnPrivateRanges { get; set; }

    }
}
