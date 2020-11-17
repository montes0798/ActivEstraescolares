using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SoporteCorreo:ServerCorreo
    {
        public SoporteCorreo()
        {
            remitente = "itsactividades.soporte@gmail.com";
            contrasena = "its_2020";
            host = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            iniciarSmtpCliente();
        }
    }
}
