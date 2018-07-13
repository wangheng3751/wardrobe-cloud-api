using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WardrobeCloud.Authorization.Roles;
using WardrobeCloud.Authorization.Users;
using WardrobeCloud.MultiTenancy;

namespace WardrobeCloud.EntityFrameworkCore
{
    public class WardrobeCloudDbContext : AbpZeroDbContext<Tenant, Role, User, WardrobeCloudDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WardrobeCloudDbContext(DbContextOptions<WardrobeCloudDbContext> options)
            : base(options)
        {
        }
    }
}
