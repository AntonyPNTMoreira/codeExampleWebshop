using System.ComponentModel.DataAnnotations;

namespace Howest.DeVarens.Web.Areas.Shop.ViewModels
{
    public class SearchViewModel
    {
        public string? SearchTerm { get; set; }
        public IEnumerable<string> CategoryIds { get; set; }
        public IEnumerable<string> FormOfEducationIds { get; set; }
    }
}
