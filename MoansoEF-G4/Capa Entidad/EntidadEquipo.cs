using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EntidadEquipo
    {
        public int EquipoID { get; set; }
        public int AreaID { get; set; }
        public int TipoequipoID { get; set; }
        public int EstadoequipoID { get; set; }
        public string NombreEquipo { get; set; }
        public DateTime FechaRegistroEquipo { get; set; }
    }
}
