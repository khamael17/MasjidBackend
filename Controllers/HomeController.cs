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


        // GET: ProfileController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileController/Create

     
        public ActionResult Feed()
        {

                return View(_home.GetFeeds);

        }



        public ActionResult Events()
        {

            return View(_home.GetEvents);

        }

        public ActionResult IslamicClass()
        {
          
                return View(_home.GetIslamicClassess);
        }

      
        public ActionResult Youthprogram()
        {
            return View(_home.GetYouthProgram);
        }


        public ActionResult AfterSchoolProgram()
        {
            return View(_home.GetAftSchoolPrograms);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}