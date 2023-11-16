using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface ICategoriesDataServices
    {
        Task<List<CategoriesModel>> GetCategoriesAsync();
    }
}
