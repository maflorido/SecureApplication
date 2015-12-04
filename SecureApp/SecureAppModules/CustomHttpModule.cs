using System;
using System.Web;

namespace SecureAppModules
{
    public class CustomHttpModule : IHttpModule
    {

        public CustomHttpModule()
        {

        }

        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(OnBeginRequest);
        }

        public void OnBeginRequest(Object s, EventArgs e)
        {
            HttpApplication app = s as HttpApplication;
            
        }
    }
}