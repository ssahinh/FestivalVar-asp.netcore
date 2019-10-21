using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetAllPostsAsync();
        Task<bool> CreatePostAsync(Post post, ApplicationUser user);
    }
}