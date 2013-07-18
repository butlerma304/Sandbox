using System.Collections.Generic;
using System.Reflection;
using System.Web.Configuration;
using IN.DOT.DamagedProperty.Api.WebUI;
using IN.DOT.DamagedProperty.WebUI.App_Start;
using ServiceStack.Common.Web;
using ServiceStack.Text;
using ServiceStack.WebHost.Endpoints;

namespace IN.DOT.DamagedProperty.WebUI.Infrastructure
{
    public class PortalApiServiceHost : AppHostBase
    {

        public PortalApiServiceHost(Assembly assembly)
            : base("DamagedProperty Web Services", assembly)
        {

        }

        public override void Configure(Funq.Container container)
        {
            EndpointHostConfig config = this.Config;

            // By redefining the GlobalResponseHeaders dictionary here, we eliminate the 
            // X-Powered-By: ServiceStack header added by the default EndpointHostConfing in 
            // AppHostBase.
            config.GlobalResponseHeaders = new Dictionary<string, string>()
            {
                // To enable CORS uncomment these Access-Control headers:
                //{ "Access-Control-Allow-Origin", "*" },
                //{ "Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS" },
                //{ "Access-Control-Allow-Headers", "Content-Type" },
            };

            var section = WebConfigurationManager.GetSection("system.web/compilation") as CompilationSection;

            // Only show StackTrace if compilation debug="true"
            config.DebugMode = section == null ? false : section.Debug;
            config.DefaultContentType = ContentType.Json;

            JsConfig.EmitCamelCaseNames = true;

            RouteConfig.RegisterRoutes(this.Routes);
            ContainerConfig.ConfigureContainer(container);
            PluginConfig.RegisterPlugins(this.Plugins, container);
        }

    }
}