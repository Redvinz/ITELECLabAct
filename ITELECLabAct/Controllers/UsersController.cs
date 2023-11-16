using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class UsersController : Controller
    {
        private IUsersDataServices _service;

        public UsersController(IUsersDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Users = await _service.GetUsersAsync();
            return View(Users);
        }
    }
}
