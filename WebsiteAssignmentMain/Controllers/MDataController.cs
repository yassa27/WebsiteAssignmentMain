using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsiteAssignmentMain.Models;
using Microsoft.AspNetCore.Identity;


namespace WebsiteAssignmentMain.Controllers
{
    [Authorize(Roles = "Manager")]
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
        public IActionResult MovieADD()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieADD(MovieForm model)
        {
            if (ModelState.IsValid)
            {
                Movie addedMovie = new Movie
                {
                    Movie_Name = model.Movie_Name,
                    Movie_Year = (int)model.Movie_Year,
                    Movie_Genre = model.Movie_Genre,
                    Movie_Time = model.Movie_Time,
                    Movie_Imdb = model.Movie_Imdb,
                    Movie_Votes = model.Movie_Votes,
                    Movie_Gross = model.Movie_Gross,
                };
                _context.Add(addedMovie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult MovieEDIT(int id)
        {
            Movie model = _context.Movies.Find(id);
            MovieForm formModel = new MovieForm
            {
                Movie_Id = model.Movie_Id,
                Movie_Name = model.Movie_Name,
                Movie_Year = model.Movie_Year,
                Movie_Genre = model.Movie_Genre,
                Movie_Time = model.Movie_Time,
                Movie_Imdb = model.Movie_Imdb,
                Movie_Votes = model.Movie_Votes,
                Movie_Gross = model.Movie_Gross,
            };
            return View(formModel);
        }
        [HttpPost]
        public IActionResult MovieEDIT(MovieForm model)
        {
            if (ModelState.IsValid)
            {
                Movie editedMovie = new Movie
                {
                    Movie_Id = model.Movie_Id,
                    Movie_Name = model.Movie_Name,
                    Movie_Year = (int)model.Movie_Year,
                    Movie_Genre = model.Movie_Genre,
                    Movie_Time = model.Movie_Time,
                    Movie_Imdb = model.Movie_Imdb,
                    Movie_Votes = model.Movie_Votes,
                    Movie_Gross = model.Movie_Gross,
                };
                _context.Movies.Update(editedMovie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult MovieDELETE(int Id)
        {
            Movie model = _context.Movies.Find(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult MovieDELETE(Movie model)
        {
            _context.Movies.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
