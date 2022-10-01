using Howest.DeVarens.Web.Areas.Shop.ViewModels;
using Howest.DeVarens.Core.Entities;

namespace Howest.DeVarens.Web.Areas.Shop.Services.Interfaces
{
    public interface ISessionService
    {
        ShoppingcartIndexViewModel GetProducts();
        void AddProductToShoppingcart(Product product);
    }
}
