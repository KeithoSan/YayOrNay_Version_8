//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using YayOrNay.Models;

//namespace YayOrNay.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        [ChildActionOnly]
//        public ActionResult BestReview()
//        {
//            var bestReview = from r in _reviews
//                             orderby r.Rating descending
//                                 select r;

//            return PartialView("_Review", bestReview.First());
//        }


//        // GET: Reviews
//        public ActionResult Index()
//        {

//                        var model =
//                from r in _reviews
//                orderby r.ReleaseDate
//                select r;

//            return View(model);

//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);


//            return View(review);
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            if (TryUpdateModel(review))
//            {
//                //..
//                return RedirectToAction("Index");
//            }
//            return View(review);
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }


//        static List<MovieReview> _reviews = new List<MovieReview>
//                {
//                    new MovieReview
//                    {
//                        Id = 1,
//                        Title = "Batman vs Superman",
//                        Genre = "Action",
//                        Certificate = "PG-13",
//                        ReleaseDate = new DateTime (24/03/2016),
//                        Rating = 7.1,

//                    },
//                      new MovieReview
//                    {
//                        Id = 2,
//                        Title = "Deadpool",
//                        Genre = "Action",
//                        Certificate = "R",
//                        ReleaseDate = new DateTime (12/02/2016),
//                        Rating = 8.5,

//                    },
//                        new MovieReview
//                    {
//                        Id = 3,
//                        Title = "Star Wars: Episode VII - The Force Awakens",
//                        Genre = "Action",
//                        Certificate = "PG-13",
//                        ReleaseDate = new DateTime (18/12/2015),
//                        Rating = 8.4,

//                    }
//                };


//    }
//}
