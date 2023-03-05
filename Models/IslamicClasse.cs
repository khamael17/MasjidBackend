using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class IslamicClasse
    {
        [BindNever]
        public int IslamicClasseId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? ClassTitle { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? IslamicClassGuest { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? IslamicClassTime_Place { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 500 characters")]
        [StringLength(500)]
        public string? ClassDescription { get; set; } = String.Empty!;
    }
}
