using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class AccountController : Controller
{
    // Login action to trigger OpenID Connect authentication
    public async Task Login(string returnUrl = "/")
    {
        var properties = new AuthenticationProperties { RedirectUri = returnUrl };
        await HttpContext.ChallengeAsync(OpenIdConnectDefaults.AuthenticationScheme, properties);
    }

    // Logout action to sign out of both Cookie Authentication and OpenID Connect
    public async Task Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme, new AuthenticationProperties
        {
            RedirectUri = "/"
        });
    }

    // Access denied page for unauthorized users
    public IActionResult AccessDenied()
    {
        return View();
    }
}
