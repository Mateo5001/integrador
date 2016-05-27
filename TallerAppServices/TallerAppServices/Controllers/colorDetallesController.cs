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
    public class colorDetallesController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: colorDetalles
        public async Task<ActionResult> Index()
        {
            var colorDetalle = db.colorDetalle.Include(c => c.colores).Include(c => c.tintas);
            return View(await colorDetalle.ToListAsync());
        }

        // GET: colorDetalles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colorDetalle colorDetalle = await db.colorDetalle.FindAsync(id);
            if (colorDetalle == null)
            {
                return HttpNotFound();
            }
            return View(colorDetalle);
        }

        // GET: colorDetalles/Create
        public ActionResult Create()
        {
            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor");
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta");
            return View();
        }

        [HttpPost]
        public int Guardar([Bind(Include = "idColorDetalle,idColor,idTinta,cantidadPorcentaje")] colorDetalle colorDetalle)
        {
            if (ModelState.IsValid)
            {
                db.colorDetalle.Add(colorDetalle);
                db.SaveChanges();
                return colorDetalle.idColorDetalle;
            }

            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor", colorDetalle.idColor);
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta", colorDetalle.idTinta);
            return 0;
        }

        public ActionResult lista(int? id=0)
        {
            
            var colorDetalle =(from colDet in db.colorDetalle where colDet.idColor==id.Value select colDet);
            return View(colorDetalle.ToList());
        }


        // POST: colorDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idColorDetalle,idColor,idTinta,cantidadPorcentaje")] colorDetalle colorDetalle)
        {
            if (ModelState.IsValid)
            {
                db.colorDetalle.Add(colorDetalle);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor", colorDetalle.idColor);
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta", colorDetalle.idTinta);
            return View(colorDetalle);
        }

        // GET: colorDetalles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colorDetalle colorDetalle = await db.colorDetalle.FindAsync(id);
            if (colorDetalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor", colorDetalle.idColor);
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta", colorDetalle.idTinta);
            return View(colorDetalle);
        }

        // POST: colorDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idColorDetalle,idColor,idTinta,cantidadPorcentaje")] colorDetalle colorDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colorDetalle).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor", colorDetalle.idColor);
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta", colorDetalle.idTinta);
            return View(colorDetalle);
        }

        // GET: colorDetalles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            colorDetalle colorDetalle = await db.colorDetalle.FindAsync(id);
            if (colorDetalle == null)
            {
                return HttpNotFound();
            }
            return View(colorDetalle);
        }

        // POST: colorDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            colorDetalle colorDetalle = await db.colorDetalle.FindAsync(id);
            db.colorDetalle.Remove(colorDetalle);
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
