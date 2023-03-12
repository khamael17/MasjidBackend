using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Institution
    {
        [BindNever]
        public int InstitutionId { get; set; }

        [Required(ErrorMessage ="This value cannot be empty/or over 80 characters")]
        [StringLength(80)]
        public string InstitutionName { get; set; }=String.Empty;



        [Required(ErrorMessage = "This value cannot be empty/or over 50 characters")]
        [StringLength(50)]
        public string Institution_Email { get; set; } = String.Empty;

        public string? OldPassword { get; set; } = String.Empty!;
       
        public string? NewPassword { get; set; } = String.Empty!;
       
        public string? ConfirmPassword { get; set; } = String.Empty!;
    }
}
