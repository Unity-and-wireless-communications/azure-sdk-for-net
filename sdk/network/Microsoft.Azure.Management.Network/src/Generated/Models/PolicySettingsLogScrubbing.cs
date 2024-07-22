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
    /// To scrub sensitive log fields
    /// </summary>
    public partial class PolicySettingsLogScrubbing
    {
        /// <summary>
        /// Initializes a new instance of the PolicySettingsLogScrubbing class.
        /// </summary>
        public PolicySettingsLogScrubbing()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicySettingsLogScrubbing class.
        /// </summary>
        /// <param name="state">State of the log scrubbing config. Default
        /// value is Enabled. Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="scrubbingRules">The rules that are applied to the logs
        /// for scrubbing.</param>
        public PolicySettingsLogScrubbing(string state = default(string), IList<WebApplicationFirewallScrubbingRules> scrubbingRules = default(IList<WebApplicationFirewallScrubbingRules>))
        {
            State = state;
            ScrubbingRules = scrubbingRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets state of the log scrubbing config. Default value is
        /// Enabled. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the rules that are applied to the logs for scrubbing.
        /// </summary>
        [JsonProperty(PropertyName = "scrubbingRules")]
        public IList<WebApplicationFirewallScrubbingRules> ScrubbingRules { get; set; }

    }
}
