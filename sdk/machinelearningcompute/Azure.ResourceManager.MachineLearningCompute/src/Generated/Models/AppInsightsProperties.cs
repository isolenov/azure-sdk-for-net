// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Properties of App Insights. </summary>
    internal partial class AppInsightsProperties
    {
        /// <summary> Initializes a new instance of AppInsightsProperties. </summary>
        public AppInsightsProperties()
        {
        }

        /// <summary> Initializes a new instance of AppInsightsProperties. </summary>
        /// <param name="resourceId"> ARM resource ID of the App Insights. </param>
        internal AppInsightsProperties(string resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary> ARM resource ID of the App Insights. </summary>
        public string ResourceId { get; set; }
    }
}
