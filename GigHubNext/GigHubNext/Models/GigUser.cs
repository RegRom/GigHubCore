using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GigHubNext.Models
{
    public class GigUser : IdentityUser
    {

        [Required]
        public string Username { get; set; }

    }
}
