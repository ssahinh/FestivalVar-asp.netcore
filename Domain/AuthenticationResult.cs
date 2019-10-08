using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Domain
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        
        public bool Success { get; set; }
        public IdentityUser Data { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}