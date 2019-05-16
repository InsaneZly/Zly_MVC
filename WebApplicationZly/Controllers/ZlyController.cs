using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationZly.Controllers
{
    public class ZlyController : Controller
    {
        // GET: Zly
        public ActionResult Index()
        {
            ViewBag.a1 = "Razor";
            return View();
        }
    }
}