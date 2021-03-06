// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Event details for InMageRcmFailback provider.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcmFailback")]
    public partial class InMageRcmFailbackEventDetails : EventProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackEventDetails
        /// class.
        /// </summary>
        public InMageRcmFailbackEventDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackEventDetails
        /// class.
        /// </summary>
        /// <param name="protectedItemName">The protected item name.</param>
        public InMageRcmFailbackEventDetails(string protectedItemName = default(string))
        {
            ProtectedItemName = protectedItemName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the protected item name.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemName")]
        public string ProtectedItemName { get; private set; }

    }
}
