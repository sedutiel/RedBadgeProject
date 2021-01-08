using IdTapThat.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace IdTapThatApp.Controllers
{
    public class ReviewController : Controller
    {
        private ReviewDbContext _db = new ReviewDbContext();
        // GET: Reviews
        public ActionResult Index()
        {
            return View(_db.Reviews.ToList());
        }

        //GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(review);

        }

        //GET: Review/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Review review = _db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        //POST: Review/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id)
        {
            Review review = _db.Reviews.Find(id);
            _db.Reviews.Remove(review);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Review/Edit {id}

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Review review = _db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }

            return View(review);
        }

        //POST: Review/Edit{id}
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(review);
        }

        //GET Review/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = _db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }


    }
}
