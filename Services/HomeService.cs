using Masjid.Models;

namespace Masjid.Services 
{
    public class HomeService : IHome
    {
        public Hadith? GetHadith  => new Hadith { Id = 1, HadithDesc = " Il est bon ds linteret de khalil de chercher Allah", Narrator = "sa kahalilout"  };
    public    PrayerTime? GetPrayerTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      public  Profile GetProfile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public IEnumerable<Feed> GetFeeds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      
    }
}
