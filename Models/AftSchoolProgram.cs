using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class AftSchoolProgram
    {
        [BindNever]
        public int AftSchoolProgramId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 300 characters")]
        [StringLength(300)]
        public string? AftSchoolProgramDesc { get; set; }=String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 50 characters")]
        [StringLength(50)]
        public  string? AftSchoolProgramTimePlace { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 20 characters")]
        [StringLength(20)]
        public string? AftSchoolProgramPrice { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 30 characters")]
        [StringLength(30)]
        public string? AftSchoolProgramTitle { get; set; }=String.Empty!;


    }
}
