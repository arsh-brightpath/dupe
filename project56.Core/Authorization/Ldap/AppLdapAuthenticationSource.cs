using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using project56.Authorization.Users;
using project56.MultiTenancy;

namespace project56.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
