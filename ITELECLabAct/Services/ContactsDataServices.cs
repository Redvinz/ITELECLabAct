using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class ContactsDataServices : IContactsDataServices
    {
        private AppDbContext _appDbContextContacts;
        public ContactsDataServices(AppDbContext appDbContext)
        {
            _appDbContextContacts = appDbContext;
        }


        public async Task<List<ContactsModel>> GetContactsAsync()
        {
            var Contacts = await _appDbContextContacts.Contacts.ToListAsync();
            return Contacts;
        }
    }
}
