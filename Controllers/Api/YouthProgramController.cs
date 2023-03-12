using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class YouthProgramController : ControllerBase
    {
        private readonly IProfile _profile;
        public YouthProgramController( IProfile profile)
        {
            _profile = profile;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        [HttpPost]
        public IActionResult CreateYprogram([FromBody] YouthProgram youthProgram ) 
        { 
           _profile.CreateYprogram( youthProgram );
        return new JsonResult(new { Success = true });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteYprogram( int id)
        {
            _profile.DeleteYprogram(id);
            return NoContent();
        }
    }
}
