using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AAC.ABPDemo.Authorization.Roles;
using AAC.ABPDemo.Authorization.Users;
using AAC.ABPDemo.MultiTenancy;

namespace AAC.ABPDemo.EntityFrameworkCore
{
    public class ABPDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPDemoDbContext(DbContextOptions<ABPDemoDbContext> options)
            : base(options)
        {
        }
    }
}
