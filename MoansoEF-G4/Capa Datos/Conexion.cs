using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Conexion
    {   //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MANTENIMIENTODB;Data Source=JUAN\\SQLEXPRESS";

            return cn;
        }
    }
}
