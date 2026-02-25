using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EntidadMantenimiento
    {
        public int MantenimientoID { get; set; }
        public int EquipoID { get; set; }
        public int EstadomantenimientoID { get; set; }
        public int TecnicoID { get; set; }
        public int PlanmantenimientoID { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int TipoMantenimientoID { get; set; }
        public int DescripcionMantenimiento { get; set; }

    }
}
