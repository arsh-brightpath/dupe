using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Authorization.Permissions.Dto;

namespace project56.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
