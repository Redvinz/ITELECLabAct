using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface IContactsDataServices
    {
        Task<List<ContactsModel>> GetContactsAsync();
    }
}
