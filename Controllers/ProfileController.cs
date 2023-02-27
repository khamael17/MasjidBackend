using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfile _profile;
        public ProfileController(ILogger<ProfileController> logger, IProfile prof)
        {
            _logger = logger;
            _profile = prof;
        }




        [HttpPost]
        public ActionResult CreateEvent(Profile view_model)
        {
            try
            {
                //   var b = even.IsValid();
                //if(even.IsValid())  _profile.CreateEvent(even);

                return View("Create");


            }
            catch
            {
                return View();
            }
        }




        // GET: ProfileController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        public ActionResult Create()
        {
            return View();
        }



        // GET: ProfileController/Create




        [HttpPost]
        public ActionResult Createprof(Profile view_model)
        {
            try
            {
                //   var b = even.IsValid();
                //if(even.IsValid())  _profile.CreateEvent(even);

                return View("Create");


            }
            catch
            {
                return View();
            }
        }






        [HttpPost]
        public ActionResult CreateInstitution(Institution view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateInstitution(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }




        [HttpPost]
        public ActionResult CreateName(Imam view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateImam(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }





        [HttpPost]
        public ActionResult CreatePassword(Profile view_model)
        {
            try
            {
                //   var b = even.IsValid();
                //if(even.IsValid())  _profile.CreateEvent(even);

                return View("Create");


            }
            catch
            {
                return View();
            }
        }



        [HttpPost]
        public ActionResult CreatePrayers(PrayerTime view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreatePrayer(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }





        [HttpPost]
        public ActionResult CreateFeed(Feed view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateFeed(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }








        [HttpPost]
        public ActionResult CreateClass(IslamicClasse view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateIslamicClass(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }





        [HttpPost]
        public ActionResult CreateYprogram(YouthProgram view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateYprogram(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }







        [HttpPost]
        public ActionResult CreateAftSchl(AftSchoolProgram view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateAftSchool(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }




        [HttpPost]
        public ActionResult CreateHadith(Hadith view_model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _profile.CreateHadith(view_model);
                }

                return View("Create");


            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(Event view_model)
        {
            try
            {
                //   var b = even.IsValid();
                //if(even.IsValid())  _profile.CreateEvent(even);

                return View("Create");


            }
            catch
            {
                return View();
            }
        }

        // POST: ProfileController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ProfileController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
