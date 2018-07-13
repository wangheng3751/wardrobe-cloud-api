using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace WardrobeCloud.Web.Views
{
    public abstract class WardrobeCloudRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected WardrobeCloudRazorPage()
        {
            LocalizationSourceName = WardrobeCloudConsts.LocalizationSourceName;
        }
    }
}
