using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YayOrNay.Models;

namespace YayOrNay.Controllers
{
    public class ReviewsController : Controller
    {
        YayOrNayDb _db = new YayOrNayDb();

        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")]int movieId)
        {
            var movie = _db.Movies.Find(movieId);
            if(movie !=null)
            {
                return View(movie);
            }
            return HttpNotFound();

        }

        [HttpGet]
        public ActionResult Create (int movieId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieReview review)
        {
           if(ModelState.IsValid)
           {
               _db.Reviews.Add(review);
               _db.SaveChanges();
               return RedirectToAction("Index", new { id = review.MovieId });
           }
           return View(review);
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit (MovieReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.MovieId });
            }
            return View(review);
        }



        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }   

    }
}
