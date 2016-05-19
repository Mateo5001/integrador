using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrLibrary.objects
{
    public class Cuenta
    {
        private int idCuenta;
        private int idUsuario;
        private string cuentaNom;
        private string password;

        public int IdCuenta
        {
            get
            {
                return idCuenta;
            }

            set
            {
                idCuenta = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string CuentaNom
        {
            get
            {
                return cuentaNom;
            }

            set
            {
                cuentaNom = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
