using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Transversal.Cache;

namespace AccesoDatos
{
    public class AccesoDatosUsuario:ConexionSql
    {
        DataTable tabla = new DataTable();
        public bool Login(string username, string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando= new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuario where NombreUsuario=@user and Contrasena=@pass";
                    comando.Parameters.AddWithValue("@user", username);
                    comando.Parameters.AddWithValue("@pass", pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheInicioSesion.username = reader.GetString(1);
                            CacheInicioSesion.password = reader.GetString(2);
                            CacheInicioSesion.name = reader.GetString(3);
                            CacheInicioSesion.apellidoPat = reader.GetString(4);
                            CacheInicioSesion.apellidoMat = reader.GetString(5);
                            CacheInicioSesion.genero = reader.GetInt32(6);
                            CacheInicioSesion.telefono = reader.GetString(8);
                            CacheInicioSesion.eMail = reader.GetString(9);
                            CacheInicioSesion.tipoUsuario = reader.GetInt32(10);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        //Metodo para recuperar contraseña olvidada
        public string recuperarContrasena(string usuario)
        {
            //Se obtiene la conexion a la BD
            using(var conexion = GetConnection())
            {
                //Se abre la conexion
                conexion.Open();
                //Instanciamos a la clase SqlComando para realizar las acciones en la BD
                using(var comando = new SqlCommand())
                {
                    //Especificamos la conexion
                    comando.Connection = conexion;
                    //El usuario puede solicitar reestablecer la contraseña usando su nombre de usuario o correo
                    comando.CommandText = "select * from Usuario where CorreoElectronico=@mail";
                    comando.Parameters.AddWithValue("@mail", usuario);
                    comando.CommandType = CommandType.Text;
                    //Declaramos un lector para la BD
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        //Obtenemos los datos del usuario
                        string nombre = reader.GetString(3) + " " + reader.GetString(4);
                        string correo = reader.GetString(9);
                        string password = reader.GetString(2);

                        //Instanciamos la clase SistemaSoporteCorreo
                        var servicioCorreo = new SoporteCorreo();
                        servicioCorreo.enviarCorreo(
                            asunto: "SISTEMA: Solicitud de recuperación de contraseña",
                            cuerpo: "Hola, " + nombre + ".\nSolicitaste recuperar tu contraseña, en caso de no haberlo hecho ignorar este mensaje"
                                    + "\nLa contraseña es: " + password
                                    + "\nPor cuestiones de seguridad se recomienda cambiar la contraseña una vez ingrese al sistema.",
                            destinatario: new List<string> { correo }
                        );
                        return "Hola, " + nombre + ".\nSolicitaste recuperar tu contraseña.\n" +
                                "Por favor, revise su correo: " + correo;
                    }
                    else
                    {
                        return "Lo sentimos, no existe este usuario o correo electronico en el sistema";
                    }
                }
            }
        }

        //CRUD Usuarios
        //Mostrar datos
        public DataTable Mostrar()
        {
            //Se obtiene la conexion a la BD
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    //Especificamos la conexion
                    comando.Connection = conexion;
                    comando.CommandText = "select MatriculaEmpleado as 'Matricula', NombreUsuario as 'Usuario', Nombre, APaterno as 'Apellido Paterno', AMaterno as 'Apellido Materno', " +
                        "Genero.Genero, FechaNacimiento as 'Fecha Nacimiento', Telefono, CorreoElectronico as 'Email', TipoUsuario.NombreTipoUsuario as 'Puesto' " +
                        "from Usuario, Genero, TipoUsuario " +
                        "where Genero.IdGenero = Usuario.IdGenero and TipoUsuario.IdTipoUsuario=Usuario.IdTipoUsuario " +
                        "order by TipoUsuario.NombreTipoUsuario;";
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public DataTable ListarGenero()
        {
            DataTable table = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Genero";
                    SqlDataReader reader = comando.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public DataTable ListarPuestos()
        {
            DataTable table = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from TipoUsuario";
                    SqlDataReader reader = comando.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public void Insertar(int matricula, string username, string contrasena, string nombre, string aPat, string aMat, int genero,
                             DateTime nacimiento, string tel, string email, int puesto)
        {
            using(var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Usuario values(@mat, @user, @contrasena, @nombre, @paterno, @materno," +
                                          "@genero, @fechaNac, @tel, @email, @puesto);";
                    comando.Parameters.AddWithValue("@mat", matricula);
                    comando.Parameters.AddWithValue("@user", username);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@paterno", aPat);
                    comando.Parameters.AddWithValue("@materno", aMat);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.Parameters.AddWithValue("@fechaNac", nacimiento);
                    comando.Parameters.AddWithValue("@tel", tel);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@puesto", puesto);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int matricula, string username, string contrasena, string nombre, string aPat, string aMat, 
                           int genero, DateTime nacimiento, string tel, string email, int puesto)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "update Usuario set NombreUsuario=@user, Contrasena=@contrasena, " +
                                         "Nombre=@nombre, Apaterno=@paterno, Amaterno=@materno, IdGenero=@genero, " +
                                         "FechaNacimiento=@fechaNac, Telefono=@tel, CorreoElectronico=@email, " +
                                         "IdTipoUsuario=@puesto where MatriculaEmpleado=@mat";
                    comando.Parameters.AddWithValue("@mat", matricula);
                    comando.Parameters.AddWithValue("@user", username);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@paterno", aPat);
                    comando.Parameters.AddWithValue("@materno", aMat);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.Parameters.AddWithValue("@fechaNac", nacimiento);
                    comando.Parameters.AddWithValue("@tel", tel);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@puesto", puesto);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}
