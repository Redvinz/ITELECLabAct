using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class CategoriesDataServices : ICategoriesDataServices
    {
        private AppDbContext _appDbContextCategories;
        public CategoriesDataServices(AppDbContext appDbContext)
        {
            _appDbContextCategories = appDbContext;
        }


        public async Task<List<CategoriesModel>> GetCategoriesAsync()
        {
            var Categories = await _appDbContextCategories.Categories.ToListAsync();
            return Categories;
        }
    }
}
