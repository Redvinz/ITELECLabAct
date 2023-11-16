using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class ProductsDataServices : IProductsDataServices
    {
        private AppDbContext _appDbContextProducts;
        public ProductsDataServices(AppDbContext appDbContext)
        {
            _appDbContextProducts = appDbContext;
        }


        public async Task<List<ProductsModel>> GetProductsAsync()
        {
            var Products = await _appDbContextProducts.Products.ToListAsync();
            return Products;
        }
    }
}
