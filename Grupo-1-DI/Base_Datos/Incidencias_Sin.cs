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
    public class Incidencias_Sin
    {
        public long num { get; set; }
        public Tipo tipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_cierre { get; set; }
        public long? equipo_id { get; set; }
        public long creador_id { get; set; }
        public long? responsable_id { get; set; }
        public long subtipo_id { get; set; }
        public string adjunto_url { get; set; }
        public int? tiempo { get; set; }
    }
}
