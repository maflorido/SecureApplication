using SecureApp.Web.LoginService;
using SecureApp.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SecureApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoginService loginService;

        public HomeController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel, string returnUrl = null)
        {            
            if (loginService.Login(viewModel.UserName, viewModel.Password))
            {
                var user = Membership.GetAllUsers();

                FormsAuthentication.SetAuthCookie(viewModel.UserName, viewModel.RememberMe);

                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect");
            }
            return View();
        }
        
    }
}