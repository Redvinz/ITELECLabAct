using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class ConditionController : Controller
    {
        private IConditionDataService _service;
            
        public ConditionController(IConditionDataService service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Condition = await _service.GetConditionAsync();
            return View(Condition);
        }
    }
}
