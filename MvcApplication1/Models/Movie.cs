using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Movie
    {
        public long ID { get; set; }
        public string Movie_Name { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Cast { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
    }
}