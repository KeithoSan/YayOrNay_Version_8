using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YayOrNay.Models;

namespace YayOrNay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

          
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Keith";
            model.Location = "Dublin, Ireland";

            return View(model);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}