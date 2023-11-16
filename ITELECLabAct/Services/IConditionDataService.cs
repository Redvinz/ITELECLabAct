using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface IConditionDataService
    {
        Task<List<ConditionModel>> GetConditionAsync();
    }
}
