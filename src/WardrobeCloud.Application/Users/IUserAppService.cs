using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WardrobeCloud.Roles.Dto;
using WardrobeCloud.Users.Dto;

namespace WardrobeCloud.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
