using ServiceStack.ServiceHost;

namespace IN.DOT.DamagedProperty.WebUI.App_Start 
{
    public class RouteConfig
    {
        internal static void RegisterRoutes(IServiceRoutes routes)
        {
            // Widgets
            routes
                .Add<AllWidgets>("/widgets", "GET");
        }
    }
}