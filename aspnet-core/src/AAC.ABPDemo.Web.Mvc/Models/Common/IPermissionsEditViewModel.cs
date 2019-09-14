using System.Collections.Generic;
using AAC.ABPDemo.Roles.Dto;

namespace AAC.ABPDemo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}