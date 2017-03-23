using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Auditing.Dto;
using project56.Dto;

namespace project56.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}