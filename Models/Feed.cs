using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Feed
    {
        [BindNever]
        public int FeedId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 250 characters")]
        [StringLength(250)]
        public string? FeedDesc { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 50 characters")]
        [StringLength(50)]
        public string? FeedNarrator { get; set; } = String.Empty!;

        [Required(ErrorMessage = "This field cannot be empty/cannot be over 50 characters")]
        [StringLength(50)]
        public string? FeedTitle { get; set; } = String.Empty!;
        public string? FeedColor { get; set; } = String.Empty!;
        public string? FeedType { get; set; } = String.Empty!;
    }
}
