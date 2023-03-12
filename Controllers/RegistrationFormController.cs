using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers
{
    public class RegistrationFormController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // private readonly HomeService _homeService;
        private readonly IHome _home;
        public RegistrationFormController
        (ILogger<HomeController> logger, IHome home)
        {
            _logger = logger;
            _home = home;
        }

        public IActionResult Index()
        {
            ViewBag.Institution_Name = _home.GetInstitutions.InstitutionName;
            ViewBag.Imam_Name = _home.GetImam.Imam_Last_Name;
            ViewBag.Prayers = _home.GetPrayerTime;
            return View(_home);
        }

        [HttpPost]
        // I want to send an email using the data from the form
        public IActionResult Index([FromBody] Participant model)
        {
            var m = model;
            // I want to send an email using the data from the form
            return NoContent();
        }
    }
}
