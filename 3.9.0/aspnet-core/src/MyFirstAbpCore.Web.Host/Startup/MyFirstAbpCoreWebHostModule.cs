using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbpCore.Configuration;

namespace MyFirstAbpCore.Web.Host.Startup
{
    [DependsOn(
       typeof(MyFirstAbpCoreWebCoreModule))]
    public class MyFirstAbpCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstAbpCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpCoreWebHostModule).GetAssembly());
        }
    }
}
