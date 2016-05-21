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
        int controlador;
        string metodo;
        ControladoraOBG contr;

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

        public int Controlador
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

        public ControladoraOBG Contr
        {
            get
            {
                return contr;
            }

            set
            {
                contr = value;
            }
        }
    }
}
