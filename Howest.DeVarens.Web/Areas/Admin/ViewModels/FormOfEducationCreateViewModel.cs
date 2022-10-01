using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class FormOfEducationCreateViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Naam")]
        [Required(ErrorMessage = "Gelieve een naam in te voeren.")]
        public string Name { get; set; }
        [DisplayName("Rangschik volgorde")]
        [Range(1, int.MaxValue,
        ErrorMessage = "Het getal mag niet negatief zijn.")]
        [Required(ErrorMessage = "Gelieve een geldig nummer in te voeren voor de rangschikking.")]
        public int DisplayOrder { get; set; }
        [DisplayName("Beschrijving")]
        [Required(ErrorMessage = "Gelieve een beschrijving in te voeren.")]
        public string Description { get; set; }
    }
}
