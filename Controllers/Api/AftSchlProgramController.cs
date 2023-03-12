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
        public IProfile _profile;


        public AftSchlProgramController( IProfile profile)
        {
            _profile = profile; 
            
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public IActionResult CreateProgram([FromBody]AftSchoolProgram aftSchoolProgram) {
            _profile.CreateAftSchool(aftSchoolProgram);
        return new JsonResult(new {Success = true});
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAftSchool(int id)
        {
            _profile.DeleteAftSchool(id);
            return NoContent();
        }

    }
}
