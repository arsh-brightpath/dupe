using System.Threading.Tasks;
using Abp.Application.Services;
using project56.Sessions.Dto;

namespace project56.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
