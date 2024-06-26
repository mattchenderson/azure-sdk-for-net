// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </summary>
    public partial class ContainerRegistryEventSource
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventSource"/>. </summary>
        internal ContainerRegistryEventSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventSource"/>. </summary>
        /// <param name="addr"> The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname() along with the running port. </param>
        /// <param name="instanceID"> The running instance of an application. Changes after each restart. </param>
        internal ContainerRegistryEventSource(string addr, string instanceID)
        {
            Addr = addr;
            InstanceID = instanceID;
        }

        /// <summary> The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname() along with the running port. </summary>
        public string Addr { get; }
        /// <summary> The running instance of an application. Changes after each restart. </summary>
        public string InstanceID { get; }
    }
}
