using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using DmgPropertyService.Api;
using DmgPropertyService.Data;
using DmgPropertyService.Domain;
using DmgPropertyService.Service;
using DmgPropertyService.Web.Mapping;

namespace DmgPropertyService.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // AutoMapper Registration
            AutoMapperWebConfiguration.Configure();
            AutoMapperDataConfiguration.Configure();
            AutoMapperServiceConfiguration.Configure();
            AutoMapperDomainConfiguration.Configure();
            AutoMapperApiConfiguration.Configure();
        }
    }
}