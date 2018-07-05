using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyFirstAbpCore.Authorization.Roles;
using MyFirstAbpCore.Authorization.Users;
using MyFirstAbpCore.Entities;
using MyFirstAbpCore.MultiTenancy;
using MyFirstAbpCore.People;


namespace MyFirstAbpCore.EntityFrameworkCore
{
    public class MyFirstAbpCoreDbContext : AbpZeroDbContext<Tenant, Role, User, MyFirstAbpCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        //TODO: Define an IDbSet for each Entity...
       public virtual DbSet<NoteBook> NoteBook { get; set; }

        public virtual DbSet<Person> Person { get; set; }
        public MyFirstAbpCoreDbContext(DbContextOptions<MyFirstAbpCoreDbContext> options)
            : base(options)
        {

        }
    }
}