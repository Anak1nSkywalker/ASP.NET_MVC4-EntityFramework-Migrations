using LayoutsMultiplos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsMultiplos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var temaSite = Tema.TemaAtual();
            ViewBag.temaSite = temaSite;
            return View("~/Views/Tema/"+temaSite+"/Home/Index.cshtml");
        }
	}
}