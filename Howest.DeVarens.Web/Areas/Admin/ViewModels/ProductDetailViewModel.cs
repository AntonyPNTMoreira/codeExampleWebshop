using Howest.DeVarens.Core.Entities;

namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class ProductDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<MediaDetailViewModel> Media { get; set; }
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
        public Guid FormOfEducationId { get; set; }
        public string FormOfEducation { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
