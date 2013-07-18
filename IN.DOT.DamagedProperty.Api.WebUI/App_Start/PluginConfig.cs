using System.Collections.Generic;
using IN.DOT.DamagedProperty.Api.Services.Infrastructure;
using IN.DOT.DamagedProperty.Api.Services.Security;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Validation;
using ServiceStack.WebHost.Endpoints;

namespace IN.DOT.DamagedProperty.WebUI.App_Start 
{
    public class PluginConfig
    {
        internal static void RegisterPlugins(List<IPlugin> plugins, Funq.Container container)
        {
            // Register all authentication methods that should be enabled for this API
            plugins.Add(new AuthFeature(
                () => new UserSession(),
                new[] { new CustomCredentialsAuthProvider(container.Resolve<ISecurityService>()) }
                ));

            // Enable the FluentValidation feature
            plugins.Add(new ValidationFeature());
        }
    }
}