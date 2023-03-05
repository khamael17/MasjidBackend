using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Institution
    {
        [BindNever]
        public int InstitutionId { get; set; }

        [Required(ErrorMessage ="This value cannot be empty/or over 80 characters")]
        [StringLength(80)]
        public string InstitutionName { get; set; }=String.Empty;
    }
}
