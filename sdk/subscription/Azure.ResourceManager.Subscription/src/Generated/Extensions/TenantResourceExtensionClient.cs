// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _subscriptionClientDiagnostics;
        private SubscriptionRestOperations _subscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SubscriptionClientDiagnostics => _subscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Subscription", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SubscriptionRestOperations SubscriptionRestClient => _subscriptionRestClient ??= new SubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SubscriptionAliasResources in the TenantResource. </summary>
        /// <returns> An object representing collection of SubscriptionAliasResources and their operations over a SubscriptionAliasResource. </returns>
        public virtual SubscriptionAliasCollection GetSubscriptionAliases()
        {
            return GetCachedClient(Client => new SubscriptionAliasCollection(Client, Id));
        }

        /// <summary> Gets an object representing a TenantPolicyResource along with the instance operations that can be performed on it in the TenantResource. </summary>
        /// <returns> Returns a <see cref="TenantPolicyResource" /> object. </returns>
        public virtual TenantPolicyResource GetTenantPolicy()
        {
            return new TenantPolicyResource(Client, new ResourceIdentifier(Id.ToString() + "/providers/Microsoft.Subscription/policies/default"));
        }

        /// <summary> Gets a collection of BillingAccountPolicyResources in the TenantResource. </summary>
        /// <returns> An object representing collection of BillingAccountPolicyResources and their operations over a BillingAccountPolicyResource. </returns>
        public virtual BillingAccountPolicyCollection GetBillingAccountPolicies()
        {
            return GetCachedClient(Client => new BillingAccountPolicyCollection(Client, Id));
        }

        /// <summary>
        /// Accept subscription ownership.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnership</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnership</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="content"> The AcceptOwnershipContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> AcceptSubscriptionOwnershipAsync(WaitUntil waitUntil, string subscriptionId, AcceptOwnershipContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SubscriptionClientDiagnostics.CreateScope("TenantResourceExtensionClient.AcceptSubscriptionOwnership");
            scope.Start();
            try
            {
                var response = await SubscriptionRestClient.AcceptOwnershipAsync(subscriptionId, content, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionArmOperation(SubscriptionClientDiagnostics, Pipeline, SubscriptionRestClient.CreateAcceptOwnershipRequest(subscriptionId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Accept subscription ownership.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnership</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnership</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="content"> The AcceptOwnershipContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation AcceptSubscriptionOwnership(WaitUntil waitUntil, string subscriptionId, AcceptOwnershipContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SubscriptionClientDiagnostics.CreateScope("TenantResourceExtensionClient.AcceptSubscriptionOwnership");
            scope.Start();
            try
            {
                var response = SubscriptionRestClient.AcceptOwnership(subscriptionId, content, cancellationToken);
                var operation = new SubscriptionArmOperation(SubscriptionClientDiagnostics, Pipeline, SubscriptionRestClient.CreateAcceptOwnershipRequest(subscriptionId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Accept subscription ownership status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnershipStatus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnershipStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AcceptOwnershipStatus>> GetAcceptOwnershipStatusAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            using var scope = SubscriptionClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetAcceptOwnershipStatus");
            scope.Start();
            try
            {
                var response = await SubscriptionRestClient.AcceptOwnershipStatusAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Accept subscription ownership status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnershipStatus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnershipStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AcceptOwnershipStatus> GetAcceptOwnershipStatus(string subscriptionId, CancellationToken cancellationToken = default)
        {
            using var scope = SubscriptionClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetAcceptOwnershipStatus");
            scope.Start();
            try
            {
                var response = SubscriptionRestClient.AcceptOwnershipStatus(subscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
