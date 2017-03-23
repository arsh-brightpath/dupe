using System.Threading.Tasks;
using Abp.Application.Services;
using project56.Configuration.Host.Dto;

namespace project56.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
