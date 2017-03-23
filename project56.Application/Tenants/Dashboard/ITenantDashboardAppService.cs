using Abp.Application.Services;
using project56.Tenants.Dashboard.Dto;

namespace project56.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
