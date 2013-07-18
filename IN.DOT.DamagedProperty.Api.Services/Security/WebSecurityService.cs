using WebMatrix.WebData;

namespace IN.DOT.DamagedProperty.Api.Services.Security
{
    public class WebSecurityService : ISecurityService
    {
        public bool Login(string userName, string password)
        {
            //Guard.Against<ArgumentNullException>(String.IsNullOrWhiteSpace(userName), "Username cannot be null or empty.");
            //Guard.Against<ArgumentNullException>(String.IsNullOrWhiteSpace(password), "Password cannot be null or empty.");

            return WebSecurity.Login(userName, password, persistCookie: false);
        }
    }
}