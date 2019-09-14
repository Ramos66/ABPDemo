using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AAC.ABPDemo.Roles.Dto;
using AAC.ABPDemo.Users.Dto;

namespace AAC.ABPDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
