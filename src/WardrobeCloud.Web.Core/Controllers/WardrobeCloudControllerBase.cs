using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WardrobeCloud.Controllers
{
    public abstract class WardrobeCloudControllerBase: AbpController
    {
        protected WardrobeCloudControllerBase()
        {
            LocalizationSourceName = WardrobeCloudConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
