// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The performance level capability. </summary>
    public partial class PerformanceLevelCapability
    {
        /// <summary> Initializes a new instance of PerformanceLevelCapability. </summary>
        internal PerformanceLevelCapability()
        {
        }

        /// <summary> Initializes a new instance of PerformanceLevelCapability. </summary>
        /// <param name="value"> Performance level value. </param>
        /// <param name="unit"> Unit type used to measure performance level. </param>
        internal PerformanceLevelCapability(double? value, PerformanceLevelUnit? unit)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Performance level value. </summary>
        public double? Value { get; }
        /// <summary> Unit type used to measure performance level. </summary>
        public PerformanceLevelUnit? Unit { get; }
    }
}