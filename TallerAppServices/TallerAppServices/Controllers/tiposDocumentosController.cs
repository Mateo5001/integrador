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
    public class tiposDocumentosController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: tiposDocumentos
        public ActionResult Index()
        {
            return View(db.tiposDocumentos.ToList());
        }

        // GET: tiposDocumentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposDocumentos tiposDocumentos = db.tiposDocumentos.Find(id);
            if (tiposDocumentos == null)
            {
                return HttpNotFound();
            }
            return View(tiposDocumentos);
        }

        // GET: tiposDocumentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tiposDocumentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipoDocumento,codigoTipoDocumento,nombreTipoDocuemnto")] tiposDocumentos tiposDocumentos)
        {
            if (ModelState.IsValid)
            {
                db.tiposDocumentos.Add(tiposDocumentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tiposDocumentos);
        }

        // GET: tiposDocumentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposDocumentos tiposDocumentos = db.tiposDocumentos.Find(id);
            if (tiposDocumentos == null)
            {
                return HttpNotFound();
            }
            return View(tiposDocumentos);
        }

        // POST: tiposDocumentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipoDocumento,codigoTipoDocumento,nombreTipoDocuemnto")] tiposDocumentos tiposDocumentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposDocumentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposDocumentos);
        }

        // GET: tiposDocumentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tiposDocumentos tiposDocumentos = db.tiposDocumentos.Find(id);
            if (tiposDocumentos == null)
            {
                return HttpNotFound();
            }
            return View(tiposDocumentos);
        }

        // POST: tiposDocumentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tiposDocumentos tiposDocumentos = db.tiposDocumentos.Find(id);
            db.tiposDocumentos.Remove(tiposDocumentos);
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
