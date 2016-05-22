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
    public class ControladorasController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: Controladoras
        public ActionResult Index()
        {
            return View(db.Controladoras.ToList());
        }

        // GET: Controladoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Controladoras controladoras = db.Controladoras.Find(id);
            if (controladoras == null)
            {
                return HttpNotFound();
            }
            return View(controladoras);
        }

        // GET: Controladoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controladoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idControladora,Path,NombreControladora,descripcionControladora")] Controladoras controladoras)
        {
            if (ModelState.IsValid)
            {
                db.Controladoras.Add(controladoras);
                db.SaveChanges();
                return RedirectToAction("creacionMenus", "Configuracion");
            }

            return RedirectToAction("creacionMenus", "Configuracion");
        }

        // GET: Controladoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Controladoras controladoras = db.Controladoras.Find(id);
            if (controladoras == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("creacionMenus", "Configuracion");
        }

        // POST: Controladoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idControladora,Path,NombreControladora,descripcionControladora")] Controladoras controladoras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(controladoras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("creacionMenus", "Configuracion");
            }
            return RedirectToAction("creacionMenus", "Configuracion");
        }

        // GET: Controladoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Controladoras controladoras = db.Controladoras.Find(id);
            if (controladoras == null)
            {
                return HttpNotFound();
            }
            return View(controladoras);
        }

        // POST: Controladoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Controladoras controladoras = db.Controladoras.Find(id);
            db.Controladoras.Remove(controladoras);
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
