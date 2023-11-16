using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class SavesDataServices : ISavesDataServices
    {
        private AppDbContext _appDbContextSaves;
        public SavesDataServices(AppDbContext appDbContext)
        {
            _appDbContextSaves = appDbContext;
        }


        public async Task<List<SavesModel>> GetSavesAsync()
        {
            var Saves = await _appDbContextSaves.Saves.ToListAsync();
            return Saves;
        }
    }
}
