namespace GreenSaleTest.Domain.Entities.Roles.UserRoles;

public class UserRole : Auditable
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
}
