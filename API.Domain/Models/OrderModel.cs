namespace API.Domain.Models
{
    public class OrderModel : EntityBase

    {
        private ClientModel Client {  get; set; }
        private UserModel User { get; set; }
    }
}
