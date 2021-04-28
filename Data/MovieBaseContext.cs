using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieBase.Models;

namespace MovieBase.Data
{
    public class MovieBaseContext : DbContext
    {
        public MovieBaseContext (DbContextOptions<MovieBaseContext> options)
            : base(options)
        {
        }

        public DbSet<MovieBase.Models.Movie> Movie { get; set; }
    }
}
