using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DatabaseContext
{
    public class MovieDbContext: System.Data.Entity.DbContext
        {
        public MovieDbContext():base("DefaultConnection")
        {
        }
        public System.Data.Entity.DbSet<MvcApplication1.Models.Movie>Movies{get;set;}

    }
}
