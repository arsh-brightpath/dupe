using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Authorization.Users.Dto;

namespace project56.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
