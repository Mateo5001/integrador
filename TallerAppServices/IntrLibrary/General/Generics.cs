using IntrLibrary.DataModels;
using IntrLibrary.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace IntrLibrary.General
{

    public class Generics
    {
        public static List<Menu> listaMenu()
        {
            List<Menu> lista;
            using (ConfiguracionEntity db = new ConfiguracionEntity())
            {
                lista = (from me in db.menu
                         select new Menu()
                         {
                             IdMenu = me.idMenu,
                             Controlador = me.idControladora,
                             Metodo = me.metodo,                             
                             Contr = (from tr in db.Controladoras where tr.idControladora == me.idControladora
                                      select new ControladoraOBG()
                                      {
                                          IdControladora = tr.idControladora,
                                          Descripcion1 = tr.descripcionControladora,
                                          NombreControladora = tr.NombreControladora,
                                          Path = tr.Path,
                                          Metodos = (from met in db.MetodosControladora where met.idControladora == tr.idControladora
                                                     select new Metodo()
                                                     {
                                                         
                                                         IdMetodo = met.idMetodo,
                                                         Descripcion = met.descripcionMetodo,
                                                         Nombre =met.nombreMostrar,
                                                         Path=met.metodo
                                                     }).DefaultIfEmpty().ToList<Metodo>()
                                      }).FirstOrDefault<ControladoraOBG>()
                             
                          }
                         ).DefaultIfEmpty().ToList<Menu>();
            }


            return lista;
        }
    }
}
