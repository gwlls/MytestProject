using System.Threading.Tasks;
using MyFirstAbpCore.Configuration.Dto;

namespace MyFirstAbpCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
