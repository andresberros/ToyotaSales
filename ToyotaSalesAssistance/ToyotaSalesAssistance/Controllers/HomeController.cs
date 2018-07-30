using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ToyotaSalesAssistance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }
    }
}
