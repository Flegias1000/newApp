using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewApp.DB;
using NewApp.Entities;
using NewApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Repository repository;
        public HomeController(ILogger<HomeController> logger, Repository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StringaInvertita()
        {
            return View();
        }
        public IActionResult Persons()
        {
            return View();
        }
        public IActionResult Elenca()
        {
            return View();
        }

        public IActionResult NewPage()
        {
            MusicModel model = new MusicModel();
            model.Songs.Add(new MusicModel.SongAndArtistModel() { Cantante = "a", Canzone = "1" });
            model.Songs.Add(new MusicModel.SongAndArtistModel() { Cantante = "b", Canzone = "2" }); 


            return View(model);
        }

        public IActionResult NewModel()
        {
            NewModel model = new NewModel();
            model.Id = 1;
            model.Name = "Stefano";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
