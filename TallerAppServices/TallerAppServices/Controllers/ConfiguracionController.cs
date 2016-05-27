using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class ConfiguracionController :  tiposDocumentosController
    {
        // GET: Configuracion
        private inv001Entities db = new inv001Entities();

        public ActionResult confRoles()
        {
            ViewBag.idMenu = new SelectList(db.menu, "idMenu", "metodo");
            ViewBag.idRole = new SelectList(db.roles, "idRole", "nombreRole");
            return View();
        }

        public ActionResult  creTD(int guardado =3)
        {

            ViewBag.AlertaGuardad = guardado;
            return View();
        }
        public ActionResult creacionMenus()
        {
            ViewBag.idControladora = new SelectList(db.Controladoras, "idControladora", "Path");
            return View();
        }
    }
}