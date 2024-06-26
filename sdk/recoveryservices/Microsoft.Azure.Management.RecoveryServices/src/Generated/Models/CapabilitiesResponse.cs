// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Capabilities response for Microsoft.RecoveryServices
    /// </summary>
    public partial class CapabilitiesResponse : ResourceCapabilitiesBase
    {
        /// <summary>
        /// Initializes a new instance of the CapabilitiesResponse class.
        /// </summary>
        public CapabilitiesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapabilitiesResponse class.
        /// </summary>
        /// <param name="type">Describes the Resource type:
        /// Microsoft.RecoveryServices/Vaults</param>
        public CapabilitiesResponse(string type, CapabilitiesResponseProperties properties = default(CapabilitiesResponseProperties))
            : base(type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CapabilitiesResponseProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
