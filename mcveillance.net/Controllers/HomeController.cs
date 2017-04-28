using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mcveillance.net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About Jason";

            return View();
        }
        public ActionResult Camera()
        {
            ViewBag.Message = "Under Contruction";

            return View();
        }
        public ActionResult Courses()
        {
            ViewBag.Message = "Under Contruction";

            return View();
        }
        public ActionResult Robosoccer()
        {
            ViewBag.Message = "RoboSoccer information";

            return View();
        }
        public ActionResult Macabre()
        {
            ViewBag.Message = "Video Game";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me?";

            return View();
        }
    }
}