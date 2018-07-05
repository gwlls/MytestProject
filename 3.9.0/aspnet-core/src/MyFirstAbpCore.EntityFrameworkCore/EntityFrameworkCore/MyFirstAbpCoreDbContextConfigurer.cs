using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyFirstAbpCore.EntityFrameworkCore
{
    public static class MyFirstAbpCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyFirstAbpCoreDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyFirstAbpCoreDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
