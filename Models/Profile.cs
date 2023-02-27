using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Profile
    {
        [BindNever]
        public int ProfileId { get; set; }
        [Required(ErrorMessage ="Please enter your first name")]
        [StringLength(30)]
        public string? FirstName { get; set; } = String.Empty!;
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(30)]
        public string? LastName { get; set; } = String.Empty!;
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(50)]
        public string? InstitutionName { get; set; } = String.Empty!;
        [Required(ErrorMessage = "Enter your Old Password for verification")]
        public string? OldPassword { get; set; } = String.Empty!;
        [Required(ErrorMessage = "This field cannot be empty")]
        public string? NewPassword { get; set; } = String.Empty!;
        [Required(ErrorMessage = "This field cannot be empty")]
        public string? ConfirmPassword { get; set; } = String.Empty!;
        public string? ProfileImageUrl { get; set; }= String.Empty!;

    }
}
