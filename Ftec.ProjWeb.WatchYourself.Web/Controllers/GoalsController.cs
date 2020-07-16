using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjWeb.WatchYourself.Web.Controllers
{
    public class GoalsController : Controller
    {
        // GET: Goals
        public ActionResult Index()
        {
            //request para o service buscar os goals
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Alterar()
        {
            return View();
        }

        public ActionResult Excluir()
        {
            return Json();
        }
    }
}