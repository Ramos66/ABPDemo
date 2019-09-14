using System.Threading.Tasks;
using Abp.Application.Services;
using AAC.ABPDemo.Authorization.Accounts.Dto;

namespace AAC.ABPDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
