using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieBase.Data;
using MovieBase.Models;

namespace MovieBase.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly MovieBase.Data.MovieBaseContext _context;

        public IndexModel(MovieBase.Data.MovieBaseContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
