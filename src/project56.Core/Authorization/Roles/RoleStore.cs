using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using project56.Authorization.Users;

namespace project56.Authorization.Roles
{
    public class RoleStore : AbpRoleStore<Role, User>
    {
        public RoleStore(
            IRepository<Role> roleRepository,
            IRepository<UserRole, long> userRoleRepository,
            IRepository<RolePermissionSetting, long> rolePermissionSettingRepository)
            : base(
                roleRepository,
                userRoleRepository,
                rolePermissionSettingRepository)
        {

        }
    }
}
