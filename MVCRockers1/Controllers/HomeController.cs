using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [MyLogginFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?";

            return View();
        }

        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "special")
                return new HttpStatusCodeResult(403);

            if (format == "text")
                return Content("You Rock!");
            else if (format == "json")
                return Json(new { password = "You Rcok!", expires = DateTime.UtcNow.ToShortDateString() },
                    JsonRequestBehavior.AllowGet);
            else if (format == "clean")
                return PartialView();
            return View();
        }
    }
}