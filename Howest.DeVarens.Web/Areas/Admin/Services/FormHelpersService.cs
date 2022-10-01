using Howest.DeVarens.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Howest.DeVarens.Web.Areas.Admin.Services
{
    public class FormHelpersService : IFormHelpersService
    {
        private readonly WebshopContext _webshopContext;

        public FormHelpersService(WebshopContext webshopContext)
        {
            _webshopContext = webshopContext;
        }
        public async Task<List<SelectListItem>> BuildFormOfEducationList()
        {
            return await _webshopContext
                .FormOfEducation
                .Where(f => f.DeletionDate == null)
                .Select(f => new SelectListItem { Text = f.Name, Value = f.Id.ToString() })
                .ToListAsync();
        }

        public async Task<List<SelectListItem>> BuildCategoryList()
        {
            return await _webshopContext
                .Categories
                .Where(c => c.DeletionDate == null)
                .Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() })
                .ToListAsync();
        }
    }
}