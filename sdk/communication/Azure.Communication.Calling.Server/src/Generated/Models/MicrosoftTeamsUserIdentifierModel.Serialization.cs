// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication
{
    internal partial class MicrosoftTeamsUserIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("userId");
            writer.WriteStringValue(UserId);
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous");
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud");
                writer.WriteStringValue(Cloud.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
