using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class YouthProgram
    {
        [BindNever]
        public int YouthProgramId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 250 characters")]
        [StringLength(250)]
        public string? YouthProgramDesc { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? YouthProgramGuest { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? YouthProgramTimePlace { get; set; } = String.Empty!;
        [Required(ErrorMessage = "This field cannot be empty/cannot be over 20 characters")]
        [StringLength(20)]
        public string? YouthProgramPrice { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? YouthProgramTitle { get; set; } = String.Empty!;

    }
}
