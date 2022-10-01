using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Howest.DeVarens.Web.Areas.Admin.Services
{
    public interface IFileService
    {
        Task<string> AddOrUpdateFile(IFormFile file, string subPath, IWebHostEnvironment webHostEnvironment, string fileName = "");
    }
}