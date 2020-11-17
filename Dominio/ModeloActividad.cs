using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;


namespace Dominio
{
    public class ModeloActividad
    {
        AccesoDatosActividad actividadDatos = new AccesoDatosActividad();

        public DataTable MostrarActividad()
        {
            DataTable tabla = new DataTable();
            tabla = actividadDatos.Mostrar();
            return tabla;
        }

        public void InsertarActividad(int id, string nombre)
        {
            actividadDatos.Insertar(id, nombre);
        }

        public void ModificarActividad(int id, string nombre)
        {
            actividadDatos.Editar(id, nombre);
        }
    }
}
