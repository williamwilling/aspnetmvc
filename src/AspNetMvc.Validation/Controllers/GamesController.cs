using System.Web.Mvc;

namespace AspNetMvc.Validation
{
    public class GamesController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GameViewModel game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }

            return RedirectToAction("Create");
        }
    }
}