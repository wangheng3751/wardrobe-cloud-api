using Abp.AspNetCore.Mvc.ViewComponents;

namespace WardrobeCloud.Web.Views
{
    public abstract class WardrobeCloudViewComponent : AbpViewComponent
    {
        protected WardrobeCloudViewComponent()
        {
            LocalizationSourceName = WardrobeCloudConsts.LocalizationSourceName;
        }
    }
}
