using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbpCore.Configuration;
using MyFirstAbpCore.EntityFrameworkCore;
using MyFirstAbpCore.Migrator.DependencyInjection;

namespace MyFirstAbpCore.Migrator
{
    [DependsOn(typeof(MyFirstAbpCoreEntityFrameworkModule))]
    public class MyFirstAbpCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstAbpCoreMigratorModule(MyFirstAbpCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MyFirstAbpCoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MyFirstAbpCoreConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpCoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
