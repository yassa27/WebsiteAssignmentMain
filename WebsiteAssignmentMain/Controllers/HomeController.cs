using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsiteAssignmentMain.Models;

namespace WebsiteAssignmentMain.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            List<Movie> model = _context.Movies.ToList();
            return View(model);
        }

        public IActionResult MovieInfo(int id)

        {
            Movie model = _context.Movies.Find(id);
            return View(model);
        }
        public IActionResult MovieControl()
        {
            return View();
        }
     
        public IActionResult Search(String SearchString)

        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                var movies = from m in _context.Movies
                            where m.Movie_Name.Contains(SearchString)
                            select m;

                List<Movie> model = movies.ToList();

                ViewData["SearchString"] = SearchString;

                return View(model);

            }
            else
            {
                return View();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
