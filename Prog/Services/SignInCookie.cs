using Microsoft.AspNetCore.Authentication.Cookies;
using Prog.Model;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Prog.Services
{
    public class SignInCookie:ISignIn
    {
        public async Task SignInAsync(Object obj, HttpContext ctx)
        {
            User user = (User)obj;
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Login),
                new Claim(ClaimTypes.Role, "User"),
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await ctx.SignInAsync(claimsPrincipal);
        }
    }
}
