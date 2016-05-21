using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrLibrary.objects
{
    public class Metodo
    {
        int idMetodo;
        string path;
        string descripcion;
        string nombre;

        public int IdMetodo
        {
            get
            {
                return idMetodo;
            }

            set
            {
                idMetodo = value;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
