using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace easycontacts.Controllers
{
    public class BaseController : Controller
    {
        private readonly IConfiguration _config;

        public BaseController()
        {
            GetURLs();
        }

        public void GetURLs()
        {
            ViewData["whatsappAPIURL"] = _config.GetValue<string>("WhatsappAPIURL");;
            ViewData["SkypeURL"] = _config.GetValue<string>("SkypeURL");
        }

    }
}