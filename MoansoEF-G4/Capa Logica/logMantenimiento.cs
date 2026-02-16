using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logMantenimiento
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logMantenimiento _instancia = new logMantenimiento();
        // Privado para evitar la instanciación directa
        public static logMantenimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion Singleton
        public List<entMantenimiento> ListaMantenimientos()
        {
            return datMantenimiento.Instancia.ListaMantenimientos();
        }
        ///inserta
        public void InsertarMantenimiento(entMantenimiento Mant)
        {
            datMantenimiento.Instancia.InsertarMantenimiento(Mant);
        }
    }
}