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

        public ActionResult Index(string searchTerm = null)
        {

            //var model =
            //    from r in _db.Movies
            //    orderby r.Reviews.Average(review => review.Rating) descending
            //    select new MovieListViewModel
            //    {
            //       Id = r.Id,
            //        Title = r.Title,
            //        Genre = r.Genre,
            //        Certificate = r.Certificate,
            //        CountOfReviews = r.Reviews.Count()
            //    };

            var model =
                _db.Movies
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r => searchTerm == null || r.Title.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new MovieListViewModel
                        {
                            Id = r.Id,
                            Title = r.Title,
                            Genre = r.Genre,
                            Certificate = r.Certificate,
                            CountOfReviews = r.Reviews.Count()
                        }
                        );


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