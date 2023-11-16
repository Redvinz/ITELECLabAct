using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoriesDataServices _service;

        public CategoriesController(ICategoriesDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Categories = await _service.GetCategoriesAsync();
            return View(Categories);
        }
    }
}
