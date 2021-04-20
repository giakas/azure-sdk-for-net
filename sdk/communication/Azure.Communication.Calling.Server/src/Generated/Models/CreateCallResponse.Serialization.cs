// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Calling.Server
{
    public partial class CreateCallResponse
    {
        internal static CreateCallResponse DeserializeCreateCallResponse(JsonElement element)
        {
            Optional<string> callLegId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callLegId"))
                {
                    callLegId = property.Value.GetString();
                    continue;
                }
            }
            return new CreateCallResponse(callLegId.Value);
        }
    }
}
