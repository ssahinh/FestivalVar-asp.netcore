using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _dataContext;

        public PostService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Post>> GetAllPostsAsync()
        {
            return await _dataContext.Posts.Include(post => post.User).ToListAsync();
        }

        public async Task<bool> CreatePostAsync(Post post, ApplicationUser user)
        {
            await _dataContext.Posts.AddAsync(post);
            post.User = user;

            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }
    }
}