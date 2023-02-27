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

        #region MockDataFortesting
        public Hadith? GetHadith => _context.Hadiths.FirstOrDefault();
        public PrayerTime? GetPrayerTime { get => _context.PrayerTimes.FirstOrDefault(); }
        public Profile GetProfile { get => _context.Profiles.FirstOrDefault(); } //new Profile { FirstName = "SA", LastName = "KhalilouT", InstitutionName = "Islamic Center Lansing" }; }
        public List<Feed> GetFeeds => _context.Feeds.ToList();
        #endregion


    }
}
    

