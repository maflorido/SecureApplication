using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
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
