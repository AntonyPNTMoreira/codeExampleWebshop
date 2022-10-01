using Howest.DeVarens.Core.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class ProductCreateEditViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Naam")]
        [Required(ErrorMessage = "Gelieve een naam in te voeren.")]
        public string Name { get; set; }
        [DisplayName("Prijs")]
        [Required(ErrorMessage = "Gelieve een prijs in te voeren.")]
        public decimal Price { get; set; }
        [DisplayName("Beschrijving")]
        [Required(ErrorMessage = "Gelieve een beschrijving in te voeren.")]
        public string Description { get; set; }
        [ValidateNever]
        public List<SelectListItem> FormOfEducations { get; set; }
        [DisplayName("Opleiding")]
        public Guid FormOfEducationId { get; set; }
        [ValidateNever]
        public List<SelectListItem> Categories { get; set; }
        [DisplayName("Categorie")]
        public Guid CategoryId { get; set; }
        [DataType(DataType.Upload)]
        public ICollection<IFormFile> Images { get; set; }
    }
}
