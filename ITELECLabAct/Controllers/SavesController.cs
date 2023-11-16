using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class SavesController : Controller
    {
        private ISavesDataServices _service;

        public SavesController(ISavesDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Saves = await _service.GetSavesAsync();
            return View(Saves);
        }
    }
}
