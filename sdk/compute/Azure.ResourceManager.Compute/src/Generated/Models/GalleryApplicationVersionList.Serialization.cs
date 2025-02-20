// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class GalleryApplicationVersionList
    {
        internal static GalleryApplicationVersionList DeserializeGalleryApplicationVersionList(JsonElement element)
        {
            IReadOnlyList<GalleryApplicationVersionData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<GalleryApplicationVersionData> array = new List<GalleryApplicationVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryApplicationVersionData.DeserializeGalleryApplicationVersionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryApplicationVersionList(value, nextLink.Value);
        }
    }
}
