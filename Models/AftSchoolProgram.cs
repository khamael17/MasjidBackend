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

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 20 characters")]
        [StringLength(20)]
        public  string? AftSchoolProgramTime { get; set; } = String.Empty!;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? AftSchoolProgramPlace { get; set; } = String.Empty!;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 20 characters")]
        [StringLength(20)]
        public string? AftSchoolProgramPrice { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 30 characters")]
        [StringLength(30)]
        public string? AftSchoolProgramTitle { get; set; }=String.Empty!;


    }
}
