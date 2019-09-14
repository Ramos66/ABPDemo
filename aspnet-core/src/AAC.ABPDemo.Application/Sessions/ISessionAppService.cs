using System.Threading.Tasks;
using Abp.Application.Services;
using AAC.ABPDemo.Sessions.Dto;

namespace AAC.ABPDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
