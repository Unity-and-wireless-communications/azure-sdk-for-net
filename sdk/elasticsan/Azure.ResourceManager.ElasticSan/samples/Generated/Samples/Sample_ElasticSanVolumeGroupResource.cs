// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanVolumeGroupResource
    {
        // VolumeGroups_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeGroupsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "EA5CE6C4-C52A-4278-9B03-D6086F11EA44";
            string resourceGroupName = "rgelasticsan";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // invoke the operation
            ElasticSanVolumeGroupPatch patch = new ElasticSanVolumeGroupPatch()
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key5273")] = new UserAssignedIdentity(),
},
                },
                ProtocolType = ElasticSanStorageTargetType.Iscsi,
                Encryption = ElasticSanEncryptionType.EncryptionAtRestWithPlatformKey,
                EncryptionProperties = new ElasticSanEncryptionProperties()
                {
                    KeyVaultProperties = new ElasticSanKeyVaultProperties()
                    {
                        KeyName = "txynilylcslnsvlddbomkxu",
                        KeyVersion = "ojha",
                        KeyVaultUri = new Uri("https://microsoft.com/a"),
                    },
                    EncryptionUserAssignedIdentity = new ResourceIdentifier("emqnmac"),
                },
                VirtualNetworkRules =
{
new ElasticSanVirtualNetworkRule(new ResourceIdentifier("bapwkbnzpahwjsgf"))
{
Action = ElasticSanVirtualNetworkRuleAction.Allow,
}
},
                EnforceDataIntegrityCheckForIscsi = true,
            };
            ArmOperation<ElasticSanVolumeGroupResource> lro = await elasticSanVolumeGroup.UpdateAsync(WaitUntil.Completed, patch);
            ElasticSanVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VolumeGroupsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "EA5CE6C4-C52A-4278-9B03-D6086F11EA44";
            string resourceGroupName = "rgelasticsan";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // invoke the operation
            await elasticSanVolumeGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VolumeGroups_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanVolumeGroupResource created on azure
            // for more information of creating ElasticSanVolumeGroupResource, please refer to the document of ElasticSanVolumeGroupResource
            string subscriptionId = "EA5CE6C4-C52A-4278-9B03-D6086F11EA44";
            string resourceGroupName = "rgelasticsan";
            string elasticSanName = "elasticsanname";
            string volumeGroupName = "volumegroupname";
            ResourceIdentifier elasticSanVolumeGroupResourceId = ElasticSanVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            ElasticSanVolumeGroupResource elasticSanVolumeGroup = client.GetElasticSanVolumeGroupResource(elasticSanVolumeGroupResourceId);

            // invoke the operation
            ElasticSanVolumeGroupResource result = await elasticSanVolumeGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
