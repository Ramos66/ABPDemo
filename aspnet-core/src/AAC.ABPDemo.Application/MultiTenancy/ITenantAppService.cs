using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AAC.ABPDemo.MultiTenancy.Dto;

namespace AAC.ABPDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

