using Abp.Authorization;
using WardrobeCloud.Authorization.Roles;
using WardrobeCloud.Authorization.Users;

namespace WardrobeCloud.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
