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
        public virtual DbSet<Clothes.Clothes> Clothes { get; set; }
        public virtual DbSet<Clothes.ClothesCategory> ClothesCategory { get; set; }
        public virtual DbSet<DressCollocation.DressCollocation> DressCollocation { get; set; }
        public virtual DbSet<DressCollocation.DressCollocationItem> DressCollocationItem { get; set; }
        public virtual DbSet<DressCollocation.DressCollocationTag> DressCollocationTag { get; set; }
        public virtual DbSet<DressCollocation.UserDressCollocationTag> UserDressCollocationTag { get; set; }

        public WardrobeCloudDbContext(DbContextOptions<WardrobeCloudDbContext> options)
            : base(options)
        {

        }
    }
}
