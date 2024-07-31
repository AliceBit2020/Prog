using Microsoft.AspNetCore.Mvc;

namespace Prog.Components
{
    public class NavPanel : ViewComponent
    {

       public IViewComponentResult Invoke()
        {
            if (User.Identity.Name == "" || User.Identity.Name is null)
            {
                ViewBag.Name = "";
                ViewBag.LogIOText = "LogIn";
                ViewBag.LogIOAction = "Login";
                ViewBag.IsAuthorise = false;
            }
            else
            {
                ViewBag.Name = User.Identity.Name;
                ViewBag.LogIOText = "LogOut";
                ViewBag.LogIOAction = "Logout";
                ViewBag.IsAuthorise = true;
            }

            return View(ViewBag);
        }
    }
}
