using System.Data.Entity;
using System.Web.Mvc;

namespace AspNetMvc.Database
{
    public class AliensController : Controller
    {
        public ActionResult Index()
        {
            var aliens = _db.Aliens;
            return View(aliens);
        }

        public ActionResult Details(int id)
        {
            var alien = _db.Aliens.Find(id);
            if (alien == null)
            {
                return HttpNotFound();
            }

            return View(alien);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alien alien)
        {
            if (!ModelState.IsValid)
            {
                return View(alien);
            }

            _db.Aliens.Add(alien);
            _db.SaveChanges();

            return RedirectToAction("Details", new { id = alien.Id });
        }

        public ActionResult Edit(int id)
        {
            var alien = _db.Aliens.Find(id);
            if (alien == null)
            {
                return HttpNotFound();
            }

            return View(alien);
        }

        [HttpPost]
        public ActionResult Edit(int id, Alien alien)
        {
            if (!ModelState.IsValid)
            {
                return View(alien);
            }

            alien.Id = id;
            _db.Entry(alien).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Details", new { id = alien.Id });
        }

        public ActionResult Delete(int id)
        {
            var alien = _db.Aliens.Find(id);
            if (alien == null)
            {
                return HttpNotFound();
            }

            return View(alien);
        }

        [HttpPost]
        public ActionResult Delete(int id, string confirmed)
        {
            var alien = _db.Aliens.Find(id);
            if (alien == null)
            {
                return HttpNotFound();
            }

            if (confirmed != null)
            {
                _db.Aliens.Remove(alien);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Details", new { id = alien.Id });
        }

        private AlienContext _db = new AlienContext();
    }
}