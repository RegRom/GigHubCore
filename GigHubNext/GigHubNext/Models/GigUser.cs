using System.ComponentModel.DataAnnotations;

namespace GigHubNext.Models
{
    public class GigUser
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

    }
}
