using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Imam
    {    
        [BindNever]
        public int ImamId { get; set; }


        [Required(ErrorMessage = "This value cannot be empty/or over 30 characters")]
        [StringLength(30)]
        public string Imam_First_Name { get; set; } = String.Empty;


        [Required(ErrorMessage = "This value cannot be empty/or over 30 characters")]
        [StringLength(30)]
        public string Imam_Last_Name { get; set; } = String.Empty;

      
    }
}
