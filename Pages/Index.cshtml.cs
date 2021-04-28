using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MovieBase.Data;
using MovieBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieBaseContext _context;

        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public List<string> Categorys { get; set; } = new List<string>();
        public IndexModel(ILogger<IndexModel> logger, MovieBaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Movie> AllMovies { get; set; }
        public void OnGet()
        {
            AllMovies = _context.Movie.AsEnumerable();

            var categorys = AllMovies.Select(m => m.Category).ToList();
            foreach (var category in categorys)
            {
                if(!Categorys.Contains(category))
                {
                    Categorys.Add(category);
                }
            }
        }
    }
}
