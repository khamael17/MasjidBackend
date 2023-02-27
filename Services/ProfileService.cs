using Masjid.Models;

namespace Masjid.Services
{
    public class ProfileService:IProfile
    {
        private readonly MasjidDbContext _context;
        public ProfileService(MasjidDbContext context)
        {
            _context = context;

        }



        public void CreateHadith( Hadith hadith)
        {
            _context.Hadiths.Add(hadith);
            _context.SaveChanges();
        }


        public void CreateImam( Imam imam)
        {
            _context.Imams.Add(imam);
            _context.SaveChanges();
        }


        public void CreateInstitution(Institution institution)
        {
            _context.Intitutions.Add(institution);
            _context.SaveChanges();
        }


        public void CreatePrayer(PrayerTime prayerTime)
        {
            _context.PrayerTimes.Add(prayerTime);
            _context.SaveChanges();
        }

        public void CreateFeed( Feed feed)
        {
            _context.Feeds.Add(feed);
            _context.SaveChanges();
        }


        public void CreateIslamicClass( IslamicClasse islamicClasse)
        {
            _context.IslamicClasses.Add( islamicClasse);
            _context.SaveChanges();
        }

        //public void CreateEvent()
        //{
        //    _context.Events.Add();
        //    _context.SaveChanges();
        //}


        public void CreateAftSchool(AftSchoolProgram aftSchoolProgram)
        {
            _context.AftSchoolPrograms.Add(aftSchoolProgram);
            _context.SaveChanges();
        }


        public void CreateYprogram(YouthProgram youthProgram)
        {
            _context.YouthPrograms.Add(youthProgram);
            _context.SaveChanges();
        }


        public void CreateEvent(Event even)
        {
            _context.Events.Add(even);
            _context.SaveChanges();
        }


    }
}

