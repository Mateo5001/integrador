using IntrLibrary.DataModels;
using IntrLibrary.objects;
using System;
using System.Collections.Generic;
using System.Linq;
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
                             Controlador = me.controladora,
                             Metodo=me.metodo
                          }
                         ).DefaultIfEmpty().ToList<Menu>();
            }


            return lista;
        }
    }
}
