namespace API.Domain.Models
{
    public class ProductModel : EntityBase
    {
        private string Description { get; set; }
        private string SellValue { get; set; }
        private int Stock {  get; set; }

    }
}
