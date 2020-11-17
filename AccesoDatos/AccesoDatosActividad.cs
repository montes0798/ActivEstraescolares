using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AccesoDatosActividad : ConexionSql
    {
        DataTable tabla = new DataTable();

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
                    comando.CommandText = "select IdActividad as 'ID Actividad', NombreActividad as 'Nombre' from Actividad";
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public void Insertar(int id, string nombre)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Actividad values(@id, @nombre);";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int id, string nombre)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "update Usuario set NombreActividad=@nombre where IdActividad=@id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}
