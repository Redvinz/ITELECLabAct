using ITELECLabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELECLabAct.Controllers
{
    public class ContactsController : Controller
    {
        private IContactsDataServices _service;

        public ContactsController(IContactsDataServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var Contacts = await _service.GetContactsAsync();
            return View(Contacts);
        }
    }
}
