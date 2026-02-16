using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Datos
{
    public class datMantenimiento
    {
        private static readonly datMantenimiento _instancia = new datMantenimiento();
        //privado para evitar la instanciación directa
        public static datMantenimiento Instancia
        {
            get
            {
                return datMantenimiento._instancia;
            }
        }


        public List<entMantenimiento> ListaMantenimientos()
        {
            List<entMantenimiento> lista = new List<entMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("spListaMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMantenimiento mantenimiento = new entMantenimiento();
                    mantenimiento.MantenimientoID = Convert.ToInt32(dr["MantenimientoID"]);
                    mantenimiento.EquipoID = Convert.ToInt32(dr["EquipoID"]);
                    mantenimiento.EstadoID = Convert.ToInt32(dr["EstadoID"]);
                    mantenimiento.PrioridadID = Convert.ToInt32(dr["PrioridadID"]);
                    mantenimiento.TipoMantenimientoID = Convert.ToInt32(dr["TipoMantenimientoID"]);
                    mantenimiento.TecnicoID = Convert.ToInt32(dr["TecnicoID"]);

                    lista.Add(mantenimiento);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        /////////////////////////InsertaMantenimiento
        public Boolean InsertarMantenimiento(entMantenimiento Mant)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MantenimientoID", Mant.MantenimientoID);
                cmd.Parameters.AddWithValue("@EquipoID", Mant.EquipoID);
                cmd.Parameters.AddWithValue("@EstadoID", Mant.EstadoID);
                cmd.Parameters.AddWithValue("@PrioridadID", Mant.PrioridadID);
                cmd.Parameters.AddWithValue("@TipoMantenimientoID", Mant.TipoMantenimientoID);
                cmd.Parameters.AddWithValue("@TecnicoID", Mant.TecnicoID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}
