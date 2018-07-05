using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyFirstAbpCore.Configuration;
using MyFirstAbpCore.Web;

namespace MyFirstAbpCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyFirstAbpCoreDbContextFactory : IDesignTimeDbContextFactory<MyFirstAbpCoreDbContext>
    {
        public MyFirstAbpCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyFirstAbpCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyFirstAbpCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyFirstAbpCoreConsts.ConnectionStringName));

            return new MyFirstAbpCoreDbContext(builder.Options);
        }
    }
}
