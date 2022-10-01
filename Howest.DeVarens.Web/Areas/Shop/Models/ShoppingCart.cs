namespace Howest.DeVarens.Web.Areas.Shop.Models
{
    public class ShoppingCart
    {
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
