using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImamController : ControllerBase
    {
        public IProfile _profile;

        public ImamController( IProfile profile )
        {
            _profile = profile;
        }


    

      
        [HttpPost]
        public IActionResult CreateImam([FromBody] Imam datat)
        {
            _profile.CreateImam(datat);
            return new JsonResult(new { Success = true });
        }

    }
}
