using System.Collections.Generic;
using Abp.Application.Services.Dto;
using project56.Authorization.Permissions.Dto;

namespace project56.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}