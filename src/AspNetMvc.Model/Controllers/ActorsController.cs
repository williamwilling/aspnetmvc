using System.Web.Mvc;

namespace AspNetMvc.Model
{
    public class ActorsController : Controller
    {
        public ActionResult Index()
        {
            var actors = new Actor[]
            {
                new Actor()
                {
                    FirstName = "Hugh",
                    LastName = "Jackman",
                    Nationality = "Australian"
                },

                new Actor()
                {
                    FirstName = "Gary",
                    LastName = "Oldman",
                    Nationality = "English"
                },

                new Actor()
                {
                    FirstName = "Keira",
                    LastName = "Knightley",
                    Nationality = "English"
                },

                new Actor()
                {
                    FirstName = "Morgan",
                    LastName = "Freeman",
                    Nationality = "American"
                },

                new Actor()
                {
                    FirstName = "Jennifer",
                    LastName = "Connelly",
                    Nationality = "American"
                },

                new Actor()
                {
                    FirstName = "Russell",
                    LastName = "Crowe",
                    Nationality = "Australian"
                },

                new Actor()
                {
                    FirstName = "William",
                    LastName = "Shatner",
                    Nationality = "Canadian"
                }
            };

            return View(actors);
        }

        public ActionResult Details()
        {
            var actor = new Actor()
            {
                FirstName = "Hugh",
                LastName = "Jackman",
                Nationality = "Australian"
            };

            return View(actor);
        }
    }
}