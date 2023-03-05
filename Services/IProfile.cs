using Masjid.Models;

namespace Masjid.Services
{
    public interface IProfile
    {
        public void CreateEvent(Event even);
        public void CreateHadith(Hadith hadith);



        public void CreateImam(Imam imam);


        public void CreateInstitution(Institution institution);


        public void CreatePrayer(PrayerTime prayerTime);


        public void CreateFeed(Feed feed);



        public void CreateIslamicClass(IslamicClasse islamicClasse);


        //public void CreateEvent()
        //{
        //    _context.Events.Add();
        //    _context.SaveChanges();
        //}


        public void CreateAftSchool(AftSchoolProgram aftSchoolProgram);



        public void CreateYprogram(YouthProgram youthProgram);





    }
}
