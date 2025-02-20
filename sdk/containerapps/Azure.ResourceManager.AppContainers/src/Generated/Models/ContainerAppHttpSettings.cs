// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp Service Authentication/Authorization. </summary>
    public partial class ContainerAppHttpSettings
    {
        /// <summary> Initializes a new instance of ContainerAppHttpSettings. </summary>
        public ContainerAppHttpSettings()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppHttpSettings. </summary>
        /// <param name="requireHttps"> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="routes"> The configuration settings of the paths HTTP requests. </param>
        /// <param name="forwardProxy"> The configuration settings of a forward proxy used to make the requests. </param>
        internal ContainerAppHttpSettings(bool? requireHttps, HttpSettingsRoutes routes, ContainerAppForwardProxy forwardProxy)
        {
            RequireHttps = requireHttps;
            Routes = routes;
            ForwardProxy = forwardProxy;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? RequireHttps { get; set; }
        /// <summary> The configuration settings of the paths HTTP requests. </summary>
        internal HttpSettingsRoutes Routes { get; set; }
        /// <summary> The prefix that should precede all the authentication/authorization paths. </summary>
        public string RoutesApiPrefix
        {
            get => Routes is null ? default : Routes.ApiPrefix;
            set
            {
                if (Routes is null)
                    Routes = new HttpSettingsRoutes();
                Routes.ApiPrefix = value;
            }
        }

        /// <summary> The configuration settings of a forward proxy used to make the requests. </summary>
        public ContainerAppForwardProxy ForwardProxy { get; set; }
    }
}
