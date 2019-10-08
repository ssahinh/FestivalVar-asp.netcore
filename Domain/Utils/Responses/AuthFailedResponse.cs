using System.Collections.Generic;
using FestivalVar.Domain;

namespace FestivalVar.Responses
{
    public class AuthFailedResponse : BaseResponse<AuthenticationResult>
    {
        public IEnumerable<string> Errors { get; set; }
        
    }
}