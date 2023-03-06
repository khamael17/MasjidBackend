using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Masjid.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        public IProfile _profile;

        public FeedController( IProfile profile)
        {
            _profile = profile;
            
        }


        [HttpPost]
        public IActionResult CreateFeed(Feed feed) {

            if (feed.FeedType == "General Announcement") feed.FeedColor = "blue";
            else if (feed.FeedType == "Request For Duaa") feed.FeedColor = "green";
            else if (feed.FeedType == "Funeral") feed.FeedColor = "red";
            else if (feed.FeedType == "Funds Raising") feed.FeedColor = "gold";

            _profile.CreateFeed(feed);
        
        return new JsonResult(new { Success=true });
        }
    }
}
