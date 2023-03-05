using Masjid.Models;
using Masjid.Services;

namespace Masjid.ViewModels
{
    public class HomeViewModel
    {
       public List<Feed> _GetFeeds;
        public Hadith? _GetHadith { get; }
        public PrayerTime? _GetPrayerTime { get; }
        public Profile _GetProfile { get; }
        public HomeViewModel( )
        {
          
        }

    }
}
