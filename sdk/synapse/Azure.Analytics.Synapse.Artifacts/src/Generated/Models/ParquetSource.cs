// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Parquet source. </summary>
    public partial class ParquetSource : CopySource
    {
        /// <summary> Initializes a new instance of ParquetSource. </summary>
        public ParquetSource()
        {
            Type = "ParquetSource";
        }

        /// <summary> Initializes a new instance of ParquetSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="storeSettings"> Parquet store settings. </param>
        internal ParquetSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreReadSettings storeSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            Type = type ?? "ParquetSource";
        }

        /// <summary> Parquet store settings. </summary>
        public StoreReadSettings StoreSettings { get; set; }
    }
}