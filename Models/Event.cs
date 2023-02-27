using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Event
    {
        [BindNever]
        public int EventId { get; set; }



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 250 characters")]
        [StringLength(250)]
        public string EventDesc { get; set; } = String.Empty;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string EventTitle { get; set; } = String.Empty;



        [Required(ErrorMessage = "This field cannot be empty/cannot be over 25 characters")]
        [StringLength(25)]
        public string EventNarrator { get; set; } = String.Empty;


        [Required(ErrorMessage = "This field cannot be empty/cannot be over 20 characters")]
        [StringLength(20)]
        public string? AftSchoolProgramPrice { get; set; } = String.Empty!;


        public string? EventImageUrl { get; set; } = String.Empty;

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(EventDesc)|| string.IsNullOrEmpty(EventTitle)|| string.IsNullOrEmpty(EventNarrator)) { return false; }
            return true;
        }
    }
}
