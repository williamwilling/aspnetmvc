using System.Web.Mvc;

namespace AspNetMvc.BasicView
{
    public class GreetingsController : Controller
    {
        public ActionResult Hello()
        {
            return View();
        }
    }
}