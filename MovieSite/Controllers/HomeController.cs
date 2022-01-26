using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieSite.Models;

namespace MovieSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FilmDataContext _theContext { get; set; }

        public HomeController(ILogger<HomeController> logger, FilmDataContext theContext)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult Suggest (ApplicationResponse ar)
        {

            _theContext.Add(ar);
            _theContext.SaveChanges();

            return View("Confirmation", ar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
