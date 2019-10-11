using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _dataContext.Categories
                .Include(category => category.Festivals)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryById(int Id)
        {
            return await _dataContext.Categories.SingleOrDefaultAsync(x => x.Id == Id);
        }
    }
}