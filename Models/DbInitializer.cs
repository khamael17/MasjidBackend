namespace Masjid.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            MasjidDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MasjidDbContext>();

            if (!context.Feeds.Any())
            {
                context.AddRange(
                    new Feed { FeedColor = "black", FeedType = "General Annoucement", FeedNarrator = "Imam Khalilou", FeedTitle = "Help for Palestine", FeedDesc = " Dear brothers and sisters, We need to support our Brothers and Sisters afflected by this big disaster.Please be generous in your donations " },
                     new Feed { FeedColor = "orange", FeedType = "General Annoucement", FeedNarrator = "Imam Khalilou", FeedTitle = "Help for Sudan", FeedDesc = " Dear brothers and sisters, We need to support our Brothers and Sisters afflected by this big disaster.Please be generous in your donations " }
             );

                if (context.PrayerTimes.Any())
                {
                    context.AddRange(
                        new PrayerTime { Fajr = "06:00 AM", Dhur = "01:00 PM", Asr = "04:00 PM", Maghrib = "06:30 PM", Isha = "08:00 PM", Jummah = "02:00 PM" },
                        new PrayerTime { Fajr = "06:50 AM", Dhur = "02:00 PM", Asr = "04:20 PM", Maghrib = "06:00 PM", Isha = "11:00 PM", Jummah = "02:00 PM" }
                        );
                }


                if (context.Profiles.Any())
                {
                    context.AddRange(
                        new Profile { InstitutionName="Lansing Islamic Center", FirstName="Zayd",LastName="Ahmad" }
                       
                        );
                }

                if (context.Hadiths.Any())
                {
                    context.AddRange(
                        new Hadith { HadithId = 1, HadithDesc = " Il est bon ds linteret de khalil de chercher Allah", HadithNarrator = "sa kahalilout" },
                        new Hadith { HadithId = 1, HadithDesc = " Allah est le Tout Mesicordieux", HadithNarrator = "Quran" }
                        );
                }
            }
            context.SaveChanges();
        }
    }
}
