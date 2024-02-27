using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Departamentos
    {
        public long id {  get; set; }
        public string cod {  get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public long jefedep_id { get; set; }
    }
}
