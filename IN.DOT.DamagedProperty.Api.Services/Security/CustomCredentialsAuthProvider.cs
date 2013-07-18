using IN.DOT.DamagedProperty.Api.Services.Infrastructure;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Auth;

namespace IN.DOT.DamagedProperty.Api.Services.Security
{
    public class CustomCredentialsAuthProvider : CredentialsAuthProvider
    {
        private readonly ISecurityService _securityService;

        public CustomCredentialsAuthProvider(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        public override bool TryAuthenticate(IServiceBase authService, string username, string password)
        {
            bool isAuthenticated = _securityService.Login(username, password);

            if (isAuthenticated)
            {
                var session = (UserSession)authService.GetSession(false);
                session.Email = "indygray25@gmail.com";
                session.IsAuthenticated = true;
            }

            return isAuthenticated;
        }
    }
}