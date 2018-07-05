using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyFirstAbpCore.Configuration.Dto;

namespace MyFirstAbpCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyFirstAbpCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
