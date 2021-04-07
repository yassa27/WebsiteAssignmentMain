using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsiteAssignmentMain.Models;

namespace WebsiteAssignmentMain.Controllers
{
    public class MDataController : Controller
    {
        private readonly ILogger<MDataController> _logger;
        private readonly ApplicationDbContext _context;

        public MDataController(ILogger<MDataController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Movie> model = _context.Movies.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieForm model)
        {
            Movie newMovie = new Movie
            {
                Movie_Name = model.Movie_Name,
                Movie_Genre = model.Movie_Genre,
                Movie_Year = model.Movie_Year,
                Movie_Time = model.Movie_Time,
                Movie_Imdb = model.Movie_Imdb,
                Movie_Votes = model.Movie_Votes,
                Movie_Gross = model.Movie_Gross,
            };
            _context.Add(newMovie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

            return View();
        }
    }
}
