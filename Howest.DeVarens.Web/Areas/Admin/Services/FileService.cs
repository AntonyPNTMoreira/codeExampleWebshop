
namespace Howest.DeVarens.Web.Areas.Admin.Services
{
    public class FileService : IFileService
    {
        public async Task<string> AddOrUpdateFile(IFormFile file, string subPath, IWebHostEnvironment
            webHostEnvironment, string fileName = "")
        {
            if (fileName == "")
            {
                fileName = $"{Guid.NewGuid()}_{Path.GetExtension(file.FileName)}";
            }
            string filePath = Path
                .Combine(webHostEnvironment.WebRootPath, "images", subPath, fileName);

            using (FileStream fileStream = new(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

        internal Task<string> AddOrUpdateFile(IFormFile image, string v)
        {
            throw new NotImplementedException();
        }
    }
}