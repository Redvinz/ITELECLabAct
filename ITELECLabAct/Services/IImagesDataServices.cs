using ITELECLabAct.Models;

namespace ITELECLabAct.Services
{
    public interface IImagesDataServices
    {
        Task<List<ImagesModel>> GetImagesAsync();
    }
}
