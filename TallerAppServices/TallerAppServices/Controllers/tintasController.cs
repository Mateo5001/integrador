using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class tintasController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: tintas
        public async Task<ActionResult> Index()
        {
            var tintas = db.tintas.Include(t => t.lineas).Include(t => t.usuarios);
            return View(await tintas.ToListAsync());
        }

        // GET: tintas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tintas tintas = await db.tintas.FindAsync(id);
            if (tintas == null)
            {
                return HttpNotFound();
            }
            return View(tintas);
        }

        // GET: tintas/Create
        public ActionResult Create()
        {
            ViewBag.idLinea = new SelectList(db.lineas, "idLinea", "nombreLinea");
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion");
            return View();
        }

        // POST: tintas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idTinta,nombreTinta,codigoTinta,idLinea,idUsuarioCreacion,fechaCreacion,inactivo")] tintas tintas)
        {
            if (ModelState.IsValid)
            {
                db.tintas.Add(tintas);
                await db.SaveChangesAsync();
                return RedirectToAction("Tintas","Elementos");
            }

            ViewBag.idLinea = new SelectList(db.lineas, "idLinea", "nombreLinea", tintas.idLinea);
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", tintas.idUsuarioCreacion);
            return View(tintas);
        }

        // GET: tintas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tintas tintas = await db.tintas.FindAsync(id);
            if (tintas == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLinea = new SelectList(db.lineas, "idLinea", "nombreLinea", tintas.idLinea);
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", tintas.idUsuarioCreacion);
            return View(tintas);
        }

        // POST: tintas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idTinta,nombreTinta,codigoTinta,idLinea,idUsuarioCreacion,fechaCreacion,inactivo")] tintas tintas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tintas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Tintas", "Elementos");
            }
            ViewBag.idLinea = new SelectList(db.lineas, "idLinea", "nombreLinea", tintas.idLinea);
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", tintas.idUsuarioCreacion);
            return View(tintas);
        }

        // GET: tintas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tintas tintas = await db.tintas.FindAsync(id);
            if (tintas == null)
            {
                return HttpNotFound();
            }
            return View(tintas);
        }

        // POST: tintas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tintas tintas = await db.tintas.FindAsync(id);
            db.tintas.Remove(tintas);
            await db.SaveChangesAsync();
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
