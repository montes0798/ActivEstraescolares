using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConexionSql
    {
        private readonly string conexionSql;

        public ConexionSql()
        {
            conexionSql = "Server=MONTES\\SQLEXPRESS; DataBase=ActExtraesc; Integrated security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionSql);
        }
    }
}
