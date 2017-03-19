using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AttendsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Attends
        public ActionResult Index()
        {
            var attends = db.Attends.Include(a => a.Student);
            return View(attends.ToList());
        }

        // GET: Attends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attend attend = db.Attends.Find(id);
            if (attend == null)
            {
                return HttpNotFound();
            }
            return View(attend);
        }

        // GET: Attends/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name");
            return View();
        }

        // POST: Attends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,Date,Present")] Attend attend)
        {
            if (ModelState.IsValid)
            {
                db.Attends.Add(attend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name", attend.StudentId);
            return View(attend);
        }

        // GET: Attends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attend attend = db.Attends.Find(id);
            if (attend == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name", attend.StudentId);
            return View(attend);
        }

        // POST: Attends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,Date,Present")] Attend attend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name", attend.StudentId);
            return View(attend);
        }

        // GET: Attends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attend attend = db.Attends.Find(id);
            if (attend == null)
            {
                return HttpNotFound();
            }
            return View(attend);
        }

        // POST: Attends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Attend attend = db.Attends.Find(id);
            db.Attends.Remove(attend);
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
