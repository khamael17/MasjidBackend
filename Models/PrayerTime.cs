namespace Masjid.Models
{
    public class PrayerTime
    {
        public int Id { get; set; }
        public string? Fajr { get; set; }
        public string? Dhur { get; set; }
        public string? Asr { get; set; }
        public string? Maghrib { get; set; }
        public string? Isha { get; set; }
        public string? Jummah { get; set; }
    }
}
