using Howest.DeVarens.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Howest.DeVarens.Web.Areas.Shop.ViewModels
{
    public class ShoppingcartIndexViewModel
    {
        public List<ShoppingcartDetailViewModel> ShoppingcartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
