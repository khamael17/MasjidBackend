using Masjid.Models;

namespace Masjid.Services
{
    public interface IProfile
    {
        public void CreateEvent(Event even);
        public void DeleteEvent(int id);
        public void CreateHadith(Hadith hadith);



        public void CreateImam(Imam imam);


        public void CreateInstitution(Institution institution);


        public void CreatePrayer(PrayerTime prayerTime);


        public void CreateFeed(Feed feed);
        public void DeleteFeed(int id);



        public void CreateIslamicClass(IslamicClasse islamicClasse);
        public void DeleteIslamicClass(int id);

        //public void CreateEvent()
        //{
        //    _context.Events.Add();
        //    _context.SaveChanges();
        //}


        public void CreateAftSchool(AftSchoolProgram aftSchoolProgram);
        public void DeleteAftSchool(int id);




        public void CreateYprogram(YouthProgram youthProgram);

        public void DeleteYprogram(int id);





    }
}
