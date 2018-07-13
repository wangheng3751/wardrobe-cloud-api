using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WardrobeCloud.Authorization;

namespace WardrobeCloud
{
    [DependsOn(
        typeof(WardrobeCloudCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WardrobeCloudApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WardrobeCloudAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WardrobeCloudApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
