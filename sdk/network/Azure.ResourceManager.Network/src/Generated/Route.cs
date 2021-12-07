// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a Route along with the instance operations that can be performed on it. </summary>
    public partial class Route : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RoutesRestOperations _routesRestClient;
        private readonly RouteData _data;

        /// <summary> Initializes a new instance of the <see cref="Route"/> class for mocking. </summary>
        protected Route()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Route"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Route(ArmResource options, RouteData resource) : base(options, new ResourceIdentifier(resource.Id))
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routesRestClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="Route"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Route(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routesRestClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="Route"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Route(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routesRestClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/routeTables/routes";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RouteData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Route>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Route.Get");
            scope.Start();
            try
            {
                var response = await _routesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Route> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Route.Get");
            scope.Start();
            try
            {
                var response = _routesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified route from a route table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<RouteDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Route.Delete");
            scope.Start();
            try
            {
                var response = await _routesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RouteDeleteOperation(_clientDiagnostics, Pipeline, _routesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified route from a route table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual RouteDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Route.Delete");
            scope.Start();
            try
            {
                var response = _routesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RouteDeleteOperation(_clientDiagnostics, Pipeline, _routesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
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
