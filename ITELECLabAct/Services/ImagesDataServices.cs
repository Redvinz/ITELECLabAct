using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Services
{
    public class ImagesDataServices : IImagesDataServices
    {
        private AppDbContext _appDbContextImages;
        public ImagesDataServices(AppDbContext appDbContext)
        {
            _appDbContextImages = appDbContext;
        }


        public async Task<List<ImagesModel>> GetImagesAsync()
        {
            var Images = await _appDbContextImages.Images.ToListAsync();
            return Images;
        }
    }
}
