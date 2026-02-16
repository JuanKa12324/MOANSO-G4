using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entMantenimiento
    {
        public int MantenimientoID { get; set; }
        public int EquipoID { get; set; }
        public int EstadoID { get; set; }
        public int PrioridadID { get; set; }
        public int TipoMantenimientoID { get; set; }
        public int TecnicoID { get; set; }
    }
}
