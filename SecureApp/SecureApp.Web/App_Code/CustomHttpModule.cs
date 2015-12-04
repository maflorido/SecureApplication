using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecureApp.Web
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
            app.Context.Response.Write("Hello from OnBeginRequest in custom module.<br>");            
        }
    }
}