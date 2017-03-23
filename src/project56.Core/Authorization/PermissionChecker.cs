using Abp.Authorization;
using project56.Authorization.Roles;
using project56.Authorization.Users;
using project56.MultiTenancy;

namespace project56.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
