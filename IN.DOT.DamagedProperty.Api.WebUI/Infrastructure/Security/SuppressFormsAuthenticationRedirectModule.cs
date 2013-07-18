using System;
using System.Web;

namespace IN.DOT.DamagedProperty.WebUI.Infrastructure.Security
{
    public class SuppressFormsAuthenticationRedirectModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PostReleaseRequestState += OnPostReleaseRequestState;
        }

        private void OnPostReleaseRequestState(object source, EventArgs args)
        {
            var context = (HttpApplication)source;
            var response = context.Response;
            var request = context.Request;
            //if (response.StatusCode == 401 && request.Headers["X-Requested-With"] == "XmlHttpRequest")
            if (response.StatusCode == 401)
                context.Response.SuppressFormsAuthenticationRedirect = true;
        }

        public void Dispose()
        {
        }
    }
}