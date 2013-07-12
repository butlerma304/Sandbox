using System.Web;
using System.Web.Mvc;

namespace IN.DOT.DamagedProperty.Api.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}