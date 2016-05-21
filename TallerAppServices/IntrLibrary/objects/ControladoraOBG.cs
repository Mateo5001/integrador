using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrLibrary.objects
{
    public class ControladoraOBG
    {
        int idControladora;
        string path;
        string nombreControladora;
        string Descripcion;
        List<Metodo> metodos;

        public int IdControladora
        {
            get
            {
                return idControladora;
            }

            set
            {
                idControladora = value;
            }
        }

        public string NombreControladora
        {
            get
            {
                return nombreControladora;
            }

            set
            {
                nombreControladora = value;
            }
        }

        public string Descripcion1
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

        public List<Metodo> Metodos
        {
            get
            {
                return metodos;
            }

            set
            {
                metodos = value;
            }
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }
    }
}
