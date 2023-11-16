using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface IUsersDataServices
    {
        Task<List<UsersModel>> GetUsersAsync();
    }
}
