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
    public class Yakuza_HierarchyController : Controller
    {
        private YakuzaDbContext db = new YakuzaDbContext();

        // GET: Yakuza_Hierarchy
        public ActionResult Index()
        {
            var yakuzaHierarchies = db.YakuzaHierarchies.Include(y => y.Parent_Yakuza_Hierarchy).Include(y => y.Yakuza);
            return View(yakuzaHierarchies.ToList());
        }

        // GET: Yakuza_Hierarchy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Create
        public ActionResult Create()
        {
            ViewBag.ParentEntryId = new SelectList(db.YakuzaHierarchies, "EntryId", "EnglishEntryName");
            ViewBag.YakuzaId = new SelectList(db.Yakuzas, "YakuzaId", "Origin");
            return View();
        }

        // POST: Yakuza_Hierarchy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntryId,LevelNumber,EnglishEntryName,JapaneseEntryName,YakuzaId,ParentEntryId")] Yakuza_Hierarchy yakuza_Hierarchy)
        {
            if (ModelState.IsValid)
            {
                db.YakuzaHierarchies.Add(yakuza_Hierarchy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParentEntryId = new SelectList(db.YakuzaHierarchies, "EntryId", "EnglishEntryName", yakuza_Hierarchy.ParentEntryId);
            ViewBag.YakuzaId = new SelectList(db.Yakuzas, "YakuzaId", "Origin", yakuza_Hierarchy.YakuzaId);
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentEntryId = new SelectList(db.YakuzaHierarchies, "EntryId", "EnglishEntryName", yakuza_Hierarchy.ParentEntryId);
            ViewBag.YakuzaId = new SelectList(db.Yakuzas, "YakuzaId", "Origin", yakuza_Hierarchy.YakuzaId);
            return View(yakuza_Hierarchy);
        }

        // POST: Yakuza_Hierarchy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntryId,LevelNumber,EnglishEntryName,JapaneseEntryName,YakuzaId,ParentEntryId")] Yakuza_Hierarchy yakuza_Hierarchy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yakuza_Hierarchy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParentEntryId = new SelectList(db.YakuzaHierarchies, "EntryId", "EnglishEntryName", yakuza_Hierarchy.ParentEntryId);
            ViewBag.YakuzaId = new SelectList(db.Yakuzas, "YakuzaId", "Origin", yakuza_Hierarchy.YakuzaId);
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            return View(yakuza_Hierarchy);
        }

        // POST: Yakuza_Hierarchy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            db.YakuzaHierarchies.Remove(yakuza_Hierarchy);
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
