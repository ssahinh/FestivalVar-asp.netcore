using FestivalVar.Domain;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Responses
{
    public class AuthSuccessResponse : BaseResponse<AuthenticationResult>
    {
        public string Token { get; set; }
        public IdentityUser Data { get; set; }
    }
}