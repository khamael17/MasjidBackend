using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class IslamicClasse
    {
        [BindNever]
        public int IslamicClasseId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? ClassTitle { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? IslamicClassGuest { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 50 characters")]
        [StringLength(50)]
        public string? IslamicClassTime_Place { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 200 characters")]
        [StringLength(200)]
        public string? ClassDescription { get; set; } = String.Empty!;
    }
}
