// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DynaTrace
{
    /// <summary>
    /// A Class representing a DynatraceSingleSignOnResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DynatraceSingleSignOnResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDynatraceSingleSignOnResource method.
    /// Otherwise you can get one from its parent resource <see cref="MonitorResource" /> using the GetDynatraceSingleSignOnResource method.
    /// </summary>
    public partial class DynatraceSingleSignOnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DynatraceSingleSignOnResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string monitorName, string configurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics;
        private readonly SingleSignOnRestOperations _dynatraceSingleSignOnResourceSingleSignOnRestClient;
        private readonly DynatraceSingleSignOnResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnResource"/> class for mocking. </summary>
        protected DynatraceSingleSignOnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DynatraceSingleSignOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DynatraceSingleSignOnResource(ArmClient client, DynatraceSingleSignOnResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DynatraceSingleSignOnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DynaTrace", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dynatraceSingleSignOnResourceSingleSignOnApiVersion);
            _dynatraceSingleSignOnResourceSingleSignOnRestClient = new SingleSignOnRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dynatraceSingleSignOnResourceSingleSignOnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Dynatrace.Observability/monitors/singleSignOnConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DynatraceSingleSignOnResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a DynatraceSingleSignOnResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}
        /// Operation Id: SingleSignOn_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DynatraceSingleSignOnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Get");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnResourceSingleSignOnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DynatraceSingleSignOnResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}
        /// Operation Id: SingleSignOn_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DynatraceSingleSignOnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Get");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnResourceSingleSignOnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a DynatraceSingleSignOnResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}
        /// Operation Id: SingleSignOn_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DynatraceSingleSignOnResource>> UpdateAsync(WaitUntil waitUntil, DynatraceSingleSignOnResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Update");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnResourceSingleSignOnRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynaTraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnResourceOperationSource(Client), _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnResourceSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DynatraceSingleSignOnResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}
        /// Operation Id: SingleSignOn_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DynatraceSingleSignOnResource> Update(WaitUntil waitUntil, DynatraceSingleSignOnResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Update");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnResourceSingleSignOnRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DynaTraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnResourceOperationSource(Client), _dynatraceSingleSignOnResourceSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnResourceSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
