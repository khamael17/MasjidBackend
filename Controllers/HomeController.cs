using Masjid.Models;
using Masjid.Services;
using Masjid.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Masjid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       // private readonly HomeService _homeService;
        private readonly IHome _home;
        public HomeController(ILogger<HomeController> logger, IHome home)
        {
            _logger = logger;
            _home = home;   
        }

        public IActionResult Index()
        {
            //var HomeView = new HomeViewModel( _homeService,_home); 
            return View(_home);
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