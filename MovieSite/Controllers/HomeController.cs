using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieSite.Models;

namespace MovieSite.Controllers
{
    public class HomeController : Controller
    {
        private FilmDataContext _theContext { get; set; }

        public HomeController(FilmDataContext theContext)
        {
            _theContext = theContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Suggest()
        {
            ViewBag.Categories = _theContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Suggest(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _theContext.Add(ar);
                _theContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _theContext.Category.ToList();

                return View(ar);
            }

            
        }

        public IActionResult FilmList()
        {
            var films = _theContext.Films
                .Include(x => x.Category)
                .OrderBy(film => film.Title)
                .ToList();
            return View(films);
        }

        [HttpGet]
        public IActionResult Edit(int filmid)
        {

            ViewBag.Categories = _theContext.Category.ToList();

            var film = _theContext.Films.Single(x => x.FilmID == filmid);

            return View("Suggest", film);
        
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            _theContext.Update(ar);
            _theContext.SaveChanges();

            return RedirectToAction("FilmList");
        }
        
        [HttpGet]
        public IActionResult Delete(int filmid)
        {
            var film = _theContext.Films.Single(x => x.FilmID == filmid);
            return View(film);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _theContext.Films.Remove(ar);
            _theContext.SaveChanges();

            return RedirectToAction("FilmList");
        }
    }
}
