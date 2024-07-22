// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualHubRouteTableV2Collection
    {
        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubRouteTableV2Get.json
            // this example is just showing the usage of "VirtualHubRouteTableV2s_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this VirtualHubRouteTableV2Resource
            VirtualHubRouteTableV2Collection collection = virtualHub.GetVirtualHubRouteTableV2s();

            // invoke the operation
            string routeTableName = "virtualHubRouteTable1a";
            VirtualHubRouteTableV2Resource result = await collection.GetAsync(routeTableName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualHubRouteTableV2Data resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubRouteTableV2Get.json
            // this example is just showing the usage of "VirtualHubRouteTableV2s_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this VirtualHubRouteTableV2Resource
            VirtualHubRouteTableV2Collection collection = virtualHub.GetVirtualHubRouteTableV2s();

            // invoke the operation
            string routeTableName = "virtualHubRouteTable1a";
            bool result = await collection.ExistsAsync(routeTableName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubRouteTableV2Get.json
            // this example is just showing the usage of "VirtualHubRouteTableV2s_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this VirtualHubRouteTableV2Resource
            VirtualHubRouteTableV2Collection collection = virtualHub.GetVirtualHubRouteTableV2s();

            // invoke the operation
            string routeTableName = "virtualHubRouteTable1a";
            NullableResponse<VirtualHubRouteTableV2Resource> response = await collection.GetIfExistsAsync(routeTableName);
            VirtualHubRouteTableV2Resource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualHubRouteTableV2Data resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VirtualHubRouteTableV2Put
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualHubRouteTableV2Put()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubRouteTableV2Put.json
            // this example is just showing the usage of "VirtualHubRouteTableV2s_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this VirtualHubRouteTableV2Resource
            VirtualHubRouteTableV2Collection collection = virtualHub.GetVirtualHubRouteTableV2s();

            // invoke the operation
            string routeTableName = "virtualHubRouteTable1a";
            VirtualHubRouteTableV2Data data = new VirtualHubRouteTableV2Data()
            {
                Routes =
{
new VirtualHubRouteV2()
{
DestinationType = "CIDR",
Destinations =
{
"20.10.0.0/16","20.20.0.0/16"
},
NextHopType = "IPAddress",
NextHops =
{
"10.0.0.68"
},
},new VirtualHubRouteV2()
{
DestinationType = "CIDR",
Destinations =
{
"0.0.0.0/0"
},
NextHopType = "IPAddress",
NextHops =
{
"10.0.0.68"
},
}
},
                AttachedConnections =
{
"All_Vnets"
},
            };
            ArmOperation<VirtualHubRouteTableV2Resource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, routeTableName, data);
            VirtualHubRouteTableV2Resource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualHubRouteTableV2Data resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubRouteTableV2List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualHubRouteTableV2List()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubRouteTableV2List.json
            // this example is just showing the usage of "VirtualHubRouteTableV2s_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this VirtualHubRouteTableV2Resource
            VirtualHubRouteTableV2Collection collection = virtualHub.GetVirtualHubRouteTableV2s();

            // invoke the operation and iterate over the result
            await foreach (VirtualHubRouteTableV2Resource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualHubRouteTableV2Data resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
