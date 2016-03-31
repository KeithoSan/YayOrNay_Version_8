using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YayOrNay.Models
{
    public class MovieListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Certificate { get; set; }
        public int CountOfReviews { get; set; }
    }
}