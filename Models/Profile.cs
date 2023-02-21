namespace Masjid.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? InstitutionName { get; set; }
        public string? OldPassword { get; set; }
        public string? NewPassword { get; set; }
        public decimal? ConfirmPassword { get; set; }
        public string? ImageUrl { get; set; }
    }
}
