using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    internal class EntRegistroMantenimiento
    {
        public int PlanMantenimientoID { get; set; }
        public int TipoMantenimientoID { get; set; }

        public int EquipoID { get; set; }

        public int Descripcion { get; set; }

        public string Estado { get; set; }

        public string FechaRealizacion { get; set; }

        public string RecursosUtilizadosID { get; set; }

        public int Cantidad { get; set; }

,
    }
}
