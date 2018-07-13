using Microsoft.AspNetCore.Antiforgery;
using WardrobeCloud.Controllers;

namespace WardrobeCloud.Web.Host.Controllers
{
    public class AntiForgeryController : WardrobeCloudControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
