using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Hadith
    {
        [BindNever]
        public int HadithId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 1000 characters")]
        [StringLength(1000)]
        public string? HadithDesc { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? HadithNarrator { get; set; } = String.Empty!;

        public  bool IsValid()
        {
            if (string.IsNullOrEmpty(HadithDesc)) { return false; }
            return true;
        }
    }
}
