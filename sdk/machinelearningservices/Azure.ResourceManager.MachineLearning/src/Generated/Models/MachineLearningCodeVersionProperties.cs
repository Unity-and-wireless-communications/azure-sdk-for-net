// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Code asset version details. </summary>
    public partial class MachineLearningCodeVersionProperties : MachineLearningAssetBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeVersionProperties"/>. </summary>
        public MachineLearningCodeVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="codeUri"> Uri where code is located. </param>
        /// <param name="provisioningState"> Provisioning state for the code version. </param>
        internal MachineLearningCodeVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isAnonymous, bool? isArchived, Uri codeUri, RegistryAssetProvisioningState? provisioningState) : base(description, properties, tags, serializedAdditionalRawData, isAnonymous, isArchived)
        {
            CodeUri = codeUri;
            ProvisioningState = provisioningState;
        }

        /// <summary> Uri where code is located. </summary>
        public Uri CodeUri { get; set; }
        /// <summary> Provisioning state for the code version. </summary>
        public RegistryAssetProvisioningState? ProvisioningState { get; }
    }
}
