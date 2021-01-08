using IdTapThat.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IdTapThatApp.Controllers
{
    public class BreweryController : Controller
    {
        private BreweryDbContext _db = new BreweryDbContext();
        // GET: Brewery
        public ActionResult Index()
        {
            return View(_db.Breweries.ToList());
        }

        //GET: Brewery/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST Brewery/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Brewery brewery)
        {
            if (ModelState.IsValid)
            {
                _db.Breweries.Add(brewery);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brewery);

        }

        //GET: Brewery/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Brewery brewery = _db.Breweries.Find(id);
            if (brewery == null)
            {
                return HttpNotFound();
            }
            return View(brewery);
        }

        //POST: Brewery/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id)
        {
            Brewery brewery = _db.Breweries.Find(id);
            _db.Breweries.Remove(brewery);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brewery brewery = _db.Breweries.Find(id);
            if (brewery == null)
            {
                return HttpNotFound();
            }

            return View(brewery);
        }


        //POST: Brewery/Edit{id}
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Brewery brewery)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(brewery).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brewery);
        }

        //GET Brewery/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brewery brewery = _db.Breweries.Find(id);
            if (brewery == null)
            {
                return HttpNotFound();
            }
            return View(brewery);
        }
    }
}
