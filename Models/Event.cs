using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Event
    {
        [BindNever]
        public int EventId { get; set; }



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 500 characters")]
        [StringLength(500)]
        public string EventDesc { get; set; } = String.Empty;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string EventTitle { get; set; } = String.Empty;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string EventNarrator { get; set; } = String.Empty;


        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? EventPrice { get; set; } = String.Empty!;


        [Required(ErrorMessage = "This field cannot be empty/cannot be over 100 characters")]
        [StringLength(100)]
        public string? EventTime_Place { get; set; } = String.Empty!;




        public string? EventImageUrl { get; set; } = String.Empty;

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(EventDesc)|| string.IsNullOrEmpty(EventTitle)|| string.IsNullOrEmpty(EventNarrator)) { return false; }
            return true;
        }
    }
}
