using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quiz410754427.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        
        public ActionResult Count(string name, string number)
        {
            var result = " ";
            if (number == "13")
            {
                result = "下午一點";
            }
            else if (number == "14") {
                ViewBag.Result = "下午-21點";
            }

            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}