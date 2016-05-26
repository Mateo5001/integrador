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
    public class MetodosControladorasController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: MetodosControladoras
        public async Task<ActionResult> Index()
        {
            var metodosControladora = db.MetodosControladora.Include(m => m.Controladoras);
            return View(await metodosControladora.ToListAsync());
        }

        // GET: MetodosControladoras/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodosControladora metodosControladora = await db.MetodosControladora.FindAsync(id);
            if (metodosControladora == null)
            {
                return HttpNotFound();
            }
            return View(metodosControladora);
        }

        // GET: MetodosControladoras/Create
        public ActionResult Create()
        {
            ViewBag.idControladora = new SelectList(db.Controladoras, "idControladora", "Path");
            return View();
        }

        // POST: MetodosControladoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idMetodo,metodo,descripcionMetodo,nombreMostrar,vista,idControladora")] MetodosControladora metodosControladora)
        {
            if (ModelState.IsValid)
            {
                db.MetodosControladora.Add(metodosControladora);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idControladora = new SelectList(db.Controladoras, "idControladora", "Path", metodosControladora.idControladora);
            return View(metodosControladora);
        }

        // GET: MetodosControladoras/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodosControladora metodosControladora = await db.MetodosControladora.FindAsync(id);
            if (metodosControladora == null)
            {
                return HttpNotFound();
            }
            ViewBag.idControladora = new SelectList(db.Controladoras, "idControladora", "Path", metodosControladora.idControladora);
            return View(metodosControladora);
        }

        // POST: MetodosControladoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idMetodo,metodo,descripcionMetodo,nombreMostrar,vista,idControladora")] MetodosControladora metodosControladora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metodosControladora).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idControladora = new SelectList(db.Controladoras, "idControladora", "Path", metodosControladora.idControladora);
            return View(metodosControladora);
        }

        // GET: MetodosControladoras/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetodosControladora metodosControladora = await db.MetodosControladora.FindAsync(id);
            if (metodosControladora == null)
            {
                return HttpNotFound();
            }
            return View(metodosControladora);
        }

        // POST: MetodosControladoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MetodosControladora metodosControladora = await db.MetodosControladora.FindAsync(id);
            db.MetodosControladora.Remove(metodosControladora);
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
