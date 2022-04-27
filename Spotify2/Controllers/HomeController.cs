using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spotify2.Models;
using System.Diagnostics;

namespace Spotify2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SpotifyContext _spotifyContext;

        public HomeController(ILogger<HomeController> logger,SpotifyContext spotifyContext)
        {
            _logger = logger;
            _spotifyContext = spotifyContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetSong()
        {
            Random random = new Random();
           var randomNum = random.Next(89074);
            var selectedSong = _spotifyContext.Lists.Where(x => x.Id == randomNum).FirstOrDefault();
            return View("GetSong",selectedSong);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}