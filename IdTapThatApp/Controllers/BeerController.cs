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
    public class BeerController : Controller
    {

            private BeerDbContext _db = new BeerDbContext();
            // GET: Beer
            public ActionResult Index()
            {
                return View(_db.Beers.ToList());
            }

            //GET: Beer/Create
            public ActionResult Create()
            {
                return View();
            }

            //POST Beer/Create
            [HttpPost]
            [ValidateAntiForgeryToken]

            public ActionResult Create(Beer beer)
            {
                if (ModelState.IsValid)
                {
                    _db.Beers.Add(beer);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(beer);

            }

            //GET: Beer/Delete/{id}
            public ActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                Beer beer = _db.Beers.Find(id);
                if (beer == null)
                {
                    return HttpNotFound();
                }
                return View(beer);
            }

            //POST: Beer/Delete/{id}
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]

            public ActionResult Delete(int id)
            {
                Beer beer = _db.Beers.Find(id);
                _db.Beers.Remove(beer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            //GET: Beer/Edit {id}

            public ActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Beer beer = _db.Beers.Find(id);
                if (beer == null)
                {
                    return HttpNotFound();
                }

                return View(beer);
            }

            //POST: Beer/Edit{id}
            [HttpPost]
            [ValidateAntiForgeryToken]

            public ActionResult Edit(Beer beer)
            {
                if (ModelState.IsValid)
                {
                    _db.Entry(beer).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(beer);
            }

            //GET Beer/Details/{id}
            public ActionResult Details(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Beer beer = _db.Beers.Find(id);
                if (beer == null)
                {
                    return HttpNotFound();
                }
                return View(beer);
            }

        
    }
}
