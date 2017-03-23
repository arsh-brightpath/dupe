using System.Collections.Generic;
using project56.Authorization.Users.Dto;
using project56.Dto;

namespace project56.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}