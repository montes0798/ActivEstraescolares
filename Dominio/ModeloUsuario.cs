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
    public class ModeloUsuario
    {
        AccesoDatosUsuario usuarioDatos = new AccesoDatosUsuario();

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuarioDatos.Login(usuario, pass);
        }

        public string recuperarContrasena(string usuario)
        {
            return usuarioDatos.recuperarContrasena(usuario);
        }

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDatos.Mostrar();
            return tabla;
        }

        public DataTable ListaGenero()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDatos.ListarGenero();
            return tabla;
        }

        public DataTable ListaPuesto()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDatos.ListarPuestos();
            return tabla;
        }

        public void InsertarUsuarios(int matricula, string username, string contrasena, string nombre, string aPat, 
                                     string aMat, int genero, DateTime nacimiento, string tel, string email, int puesto)
        {
            usuarioDatos.Insertar(matricula, username, contrasena, nombre, aPat, aMat, genero, nacimiento, tel, email, puesto);
        }

        public void ModificarUsuarios(int matricula, string username, string contrasena, string nombre, string aPat,
                                     string aMat, int genero, DateTime nacimiento, string tel, string email, int puesto)
        {
            usuarioDatos.Editar(matricula, username, contrasena, nombre, aPat, aMat, genero, nacimiento, tel, email, puesto);
        }
    }
}
