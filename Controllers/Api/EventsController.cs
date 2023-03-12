using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {   public IProfile _profile;

    public EventsController(IProfile profile)
    {
        _profile = profile;
    }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult CreateEv([FromBody] Event datat)
        {
            _profile.CreateEvent(datat);
            return new JsonResult("propre");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEv(int id)
        {
            _profile.DeleteEvent(id);
            return NoContent();
        }


    }
}
 



