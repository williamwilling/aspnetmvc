using System.Web.Mvc;

namespace AspNetMvc.Form
{
    public class GamesController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string playerOne, string playerTwo, int rounds, string ruleset)
        {
            // NOTE: Put a breakpoint on the next line and inspect the values of the parameters.
            return View();
        }
    }
}