// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class MetricDefinition
    {
        internal static MetricDefinition DeserializeMetricDefinition(JsonElement element)
        {
            Optional<MetricName> name = default;
            Optional<PrimaryAggregationType> primaryAggregationType = default;
            Optional<string> resourceUri = default;
            Optional<UnitDefinitionType> unit = default;
            Optional<IReadOnlyList<MetricAvailability>> metricAvailabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = MetricName.DeserializeMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"))
                {
                    primaryAggregationType = new PrimaryAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new UnitDefinitionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"))
                {
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item));
                    }
                    metricAvailabilities = array;
                    continue;
                }
            }
            return new MetricDefinition(name.Value, Optional.ToNullable(primaryAggregationType), resourceUri.Value, Optional.ToNullable(unit), Optional.ToList(metricAvailabilities));
        }
    }
}