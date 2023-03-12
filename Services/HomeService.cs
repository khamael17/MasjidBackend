using Masjid.Models;
using Microsoft.EntityFrameworkCore;

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

      

       public  List<Event>? GetEvents =>  _context.Events.FromSql($"select top(2) * from events order by EventId DESC").ToList();

        public Institution? GetInstitutions => _context.Intitutions.FromSql($"select top(1) * from Intitutions order by InstitutionId DESC").FirstOrDefault();

        public Imam? GetImam => _context.Imams.FromSql($"select top(1) * from Imams order by ImamId DESC").FirstOrDefault();

        public List<YouthProgram>? GetYouthProgram => _context.YouthPrograms.ToList();
         
        public List<IslamicClasse>? GetIslamicClassess => _context.IslamicClasses.ToList();

        public List<AftSchoolProgram>? GetAftSchoolPrograms => _context.AftSchoolPrograms.ToList();

  


    }
}
    

