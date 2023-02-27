using Masjid.Models;
using Masjid.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Masjid.Pages
{
    public class EventPageModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }
        private readonly MasjidDbContext _context;
        public readonly IHome _home;
        public EventPageModel( IHome home )
        {
            _home = home;
        }
        public void OnGet()
        {

            
        }

        public IActionResult OnPost(Event even) { 
        
            //if(ModelState.IsValid) 
            //{
            //    _context.Events.Remove(even);
            //    return Page();
            //}

            return Page();
        }
    }
}
