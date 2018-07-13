using System.Threading.Tasks;
using WardrobeCloud.Configuration.Dto;

namespace WardrobeCloud.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
