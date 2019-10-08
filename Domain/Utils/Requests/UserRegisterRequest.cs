using System.ComponentModel.DataAnnotations;

namespace FestivalVar.Requests
{
    public class UserRegisterRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}