using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.AutoMapper;
using project56.Sessions.Dto;

namespace project56.Sessions
{
    [AbpAuthorize]
    public class SessionAppService : project56AppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>()
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            return output;
        }
    }
}