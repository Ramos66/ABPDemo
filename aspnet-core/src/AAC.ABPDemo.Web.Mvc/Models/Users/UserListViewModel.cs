using System.Collections.Generic;
using AAC.ABPDemo.Roles.Dto;
using AAC.ABPDemo.Users.Dto;

namespace AAC.ABPDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
