using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.DeVarens.Web.Areas.Shop.ViewModels
{
    public class ShoppingcartDetailViewModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductMediaPath { get; set; }
        public IEnumerable<SelectListItem> Quantities { get; set; }
        public int Quantity { get; set; }
    }
}
