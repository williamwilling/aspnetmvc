using System.Web.Mvc;

namespace AspNetMvc.DropDownList
{
    public class GamesController : Controller
    {
        public ActionResult Create()
        {
            return View(new GameViewModel());
        }

        [HttpPost]
        public ActionResult Create(GameViewModel game)
        {
            // NOTE: Put a breakpoint on the next line and inspect the properties of the parameter.
            return View(new GameViewModel());
        }
    }
}