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
    /// The ID of the ExpressRouteConnection.
    /// </summary>
    public partial class ExpressRouteConnectionId
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteConnectionId class.
        /// </summary>
        public ExpressRouteConnectionId()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteConnectionId class.
        /// </summary>
        /// <param name="id">The ID of the ExpressRouteConnection.</param>
        public ExpressRouteConnectionId(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the ExpressRouteConnection.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
