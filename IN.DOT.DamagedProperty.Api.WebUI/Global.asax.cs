using System;
using System.Linq;
using System.Reflection;
using IN.DOT.DamagedProperty.WebUI.Infrastructure;
using WebMatrix.WebData;

namespace IN.DOT.DamagedProperty.WebUI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies()
                        .SingleOrDefault(a => a.GetName().Name == "IN.DOT.DamagedProperty.Api.ServiceInterface");

            (new PortalApiServiceHost(assembly)).Init();

            Initialize();
        }

        private static void Initialize()
        {
            // SimpleMembership configuration
            WebSecurity.InitializeDatabaseConnection("DamagedProperty.Api", "User", "Id", "Username", false);
        }

    }
}