using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class PrayerTime
    {
        [BindNever]
        public int PrayerTimeId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string? Fajr { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string? Dhur { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string? Asr { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string? Maghrib { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string? Isha { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 10 characters")]
        [StringLength(10)]
        public string Jummah { get; set; } = String.Empty!;
    }
}
