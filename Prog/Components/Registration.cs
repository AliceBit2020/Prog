using Microsoft.AspNetCore.Mvc;

namespace Prog.Components
{
    public class Registration:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
