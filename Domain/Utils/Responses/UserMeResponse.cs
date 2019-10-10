using FestivalVar.Domain;
using FestivalVar.Responses;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Domain.Utils.Responses
{
    public class UserMeResponse : BaseResponse<UserMeResult>
    {
        public IdentityUser Data { get; set; }
    }
}