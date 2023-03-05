using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class YouthProgram
    {
        [BindNever]
        public int YouthProgramId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 500 characters")]



        [StringLength(500)]
        public string? YouthProgramDesc { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]



        [StringLength(100)]
        public string? YouthProgramGuest { get; set; } = String.Empty!;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? YouthProgramTime { get; set; } = String.Empty!;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? YouthProgramPlace { get; set; } = String.Empty!;




        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? YouthProgramPrice { get; set; } = String.Empty!;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 50 characters")]
        [StringLength(50)]
        public string? YouthProgramTitle { get; set; } = String.Empty!;

    }
}
