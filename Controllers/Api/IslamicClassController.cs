using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslamicClassController : ControllerBase
    {
        public IProfile _profile;



        public IslamicClassController( IProfile profile )
        {
            _profile = profile;
        }


        [HttpPost]
        public IActionResult CreateIslamicClass(IslamicClasse model) {

            _profile.CreateIslamicClass(model);
            return new JsonResult(new {Success=true});
        }
    }
}
