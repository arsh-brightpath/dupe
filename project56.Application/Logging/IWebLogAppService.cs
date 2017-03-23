using Abp.Application.Services;
using project56.Dto;
using project56.Logging.Dto;

namespace project56.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
