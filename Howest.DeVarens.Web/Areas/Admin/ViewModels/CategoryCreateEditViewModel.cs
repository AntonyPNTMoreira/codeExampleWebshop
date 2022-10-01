using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class CategoryCreateEditViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Naam")]
        [Required(ErrorMessage = "Gelieve de naam in te vullen.")]
        public string Name { get; set; }
        [DisplayName("Omschrijving")]
        [Required(ErrorMessage = "Gelieve de omschrijving in te vullen.")]
        public string Description { get; set; }
    }
}
