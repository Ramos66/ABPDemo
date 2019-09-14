using Abp.Authorization;
using AAC.ABPDemo.Authorization.Roles;
using AAC.ABPDemo.Authorization.Users;

namespace AAC.ABPDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
