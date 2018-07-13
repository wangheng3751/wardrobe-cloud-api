using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WardrobeCloud.Roles.Dto;

namespace WardrobeCloud.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
