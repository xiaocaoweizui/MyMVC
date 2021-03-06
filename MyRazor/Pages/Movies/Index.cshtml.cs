using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazor.Data;
using MyRazor.Model;

namespace MyRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyRazor.Data.MovieContext _context;

        public IndexModel(MyRazor.Data.MovieContext context)
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
