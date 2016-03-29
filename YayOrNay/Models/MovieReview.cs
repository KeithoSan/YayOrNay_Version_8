using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YayOrNay.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Certificate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
    }
}