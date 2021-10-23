using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        public string Password { get; set; }
    }
}