using Abp.Authorization;
using MyFirstAbpCore.Authorization.Roles;
using MyFirstAbpCore.Authorization.Users;

namespace MyFirstAbpCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
