using Masjid.Models;

namespace Masjid.Services
{
    public interface IHome
    {
     public   Hadith? GetHadith { get;  }
        public PrayerTime? GetPrayerTime { get;  }
        public Profile? GetProfile { get;  }
        public List<Feed>? GetFeeds { get;  }
        public List<Event>? GetEvents { get; }
        public Institution? GetInstitutions { get; }       
        public List<Hadith>? GetHadiths { get; }
        public List<YouthProgram>? GetYouthProgram { get; }
        public List<IslamicClasse>? GetIslamicClassess { get; }
        public List<AftSchoolProgram>? GetAftSchoolPrograms { get; }
       
        

        

    }
}
