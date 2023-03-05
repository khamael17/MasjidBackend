using Masjid.Models;

namespace Masjid.Services
{
    public class HomeService : IHome
    {
        private readonly MasjidDbContext _context;
        public HomeService(MasjidDbContext context)
        {
            _context = context;

        }

  
        public Hadith? GetHadith => _context.Hadiths.FirstOrDefault();
        public PrayerTime? GetPrayerTime { get => _context.PrayerTimes.FirstOrDefault(); }
        public Profile GetProfile { get => _context.Profiles.FirstOrDefault(); } //new Profile { FirstName = "SA", LastName = "KhalilouT", InstitutionName = "Islamic Center Lansing" }; }
        public List<Feed> GetFeeds => _context.Feeds.ToList();

      

       public  List<Event>? GetEvents =>  _context.Events.ToList();

        public Institution? GetInstitutions => _context.Intitutions.FirstOrDefault();

        public Imam? GetImam => _context.Imams.FirstOrDefault();

        public List<YouthProgram>? GetYouthProgram => _context.YouthPrograms.ToList();
         
        public List<IslamicClasse>? GetIslamicClassess => _context.IslamicClasses.ToList();

        public List<AftSchoolProgram>? GetAftSchoolPrograms => _context.AftSchoolPrograms.ToList();

  


    }
}
    

