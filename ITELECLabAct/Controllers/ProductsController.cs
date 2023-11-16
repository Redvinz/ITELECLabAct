using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsDataServices _service;

        public ProductsController(IProductsDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Products = await _service.GetProductsAsync();
            return View(Products);
        }
    }
}