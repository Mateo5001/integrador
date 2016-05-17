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
    public class ubicacionesDetallesController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: ubicacionesDetalles
        public ActionResult Index()
        {
            var ubicacionesDetalle = db.ubicacionesDetalle.Include(u => u.ubicaciones);
            return View(ubicacionesDetalle.ToList());
        }

        // GET: ubicacionesDetalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicacionesDetalle ubicacionesDetalle = db.ubicacionesDetalle.Find(id);
            if (ubicacionesDetalle == null)
            {
                return HttpNotFound();
            }
            return View(ubicacionesDetalle);
        }

        // GET: ubicacionesDetalles/Create
        public ActionResult Create()
        {
            ViewBag.idubicacion = new SelectList(db.ubicaciones, "idubicacion", "desUbicacion");
            return View();
        }

        // POST: ubicacionesDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idUbicacionDetalle,idubicacion,desDetalle")] ubicacionesDetalle ubicacionesDetalle)
        {
            if (ModelState.IsValid)
            {
                db.ubicacionesDetalle.Add(ubicacionesDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idubicacion = new SelectList(db.ubicaciones, "idubicacion", "desUbicacion", ubicacionesDetalle.idubicacion);
            return View(ubicacionesDetalle);
        }

        // GET: ubicacionesDetalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicacionesDetalle ubicacionesDetalle = db.ubicacionesDetalle.Find(id);
            if (ubicacionesDetalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.idubicacion = new SelectList(db.ubicaciones, "idubicacion", "desUbicacion", ubicacionesDetalle.idubicacion);
            return View(ubicacionesDetalle);
        }

        // POST: ubicacionesDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idUbicacionDetalle,idubicacion,desDetalle")] ubicacionesDetalle ubicacionesDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ubicacionesDetalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idubicacion = new SelectList(db.ubicaciones, "idubicacion", "desUbicacion", ubicacionesDetalle.idubicacion);
            return View(ubicacionesDetalle);
        }

        // GET: ubicacionesDetalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ubicacionesDetalle ubicacionesDetalle = db.ubicacionesDetalle.Find(id);
            if (ubicacionesDetalle == null)
            {
                return HttpNotFound();
            }
            return View(ubicacionesDetalle);
        }

        // POST: ubicacionesDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ubicacionesDetalle ubicacionesDetalle = db.ubicacionesDetalle.Find(id);
            db.ubicacionesDetalle.Remove(ubicacionesDetalle);
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
