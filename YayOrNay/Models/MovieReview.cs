using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YayOrNay.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
  
        public double Rating { get; set; }
        public string Comment { get; set; }
        public int MovieId { get; set; }
    }
}