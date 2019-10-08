using FestivalVar.Domain;

namespace FestivalVar.Responses
{
    public class AuthSuccessResponse : BaseResponse<AuthenticationResult>
    {
        public string Token { get; set; }
    }
}