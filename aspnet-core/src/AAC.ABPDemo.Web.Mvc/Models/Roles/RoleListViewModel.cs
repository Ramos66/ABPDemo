using System.Collections.Generic;
using AAC.ABPDemo.Roles.Dto;

namespace AAC.ABPDemo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
