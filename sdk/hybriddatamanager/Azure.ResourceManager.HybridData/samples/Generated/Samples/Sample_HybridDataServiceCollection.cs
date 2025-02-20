// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridData;

namespace Azure.ResourceManager.HybridData.Samples
{
    public partial class Sample_HybridDataServiceCollection
    {
        // DataServices_ListByDataManagerGET51
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DataServicesListByDataManagerGET51()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataServices_ListByDataManager-GET-example-51.json
            // this example is just showing the usage of "DataServices_ListByDataManager" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataManagerResource created on azure
            // for more information of creating HybridDataManagerResource, please refer to the document of HybridDataManagerResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            ResourceIdentifier hybridDataManagerResourceId = HybridDataManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName);
            HybridDataManagerResource hybridDataManager = client.GetHybridDataManagerResource(hybridDataManagerResourceId);

            // get the collection of this HybridDataServiceResource
            HybridDataServiceCollection collection = hybridDataManager.GetHybridDataServices();

            // invoke the operation and iterate over the result
            await foreach (HybridDataServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridDataServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DataServices_GetGET62
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataServicesGetGET62()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataServices_Get-GET-example-62.json
            // this example is just showing the usage of "DataServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataManagerResource created on azure
            // for more information of creating HybridDataManagerResource, please refer to the document of HybridDataManagerResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            ResourceIdentifier hybridDataManagerResourceId = HybridDataManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName);
            HybridDataManagerResource hybridDataManager = client.GetHybridDataManagerResource(hybridDataManagerResourceId);

            // get the collection of this HybridDataServiceResource
            HybridDataServiceCollection collection = hybridDataManager.GetHybridDataServices();

            // invoke the operation
            string dataServiceName = "DataTransformation";
            HybridDataServiceResource result = await collection.GetAsync(dataServiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridDataServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataServices_GetGET62
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DataServicesGetGET62()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataServices_Get-GET-example-62.json
            // this example is just showing the usage of "DataServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataManagerResource created on azure
            // for more information of creating HybridDataManagerResource, please refer to the document of HybridDataManagerResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            ResourceIdentifier hybridDataManagerResourceId = HybridDataManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName);
            HybridDataManagerResource hybridDataManager = client.GetHybridDataManagerResource(hybridDataManagerResourceId);

            // get the collection of this HybridDataServiceResource
            HybridDataServiceCollection collection = hybridDataManager.GetHybridDataServices();

            // invoke the operation
            string dataServiceName = "DataTransformation";
            bool result = await collection.ExistsAsync(dataServiceName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
