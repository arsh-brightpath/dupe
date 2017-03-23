using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using Microsoft.Owin.Security;
using project56.Authorization.Roles;
using project56.Authorization.Users;
using project56.MultiTenancy;

namespace project56.Web.Auth
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager, 
            IAuthenticationManager authenticationManager, 
            ISettingManager settingManager,
            IUnitOfWorkManager unitOfWorkManager) 
            : base(
                  userManager, 
                  authenticationManager,
                  settingManager,
                  unitOfWorkManager)
        {
        }
    }
}