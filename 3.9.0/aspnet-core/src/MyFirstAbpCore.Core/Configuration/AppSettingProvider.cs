using System.Collections.Generic;
using Abp.Configuration;

namespace MyFirstAbpCore.Configuration
{   //定义设置,使用设置之前必须要先定义
    //SettingDefinition 类的构造函数中有如下参数：

    //Name(必填) :必须具有全系统唯一的名称。比较好的办法是定义字符串常量来设置Name。
    //Default value: 设置一个默认值。此值可以是null 或空字符串。
    //Scopes: 定义设置的范围(见下文)。
    //Display name: 一个可本地化的字符串，用于以后在UI中显示设置的名称。
    //Description: 一个可本地化的字符串，用于以后在UI中显示设置的描述。
    //Group: 可用于设置组。这仅仅是UI使用，不用于设置管理。
    //IsVisibleToClients: 设置为 true 将使设置在客户端可用。
    //在创建设置提供程序(SettingProvider)之后，我们应该在预初始化(PreIntialize)方法中注册我们的模块:
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition(AppSettingNames.UiTheme, "red", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true)
            };
        }
    }
}
