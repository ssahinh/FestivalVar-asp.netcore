using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface IAuthService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}