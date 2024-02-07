using Grupo_1_DI.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Incidencias_Subtipos
    {
        public int id { get; set; }
        public Tipo tipo { get; set; }
        public string subtipo_nombre { get; set; }
        public string sub_subtipo { get; set; }
    }
}
