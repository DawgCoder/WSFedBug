using Microsoft.AspNetCore.Authentication.WsFederation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet("account/login")]
        public async void Login()
        {
            await HttpContext.ChallengeAsync(WsFederationDefaults.AuthenticationScheme, new AuthenticationProperties { RedirectUri = "https://localhost:7035/default" });
        }
    }
}