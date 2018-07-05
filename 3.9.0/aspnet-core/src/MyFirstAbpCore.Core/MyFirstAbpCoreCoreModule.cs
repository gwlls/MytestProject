using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using MyFirstAbpCore.Authorization.Roles;
using MyFirstAbpCore.Authorization.Users;
using MyFirstAbpCore.Configuration;
using MyFirstAbpCore.Localization;
using MyFirstAbpCore.MultiTenancy;
using MyFirstAbpCore.Timing;

namespace MyFirstAbpCore
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MyFirstAbpCoreCoreModule : AbpModule
    {
        public override void PreInitialize()//预初始化：当应用启动后，第一次会调用这个方法。在依赖注入注册之前，你可以在这个方法中指定自己的特别代码
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MyFirstAbpCoreLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = MyFirstAbpCoreConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
            //在创建设置提供程序(SettingProvider)之后，我们应该在预初始化(PreIntialize)方法中注册我们的模块:
            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()//初始化：在这个方法中一般是来进行依赖注入的注册
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpCoreCoreModule).GetAssembly());
        }

        public override void PostInitialize()//提交初始化,用来解析依赖关系
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
        //Shutdown,关闭：当应用关闭以后，这个方法被调用。
    }
}
