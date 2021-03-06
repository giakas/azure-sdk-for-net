// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.ObjectAnchors.Conversion.Models
{
    internal partial class Vector3 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x");
            writer.WriteNumberValue(X);
            writer.WritePropertyName("y");
            writer.WriteNumberValue(Y);
            writer.WritePropertyName("z");
            writer.WriteNumberValue(Z);
            writer.WriteEndObject();
        }

        internal static Vector3 DeserializeVector3(JsonElement element)
        {
            float x = default;
            float y = default;
            float z = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"))
                {
                    x = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("y"))
                {
                    y = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("z"))
                {
                    z = property.Value.GetSingle();
                    continue;
                }
            }
            return new Vector3(x, y, z);
        }
    }
}
