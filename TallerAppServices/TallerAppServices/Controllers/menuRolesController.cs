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
    public class menuRolesController : Controller
    {
        private inv001Entities db = new inv001Entities();

        // GET: menuRoles
        public async Task<ActionResult> Index()
        {
            var menuRoles = db.menuRoles.Include(m => m.menu).Include(m => m.roles);
            return View(await menuRoles.ToListAsync());
        }

        // GET: menuRoles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menuRoles menuRoles = await db.menuRoles.FindAsync(id);
            if (menuRoles == null)
            {
                return HttpNotFound();
            }
            return View(menuRoles);
        }

        // GET: menuRoles/Create
        public ActionResult Create()
        {
            ViewBag.idMenu = new SelectList(db.menu, "idMenu", "metodo");
            ViewBag.idRole = new SelectList(db.roles, "idRole", "nombreRole");
            return View();
        }

        // POST: menuRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idMenuRole,idRole,idMenu")] menuRoles menuRoles)
        {
            if (ModelState.IsValid)
            {
                db.menuRoles.Add(menuRoles);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idMenu = new SelectList(db.menu, "idMenu", "metodo", menuRoles.idMenu);
            ViewBag.idRole = new SelectList(db.roles, "idRole", "nombreRole", menuRoles.idRole);
            return View(menuRoles);
        }

        // GET: menuRoles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menuRoles menuRoles = await db.menuRoles.FindAsync(id);
            if (menuRoles == null)
            {
                return HttpNotFound();
            }
            ViewBag.idMenu = new SelectList(db.menu, "idMenu", "metodo", menuRoles.idMenu);
            ViewBag.idRole = new SelectList(db.roles, "idRole", "nombreRole", menuRoles.idRole);
            return View(menuRoles);
        }

        // POST: menuRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idMenuRole,idRole,idMenu")] menuRoles menuRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuRoles).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idMenu = new SelectList(db.menu, "idMenu", "metodo", menuRoles.idMenu);
            ViewBag.idRole = new SelectList(db.roles, "idRole", "nombreRole", menuRoles.idRole);
            return View(menuRoles);
        }

        // GET: menuRoles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menuRoles menuRoles = await db.menuRoles.FindAsync(id);
            if (menuRoles == null)
            {
                return HttpNotFound();
            }
            return View(menuRoles);
        }

        // POST: menuRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            menuRoles menuRoles = await db.menuRoles.FindAsync(id);
            db.menuRoles.Remove(menuRoles);
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
