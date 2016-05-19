using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TallerAppServices.Models;
using IntrLibrary.seguridad;

namespace TallerAppServices.Controllers
{
    public class cuentasController : Controller
    {
        private inv001Entities db = new inv001Entities();
        private CriptoUtil cif = new CriptoUtil();
        // GET: cuentas
        public ActionResult Index()
        {
            var cuentas = db.cuentas.Include(c => c.usuarios);
            return View(cuentas.ToList());
        }

        // GET: cuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuentas cuentas = db.cuentas.Find(id);
            if (cuentas == null)
            {
                return HttpNotFound();
            }
            return View(cuentas);
        }

        // GET: cuentas/Create
        public ActionResult Create()
        {
            ViewBag.idusuario = new SelectList(db.usuarios, "idUsuario", "identificacion");
            return View();
        }

        // POST: cuentas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCuenta,idusuario,Usuario,pass")] cuentas cuentas)
        {
            if (ModelState.IsValid)
            {
                cuentas.pass = cif.Encrit(cuentas.pass);
                db.cuentas.Add(cuentas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idusuario = new SelectList(db.usuarios, "idUsuario", "identificacion", cuentas.idusuario);
            return View(cuentas);
        }

        // GET: cuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuentas cuentas = db.cuentas.Find(id);
            if (cuentas == null)
            {
                return HttpNotFound();
            }
            ViewBag.idusuario = new SelectList(db.usuarios, "idUsuario", "identificacion", cuentas.idusuario);
            return View(cuentas);
        }

        // POST: cuentas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCuenta,idusuario,Usuario,pass")] cuentas cuentas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuentas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idusuario = new SelectList(db.usuarios, "idUsuario", "identificacion", cuentas.idusuario);
            return View(cuentas);
        }

        // GET: cuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cuentas cuentas = db.cuentas.Find(id);
            if (cuentas == null)
            {
                return HttpNotFound();
            }
            return View(cuentas);
        }

        // POST: cuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cuentas cuentas = db.cuentas.Find(id);
            db.cuentas.Remove(cuentas);
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
