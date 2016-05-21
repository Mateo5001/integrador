using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrLibrary.objects
{
    public class Menu
    {
        int idMenu;
        string controlador;
        string metodo;

        public int IdMenu
        {
            get
            {
                return idMenu;
            }

            set
            {
                idMenu = value;
            }
        }

        public string Controlador
        {
            get
            {
                return controlador;
            }

            set
            {
                controlador = value;
            }
        }

        public string Metodo
        {
            get
            {
                return metodo;
            }

            set
            {
                metodo = value;
            }
        }
    }
}
