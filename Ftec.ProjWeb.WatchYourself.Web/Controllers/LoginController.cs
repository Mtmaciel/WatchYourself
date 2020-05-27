using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjWeb.WatchYourself.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        public ActionResult RememberPassword()
        {
            return View();
        }
    }
}