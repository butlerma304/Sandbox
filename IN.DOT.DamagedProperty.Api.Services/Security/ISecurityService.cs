namespace IN.DOT.DamagedProperty.Api.Services.Security
{
    public interface ISecurityService
    {
        bool Login(string userName, string password);
    }
}