using System.Web.Security;

namespace SecureApp.Services
{
    public class LoginService : ILoginService
    {
        public bool Login(string usuario, string senha)
        {
            return Membership.ValidateUser(usuario, senha);
        }
    }
}
