using System.Web.Mvc;

namespace AspNetMvc.LayoutView
{
    public class GreetingsController : Controller
    {
        public ActionResult Hello()
        {
            return View();
        }

        public ActionResult Goodbye()
        {
            return View();
        }
    }
}