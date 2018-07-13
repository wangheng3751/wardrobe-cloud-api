using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WardrobeCloud.Configuration;

namespace WardrobeCloud.Web.Host.Startup
{
    [DependsOn(
       typeof(WardrobeCloudWebCoreModule))]
    public class WardrobeCloudWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WardrobeCloudWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WardrobeCloudWebHostModule).GetAssembly());
        }
    }
}
