using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WardrobeCloud.Configuration;

namespace WardrobeCloud.Web.Startup
{
    [DependsOn(typeof(WardrobeCloudWebCoreModule))]
    public class WardrobeCloudWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WardrobeCloudWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<WardrobeCloudNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WardrobeCloudWebMvcModule).GetAssembly());
        }
    }
}
