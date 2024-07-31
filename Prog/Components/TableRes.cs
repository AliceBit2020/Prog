using Microsoft.AspNetCore.Mvc;
using Prog.Model;

namespace Prog.Components
{
    public class TableRes:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<TestInfo> list = new List<TestInfo>()
            {
                new TestInfo(){Theme=new Theme(){Name="Components.PartialView"},Result="4/5"},
                new TestInfo(){Theme=new Theme(){Name="Components.PartialView"},Result="5/5"},
                new TestInfo(){Theme=new Theme(){Name="SaveConditions"},Result="4/5"}

            };
            return View(list);
        }
    }
}
