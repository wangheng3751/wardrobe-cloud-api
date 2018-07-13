using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WardrobeCloud.MultiTenancy.Dto;

namespace WardrobeCloud.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
