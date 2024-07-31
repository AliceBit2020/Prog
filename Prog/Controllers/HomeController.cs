using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Prog.Model;
using System.Diagnostics;
using System.Security.Claims;
using Prog.Services;
using Microsoft.AspNetCore.Authorization;

namespace Prog.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ISignIn sin = new SignInCookie();
        private User user;
        public HomeController(User user_)
        {
            user= user_;
            
        }

        public IActionResult Index()
        {
            //throw new Exception("Test exception");

            ViewBag.Username = User.Identity.Name;
            return View();
        }

    

        public IActionResult Register() 
        
        {
            return View();
        }
		public IActionResult Login()

		{
			return View();
		}
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> LoginResult(UserLoginBinding model)
        {
            if (ModelState.IsValid)
            {
               user.Password = PasswordHasher.HashPassword( model.Password);
                user.Login=model.Login;
                
                await  sin.SignInAsync(user,HttpContext);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Login", model);
            }


        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }


            [HttpPost]
        public IActionResult RegisterResult(UserRegBinding user)
        {   
            if(ModelState.IsValid)
            {
				return View("Login" );
			}
            else
            {
				return View("Register",user);
			}
           

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
