// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Referenced dependency. </summary>
    public partial class DependencyReference
    {
        /// <summary> Initializes a new instance of DependencyReference. </summary>
        public DependencyReference()
        {
        }

        /// <summary> Initializes a new instance of DependencyReference. </summary>
        /// <param name="type"> The type of dependency reference. </param>
        internal DependencyReference(string type)
        {
            Type = type;
        }

        /// <summary> The type of dependency reference. </summary>
        internal string Type { get; set; }
    }
}
