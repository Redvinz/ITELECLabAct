using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface IProductsDataServices
    {
        Task<List<ProductsModel>> GetProductsAsync();
    }
}
