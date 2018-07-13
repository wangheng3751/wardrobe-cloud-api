using System.Threading.Tasks;
using Abp.Application.Services;
using WardrobeCloud.Sessions.Dto;

namespace WardrobeCloud.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
