using System.Web.Mvc;

namespace AspNetMvc.ViewStart
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