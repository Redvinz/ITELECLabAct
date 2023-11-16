using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class ImagesController : Controller
    {
        private IImagesDataServices _service;

        public ImagesController(IImagesDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Images = await _service.GetImagesAsync();
            return View(Images);
        }
    }
}
