using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6_CodeFirst_Yakuza.Models;

namespace EF6_CodeFirst_Yakuza.Controllers
{
    public class YakuzasController : Controller
    {
        private YakuzaDbContext db = new YakuzaDbContext();

        // GET: Yakuzas
        public ActionResult Index()
        {
            return View(db.Yakuzas.ToList());
        }

        // GET: Yakuzas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza yakuza = db.Yakuzas.Find(id);
            if (yakuza == null)
            {
                return HttpNotFound();
            }
            return View(yakuza);
        }

        // GET: Yakuzas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yakuzas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YakuzaId,Origin,Creation,Activities")] Yakuza yakuza)
        {
            if (ModelState.IsValid)
            {
                db.Yakuzas.Add(yakuza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yakuza);
        }

        // GET: Yakuzas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza yakuza = db.Yakuzas.Find(id);
            if (yakuza == null)
            {
                return HttpNotFound();
            }
            return View(yakuza);
        }

        // POST: Yakuzas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YakuzaId,Origin,Creation,Activities")] Yakuza yakuza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yakuza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yakuza);
        }

        // GET: Yakuzas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza yakuza = db.Yakuzas.Find(id);
            if (yakuza == null)
            {
                return HttpNotFound();
            }
            return View(yakuza);
        }

        // POST: Yakuzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yakuza yakuza = db.Yakuzas.Find(id);
            db.Yakuzas.Remove(yakuza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
