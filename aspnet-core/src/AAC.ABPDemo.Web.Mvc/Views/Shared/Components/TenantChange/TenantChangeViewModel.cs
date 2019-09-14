using Abp.AutoMapper;
using AAC.ABPDemo.Sessions.Dto;

namespace AAC.ABPDemo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
