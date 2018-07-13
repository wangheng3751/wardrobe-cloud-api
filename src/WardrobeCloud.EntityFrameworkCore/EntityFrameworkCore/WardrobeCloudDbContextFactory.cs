using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WardrobeCloud.Configuration;
using WardrobeCloud.Web;

namespace WardrobeCloud.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WardrobeCloudDbContextFactory : IDesignTimeDbContextFactory<WardrobeCloudDbContext>
    {
        public WardrobeCloudDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WardrobeCloudDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WardrobeCloudDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WardrobeCloudConsts.ConnectionStringName));

            return new WardrobeCloudDbContext(builder.Options);
        }
    }
}
