using Microsoft.AspNetCore.Mvc;

namespace Prog.Components
{
	public class Login:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
