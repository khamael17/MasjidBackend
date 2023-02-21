using Masjid.Models;

namespace Masjid.Services
{
    public interface IHome
    {
     public   Hadith? GetHadith { get;  }
        public PrayerTime? GetPrayerTime { get;  }
        public Profile GetProfile { get;  }
        public IEnumerable<Feed> GetFeeds { get;  }
    }
}
