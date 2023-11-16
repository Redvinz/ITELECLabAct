using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class UsersDataServices : IUsersDataServices
    {
        private AppDbContext _appDbContextUsers;
        public UsersDataServices(AppDbContext appDbContext)
        {
            _appDbContextUsers = appDbContext;
        }


        public async Task<List<UsersModel>> GetUsersAsync()
        {
            var Users = await _appDbContextUsers.Users.ToListAsync();
            return Users;
        }
    }
}

