namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Subscription information.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Gets or sets the ID of the resource
        /// (/subscriptions/SubscriptionId).
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the subscription Id.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the subscription display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the subscription state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

    }
}
