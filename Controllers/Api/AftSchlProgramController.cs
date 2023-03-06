using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AftSchlProgramController : ControllerBase
    {
        private readonly IProfile _profile;


        public AftSchlProgramController( IProfile profile)
        {
            _profile = profile; 
            
        }


        [HttpPost]
        public IActionResult CreateProgram(AftSchoolProgram aftSchoolProgram) {
            _profile.CreateAftSchool(aftSchoolProgram);
        return new JsonResult(new {Success = true});
        }
    }
}
