using Microsoft.AspNetCore.Antiforgery;
using MyFirstAbpCore.Controllers;

namespace MyFirstAbpCore.Web.Host.Controllers
{
    public class AntiForgeryController : MyFirstAbpCoreControllerBase
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
