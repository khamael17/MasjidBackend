using Microsoft.EntityFrameworkCore;

namespace Masjid.Models
{
    public class MasjidDbContext:DbContext
    {
        public MasjidDbContext( DbContextOptions<MasjidDbContext> options ):base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Hadith> Hadiths { get; set; }
        public DbSet<PrayerTime> PrayerTimes { get; set; }
        public DbSet<YouthProgram> YouthPrograms { get; set; }
        public DbSet<AftSchoolProgram> AftSchoolPrograms { get; set; }
        public DbSet<IslamicClasse>     IslamicClasses { get; set; }
        public DbSet<Imam> Imams { get; set; }
        public DbSet<Institution> Intitutions { get; set; }

    }
}
