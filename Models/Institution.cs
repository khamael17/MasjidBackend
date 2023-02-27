using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Masjid.Models
{
    public class Institution
    {
        [BindNever]
        public int InstitutionId { get; set; }

        [Required(ErrorMessage ="This value cannot be empty/or over 30 characters")]
        [StringLength(30)]
        public string InstitutionName { get; set; }=String.Empty;
    }
}
