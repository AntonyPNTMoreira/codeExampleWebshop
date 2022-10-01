namespace Howest.DeVarens.Web.Areas.Shop.ViewModels
{
    public class ShoppingcartItemViewModel
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
