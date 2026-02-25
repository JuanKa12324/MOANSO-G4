using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EntidadPlanMantenimiento
    {
        public int EquipoID { get; set; }
        public int EstadoplanmantID { get; set; }
        public int FrecuenciaID { get; set; }
        public DateTime FechaInicio { get; set; }
        public int PrioridadID { get; set; }
        public string DescripcionPlan { get; set; }
    }
}
