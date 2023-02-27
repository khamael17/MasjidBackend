using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Hadith
    {
        [BindNever]
        public int HadithId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 300 characters")]
        [StringLength(300)]
        public string? HadithDesc { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string? HadithNarrator { get; set; } = String.Empty!;

        public  bool IsValid()
        {
            if (string.IsNullOrEmpty(HadithDesc)) { return false; }
            return true;
        }
    }
}
