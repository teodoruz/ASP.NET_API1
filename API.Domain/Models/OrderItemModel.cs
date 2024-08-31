namespace API.Domain.Models
{
    public class OrderItemModel : EntityBase
    {
        private OrderModel Order { get; set; }
        private ProductModel Product { get; set; }
        private decimal SellValue { get; set; }
        private int Quantity { get; set; }
        private decimal TotalAmaunt {  get; set; }

    }
}
