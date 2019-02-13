using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GigHubNext.Models
{
    public sealed class GigUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
