namespace API.Domain.Models
{
    public class UserModel : EntityBase
    {
        private string Name { get; set }
        private string Login { get; set; }
        private String Password { get; set; }
    }
}
