﻿using Owin;
using System.Web.Http;

namespace OWinSelfHostedService
{
    public class WebAppStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();
            //TODO: Uncomment if you want to support CORS (Cross-origin Resource Sharing)
            //config.EnableCors();

            appBuilder.UseWebApi(config);
            config.EnsureInitialized();
        }
    }
}
