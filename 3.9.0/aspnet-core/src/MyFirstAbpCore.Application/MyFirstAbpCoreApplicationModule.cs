using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbpCore.Authorization;

namespace MyFirstAbpCore
{  
    //MyApplicationModule和MyCoreModule的依赖关系(通过属性attribute)
    [DependsOn(
        typeof(MyFirstAbpCoreCoreModule),
        typeof(AbpAutoMapperModule))]
    public class MyFirstAbpCoreApplicationModule : AbpModule//定义
    {
        public override void PreInitialize()//预初始化,依赖注入注册之前，你可以在这个方法中指定自己的特别代码
        {
            Configuration.Authorization.Providers.Add<MyFirstAbpCoreAuthorizationProvider>();
        }

        public override void Initialize()//进行依赖注入的注册
        {
            var thisAssembly = typeof(MyFirstAbpCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
            //这行代码的写法基本上是不变的。它的作用是把当前程序集的特定类或接口注册到依赖注入容器中。
            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
