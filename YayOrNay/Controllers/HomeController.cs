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
        YayOrNayDb _db = new YayOrNayDb();

        public ActionResult Index()
        {

            var model = _db.Movies.ToList();

            return View(model);
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

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}