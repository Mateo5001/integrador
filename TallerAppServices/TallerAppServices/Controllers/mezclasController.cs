using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class mezclasController : Controller
    {
        private inv001Entities db = new inv001Entities();
        // GET: mezclas
        public ActionResult Colores()
        {
            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor");
            ViewBag.idTinta = new SelectList(db.tintas, "idTinta", "nombreTinta");
            return View();
        }

        public ActionResult listarColores()
        {
            ViewBag.idColor = new SelectList(db.colores, "idColor", "nombreColor");
            return View();
        }
    }
}