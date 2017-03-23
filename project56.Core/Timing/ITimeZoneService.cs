using System.Threading.Tasks;
using Abp.Configuration;

namespace project56.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
