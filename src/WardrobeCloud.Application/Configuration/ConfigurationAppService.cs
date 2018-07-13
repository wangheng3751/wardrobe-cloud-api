using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WardrobeCloud.Configuration.Dto;

namespace WardrobeCloud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WardrobeCloudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
