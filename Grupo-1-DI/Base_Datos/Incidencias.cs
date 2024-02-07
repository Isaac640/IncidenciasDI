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
        public int num { get; set; }
        public Tipo tipo { get; set; }
        public int subtipo_id { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_cierre { get; set; }
        public string descripcion { get; set; }
        public Estado estado { get; set; }
        public string adjunto_url { get; set; }
        public int creador_id { get; set; }
        public int responsable_id { get; set; }
        public int equipo_id { get; set; }
    }
}
