using Masjid.Models;
using System.ComponentModel.DataAnnotations;

namespace Masjid.ViewModels
{
    public class ProfileViewModel
    {

#region AfterSchoolProgram
        public int AftSchoolProgramId { get; set; }
        public string? AftSchoolProgramDesc { get; set; } = String.Empty!;
        public string? AftSchoolProgramPlace { get; set; } = String.Empty!;
        public string? AftSchoolProgramPrice { get; set; } = String.Empty!;
        public string? AftSchoolProgramTitle { get; set; } = String.Empty!;
        public string? AftSchoolProgramGuest { get; set; } = String.Empty!;
      
        public string? AftSchoolProgramTime { get; set; } = String.Empty!;
        #endregion

        #region Hadith
        public int HadithId { get; set; }
        public string? HadithDesc { get; set; } = String.Empty!;
        public string? HadithNarrator { get; set; } = String.Empty!;
#endregion

        #region Events
        public int EventId { get; set; }
        public string? EventDesc { get; set; } = String.Empty!;
        public string? EventTitle { get; set; } = String.Empty!;
        public string? EventNarrator { get; set; } = String.Empty!;
        public string? EventImageUrl { get; set; } = String.Empty!;
        public string? EventPrice { get; set; } = String.Empty!;
        public string? EventTime_Place { get; set; } = String.Empty!;
        #endregion

        #region Feed
        public int FeedId { get; set; }
        public string? FeedDesc { get; set; } = String.Empty!;
        public string? FeedNarrator { get; set; } = String.Empty!;
        public string? FeedTitle { get; set; } = String.Empty!;
        public string? FeedColor { get; set; } = String.Empty!;
        public string? FeedType { get; set; } = String.Empty!;
#endregion

        #region Islamic Class
        public int IslamicClasseId { get; set; }
        public string? ClassTitle { get; set; } = String.Empty!;
        public string? IslamicClassGuest { get; set; } = String.Empty!;
        public string? IslamicClassTime_Place { get; set; } = String.Empty!;
        public string? ClassDescription { get; set; } = String.Empty!;
        #endregion


        #region Profile Imam
        public string Imam_First_Name { get; set; } = String.Empty;

        public string Imam_Last_Name { get; set; } = String.Empty;

        public string? ProfileImageUrl { get; set; } = String.Empty!;
#endregion

        #region Youth Program
        public int YouthProgramId { get; set; }
        public string? YouthProgramDesc { get; set; } = String.Empty!;
        public string? YouthProgramGuest { get; set; } = String.Empty!;
        public string? YouthProgramTime { get; set; } = String.Empty!;
        public string? YouthProgramPlace { get; set; } = String.Empty!;
        public string? YouthProgramPrice { get; set; } = String.Empty!;
        public string? YouthProgramTitle { get; set; } = String.Empty!;
#endregion

        #region Prayers
        public int PrayerTimeId { get; set; }
        public string? Fajr { get; set; } = String.Empty!;
        public string? Dhur { get; set; } = String.Empty!;
        public string? Asr { get; set; } = String.Empty!;
        public string? Maghrib { get; set; } = String.Empty!;
        public string? Isha { get; set; } = String.Empty!;
        public string Jummah { get; set; } = String.Empty!;
        #endregion


        #region Institution
        public string? InstitutionName { get; set; } = String.Empty!;
        public string? Institution_Email { get; set; } = String.Empty!;
        public string? OldPassword { get; set; } = String.Empty!;
       
        public string? NewPassword { get; set; } = String.Empty!;
        public string? ConfirmPassword { get; set; } = String.Empty!;
        #endregion

    }
}
