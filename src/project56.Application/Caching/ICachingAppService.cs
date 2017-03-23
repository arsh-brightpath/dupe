using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Caching.Dto;

namespace project56.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
