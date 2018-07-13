using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using WardrobeCloud.Controllers;

namespace WardrobeCloud.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WardrobeCloudControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
