namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class OrderItemDetailViewModel
    {
        public int Quantity { get; set; }
        public Guid? OrderId { get; set; }
        public decimal ProductPrice { get; set; }
        public ProductDetailViewModel Product { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
