using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class ubicacionesController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: ubicaciones
        public ActionResult Index()
        {
            return View(db.ubicaciones.ToList());
        }

        // GET: ubicaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicaciones ubicaciones = db.ubicaciones.Find(id);
            if (ubicaciones == null)
            {
                return HttpNotFound();
            }
            return View(ubicaciones);
        }

        // GET: ubicaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ubicaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idubicacion,desUbicacion,codigo")] ubicaciones ubicaciones)
        {
            if (ModelState.IsValid)
            {
                db.ubicaciones.Add(ubicaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ubicaciones);
        }

        // GET: ubicaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicaciones ubicaciones = db.ubicaciones.Find(id);
            if (ubicaciones == null)
            {
                return HttpNotFound();
            }
            return View(ubicaciones);
        }

        // POST: ubicaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idubicacion,desUbicacion,codigo")] ubicaciones ubicaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ubicaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ubicaciones);
        }

        // GET: ubicaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicaciones ubicaciones = db.ubicaciones.Find(id);
            if (ubicaciones == null)
            {
                return HttpNotFound();
            }
            return View(ubicaciones);
        }

        // POST: ubicaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ubicaciones ubicaciones = db.ubicaciones.Find(id);
            db.ubicaciones.Remove(ubicaciones);
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
