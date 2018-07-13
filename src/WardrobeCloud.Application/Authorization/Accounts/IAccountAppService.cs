using System.Threading.Tasks;
using Abp.Application.Services;
using WardrobeCloud.Authorization.Accounts.Dto;

namespace WardrobeCloud.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
