using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        
        Task<Category> GetCategoryById(int Id);

    }
}