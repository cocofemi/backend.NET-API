using System.Text.Json.Serialization;

namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Password { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}