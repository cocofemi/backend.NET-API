namespace WebApi.Models.Users
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string JwtToken { get; set; }
    }
}