using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.DeVarens.Web.Areas.Admin.Services
{
    public interface IFormHelpersService
    {
        Task<List<SelectListItem>> BuildFormOfEducationList();
        Task<List<SelectListItem>> BuildCategoryList();  
    }
}