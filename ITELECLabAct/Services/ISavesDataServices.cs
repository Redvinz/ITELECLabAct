using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface ISavesDataServices
    {
        Task<List<SavesModel>> GetSavesAsync();
    }
}
