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
                    new Feed { FeedColor = "red", FeedType = "Funeral", FeedNarrator = "Imam Shazad", FeedTitle = "To God we belong and to him we shall return", FeedDesc = "Dear brothers and sisters, it is with great sadness that we inform you of the passing of our beloved brother, Mr. John Doe. May Allah grant him Jannah and may Allah grant his family the strength to bear this loss. May Allah reward you for your efforts." },
                    new Feed { FeedColor = "gold", FeedType = "Fund Raisng", FeedNarrator = "Imam Khalilou", FeedTitle = "Help for Palestine", FeedDesc = " Dear brothers and sisters, We need to support our Brothers and Sisters afflected by this big disaster.Please be generous in your donations " },
                    new Feed { FeedColor = "gold", FeedType = "Fund Raisng", FeedNarrator = "Imam Khalilou", FeedTitle = "Sunday School Lunch", FeedDesc = "    Dear brothers and sisters, as you all know the new school year is starting in about a month, and we need funds to support the kitchen for the kids lunch.We cannot make this possible without you,we are commited this year to provide Hala and organic foods for the kids, and this come at a cost .Please be generous in your donations " },
                     new Feed { FeedColor = "cyan", FeedType = "General Annoucement", FeedNarrator = "Imam Shazad", FeedTitle = "Prayer Time change", FeedDesc = " From November 14th,2023 we will be praying the prayer of Fajr at 5:30AM and the prayer of Ishaa at 6:30PM. Please be on time for the prayer. May Allah reward you for your efforts. " }
             );
            }

            if (!context.PrayerTimes.Any())
            {
                context.AddRange(
                    new PrayerTime { Fajr = "06:00 AM", Dhur = "01:00 PM", Asr = "04:00 PM", Maghrib = "06:30 PM", Isha = "08:00 PM", Jummah = "02:00 PM" },
                    new PrayerTime { Fajr = "06:50 AM", Dhur = "02:00 PM", Asr = "04:20 PM", Maghrib = "06:00 PM", Isha = "11:00 PM", Jummah = "02:00 PM" }
                    );
            }


            if (!context.Profiles.Any())
            {
                context.AddRange(
                    new Profile { InstitutionName = "Lansing Islamic Center", FirstName = "Zayd", LastName = "Ahmad" }

                    );
            }

            if (!context.Hadiths.Any())
            {
                context.AddRange(
                    new Hadith { HadithDesc = " Il est bon ds linteret de khalil de chercher Allah", HadithNarrator = "sa kahalilout" },
                    new Hadith { HadithDesc = " Allah est le Tout Mesicordieux", HadithNarrator = "Quran" }
                    );
            }
            if (!context.Intitutions.Any())
            {
                context.Add(new Institution { InstitutionName = "Lansing Islamic Center" });

            }

            if (!context.Imams.Any())
            {
                context.Add( new Imam { Imam_Last_Name = "Imam Khalilou" } );
            }

            if (!context.Events.Any())
            {
                context.AddRange(new Event { EventTitle = "Wedding", EventPrice = "Free!!", EventNarrator = "Imam Shazad", EventTime_Place = "123 N Main St,East Lansing,MI at 8:00 PM", EventDesc = "Please Join us next sunday to celebrate the Nikkah of the Brother Man MAN and sister Hafsa. May Allah bless their couple" },
                            new Event { EventTitle = "Community Eid Gathering", EventPrice = "$5", EventNarrator = "Imam Shazad", EventTime_Place = "Masjid at 3:00 PM", EventDesc = "We will be hosting a  Eid Party the first sunday after Eid, please bring some home made food so we can all share in a spirit of family" },
                            new Event { EventTitle = "Seminar", EventPrice = "Free!!", EventNarrator = "Board of Directors", EventTime_Place = "MSU, Burkey Hall at 12:00 PM", EventDesc = "We have the honor to receive the visit of Numan Ali Khan on Feb 12,2022. He will be speaking about the ''Respect of Parents'' "}
                            
                    );
            }
            if (!context.IslamicClasses.Any())
            {
                context.AddRange(
                     new IslamicClasse { ClassTitle = " New Muslim Introduction", IslamicClassGuest = "Imam Sirajudin", IslamicClassTime_Place = "Masjids All Purpose Area after Maghrib", ClassDescription = "We will be going through the fundamentals of Islam for the new muslims,your presence will be much appreciated." },
                     new IslamicClasse { ClassTitle = "Quran Halaqa", IslamicClassGuest = "Imam Sirajudin", IslamicClassTime_Place = "Masjids All Purpose Area after Maghrib,Every Wednesday", ClassDescription = "Please join us to read and study the Book of truth(Quran).May Allah increases us in knowledge." },
                     new IslamicClasse { ClassTitle = "Tawheed Class", IslamicClassGuest = "Imam Saabir", IslamicClassTime_Place = " Masjids Conference Room, Every Sunday at 5:00pm ", ClassDescription = "Tawheed is the basis of our faith, lets make sure that we are not associating anything with Allah in our hearts. " }
                     );
            }

            if (!context.YouthPrograms.Any())
            {
                context.AddRange(
                    new YouthProgram { YouthProgramTitle = "Takwendo Classes", YouthProgramGuest = "Black Belt Li Wu", YouthProgramPrice = "$50/month", YouthProgramTime = "Every Friday after Ishaa at 8:00 PM", YouthProgramPlace = "Masjid Gymnasium", YouthProgramDesc = "Islamic Center in collaboration with the local Martial Arts Officials are proud to offer to the young muslim some self defense classes and training about what to do when a Code Green is going on" },
                    new YouthProgram { YouthProgramTitle = "Basket Ball Training", YouthProgramGuest = "Coach Spencer", YouthProgramPrice = "Free", YouthProgramTime = "Every Sunday at 9:00 AM", YouthProgramPlace = "Masjid Gymnasium", YouthProgramDesc = "Come have some fuuun while exercising your body with your friends!!" },
                    new YouthProgram { YouthProgramTitle = "Soccer Team", YouthProgramGuest = "Brother Konate", YouthProgramPrice = "Free", YouthProgramTime = " Enrollment Open until Feb 14th", YouthProgramPlace = "MSU Soccer Field", YouthProgramDesc = "The masjid is looking to build a soccer team for the up coming soccer tournament, join us by enrolling today" }

                    ); 
            }

            if (!context.AftSchoolPrograms.Any())
            {
                context.AddRange(
                    new AftSchoolProgram { AftSchoolProgramGuest = "Sister Juwayriyya & Sister NusayBah", AftSchoolProgramPrice = "$150/month", AftSchoolProgramPlace="Masjid community haul", AftSchoolProgramTitle = "Day Care", AftSchoolProgramTime = "Monday to Friday from 7:30 AM to 4:00 PM", AftSchoolProgramDesc = "Islamic Center is offering a Day Care program to help some muslim families, the registration acceptance will be decided on a base to base basis" },
                     new AftSchoolProgram { AftSchoolProgramGuest = "Imam Shazad", AftSchoolProgramPrice = "$20/Month", AftSchoolProgramTitle = "Tawheed class",AftSchoolProgramPlace="Community Area", AftSchoolProgramTime = "Everyday at 5:00 PM", AftSchoolProgramDesc = "Come learn the basics and rules of Arabic reading" }
                     
                    );
            }

            context.SaveChanges();
        }
    }
}
