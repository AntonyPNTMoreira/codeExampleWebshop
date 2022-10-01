namespace Howest.DeVarens.Web.Areas.Admin.ViewModels
{
    public class OrderDetailViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<OrderItemDetailViewModel> OrderItems { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeletionDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int ProductsCount { get; set; }
        public bool IsOpen { get; set; }
        public Guid ProductId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
