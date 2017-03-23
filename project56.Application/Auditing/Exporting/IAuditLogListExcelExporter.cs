using System.Collections.Generic;
using project56.Auditing.Dto;
using project56.Dto;

namespace project56.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
