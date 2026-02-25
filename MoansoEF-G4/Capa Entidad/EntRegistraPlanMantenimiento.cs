using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    internal class EntRegistraPlanMantenimiento
    {
        public int EquipoID { get; set; }
        public int Especialidad { get; set; }

        public int Tecnico { get; set; }
        public int Frecuencia { get; set; }
        public int FechaInicio { get; set; }
        public int Prioridad { get; set; }

    }
}
