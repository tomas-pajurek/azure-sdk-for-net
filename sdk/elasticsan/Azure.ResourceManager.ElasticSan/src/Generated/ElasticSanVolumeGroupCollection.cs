// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing a collection of <see cref="ElasticSanVolumeGroupResource" /> and their operations.
    /// Each <see cref="ElasticSanVolumeGroupResource" /> in the collection will belong to the same instance of <see cref="ElasticSanResource" />.
    /// To get an <see cref="ElasticSanVolumeGroupCollection" /> instance call the GetElasticSanVolumeGroups method from an instance of <see cref="ElasticSanResource" />.
    /// </summary>
    public partial class ElasticSanVolumeGroupCollection : ArmCollection, IEnumerable<ElasticSanVolumeGroupResource>, IAsyncEnumerable<ElasticSanVolumeGroupResource>
    {
        private readonly ClientDiagnostics _elasticSanVolumeGroupVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _elasticSanVolumeGroupVolumeGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupCollection"/> class for mocking. </summary>
        protected ElasticSanVolumeGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticSanVolumeGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticSanVolumeGroupVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanVolumeGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticSanVolumeGroupResource.ResourceType, out string elasticSanVolumeGroupVolumeGroupsApiVersion);
            _elasticSanVolumeGroupVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticSanVolumeGroupVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ElasticSanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ElasticSanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Volume Group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticSanVolumeGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string elasticSanVolumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.CreateAsync(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Volume Group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ElasticSanVolumeGroupResource> CreateOrUpdate(WaitUntil waitUntil, string elasticSanVolumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Create(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an VolumeGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> is null. </exception>
        public virtual async Task<Response<ElasticSanVolumeGroupResource>> GetAsync(string elasticSanVolumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an VolumeGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> is null. </exception>
        public virtual Response<ElasticSanVolumeGroupResource> Get(string elasticSanVolumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List VolumeGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups
        /// Operation Id: VolumeGroups_ListByElasticSan
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanVolumeGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanVolumeGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ElasticSanVolumeGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.ListByElasticSanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticSanVolumeGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ElasticSanVolumeGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.ListByElasticSanNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticSanVolumeGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List VolumeGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups
        /// Operation Id: VolumeGroups_ListByElasticSan
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanVolumeGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanVolumeGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ElasticSanVolumeGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticSanVolumeGroupVolumeGroupsRestClient.ListByElasticSan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticSanVolumeGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ElasticSanVolumeGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticSanVolumeGroupVolumeGroupsRestClient.ListByElasticSanNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticSanVolumeGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string elasticSanVolumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="elasticSanVolumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanVolumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanVolumeGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticSanVolumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanVolumeGroupName, nameof(elasticSanVolumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(elasticSanVolumeGroupName, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticSanVolumeGroupResource> IEnumerable<ElasticSanVolumeGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticSanVolumeGroupResource> IAsyncEnumerable<ElasticSanVolumeGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
