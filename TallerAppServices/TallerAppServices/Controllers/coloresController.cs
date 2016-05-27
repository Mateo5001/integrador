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
    public class coloresController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: colores
        public async Task<ActionResult> Index()
        {
            var colores = db.colores.Include(c => c.usuarios);
            return View(await colores.ToListAsync());
        }

        // GET: colores/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colores colores = await db.colores.FindAsync(id);
            if (colores == null)
            {
                return HttpNotFound();
            }
            return View(colores);
        }

        // GET: colores/Create
        public ActionResult Create()
        {
            ViewBag.idUsuarioRegistra = new SelectList(db.usuarios, "idUsuario", "identificacion");
            return View();
        }

        // POST: colores/Guardar
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        public int Guardar([Bind(Include = "idColor,nombreColor,codigoColor,idUsuarioRegistra,fechaRegistro,inactivo")] colores colores)
        {
            if (ModelState.IsValid)
            {
                db.colores.Add(colores);
                db.SaveChanges();
                return colores.idColor;
            }
            
            return 0;
        }
        


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idColor,nombreColor,codigoColor,idUsuarioRegistra,fechaRegistro,inactivo")] colores colores)
        {
            if (ModelState.IsValid)
            {
                db.colores.Add(colores);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idUsuarioRegistra = new SelectList(db.usuarios, "idUsuario", "identificacion", colores.idUsuarioRegistra);
            return View(colores);
        }

        // GET: colores/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colores colores = await db.colores.FindAsync(id);
            if (colores == null)
            {
                return HttpNotFound();
            }
            ViewBag.idUsuarioRegistra = new SelectList(db.usuarios, "idUsuario", "identificacion", colores.idUsuarioRegistra);
            return View(colores);
        }

        // POST: colores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idColor,nombreColor,codigoColor,idUsuarioRegistra,fechaRegistro,inactivo")] colores colores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colores).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idUsuarioRegistra = new SelectList(db.usuarios, "idUsuario", "identificacion", colores.idUsuarioRegistra);
            return View(colores);
        }

        // GET: colores/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colores colores = await db.colores.FindAsync(id);
            if (colores == null)
            {
                return HttpNotFound();
            }
            return View(colores);
        }

        // POST: colores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            colores colores = await db.colores.FindAsync(id);
            db.colores.Remove(colores);
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
