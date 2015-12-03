using System.ServiceModel;

namespace SecureApp.Services
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool Login(string usuario, string senha);
    }
}
