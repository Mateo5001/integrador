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
    public class lineasController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: lineas
        public async Task<ActionResult> Index()
        {
            var lineas = db.lineas.Include(l => l.usuarios);
            return View(await lineas.ToListAsync());
        }

        // GET: lineas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineas lineas = await db.lineas.FindAsync(id);
            if (lineas == null)
            {
                return HttpNotFound();
            }
            return View(lineas);
        }

        // GET: lineas/Create
        public ActionResult Create()
        {
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion");
            return View();
        }

        // POST: lineas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idLinea,nombreLinea,codigoLinea,idUsuarioCreacion,fechaCreacion")] lineas lineas)
        {
            if (ModelState.IsValid)
            {
                db.lineas.Add(lineas);
                await db.SaveChangesAsync();
                return RedirectToAction("lineas","Elementos");
            }

            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", lineas.idUsuarioCreacion);
            return View(lineas);
        }

        // GET: lineas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineas lineas = await db.lineas.FindAsync(id);
            if (lineas == null)
            {
                return HttpNotFound();
            }
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", lineas.idUsuarioCreacion);
            return View(lineas);
        }

        // POST: lineas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idLinea,nombreLinea,codigoLinea,idUsuarioCreacion,fechaCreacion")] lineas lineas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineas).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("lineas", "Elementos");
            }
            ViewBag.idUsuarioCreacion = new SelectList(db.usuarios, "idUsuario", "identificacion", lineas.idUsuarioCreacion);
            return View(lineas);
        }

        // GET: lineas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineas lineas = await db.lineas.FindAsync(id);
            if (lineas == null)
            {
                return HttpNotFound();
            }
            return View(lineas);
        }

        // POST: lineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            lineas lineas = await db.lineas.FindAsync(id);
            db.lineas.Remove(lineas);
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
