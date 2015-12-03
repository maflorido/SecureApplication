using Autofac;
using Autofac.Integration.Mvc;
using SecureApp.Web.LoginService;
using System.Web.Mvc;

namespace SecureApp.Web
{
    public class DependencyResolverConfig
    {

        public static void Config()
        {
            var builder = new ContainerBuilder();

            var assembly = typeof(DependencyResolverConfig).Assembly;

            builder.RegisterControllers(assembly);
            builder.RegisterType<LoginServiceClient>().As<ILoginService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }                
    }
}