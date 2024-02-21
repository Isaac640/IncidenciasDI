using Grupo_1_DI.Base_Datos;
using Grupo_1_DI.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI
{
    // INCIDENCIAS
    public class Incidencias
    {
        public long num { get; set; }
        public Tipo tipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_cierre { get; set; }
        public Equipos equipo_id { get; set; }
        public Personal creador_id { get; set; }
        public Personal responsable_id { get; set; }
        public Incidencias_Subtipos subtipo_id { get; set; }
        public int? tiempo { get; set; }
    }
}
