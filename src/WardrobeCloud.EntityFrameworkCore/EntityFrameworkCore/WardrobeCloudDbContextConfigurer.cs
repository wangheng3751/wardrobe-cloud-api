using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WardrobeCloud.EntityFrameworkCore
{
    public static class WardrobeCloudDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WardrobeCloudDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WardrobeCloudDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
