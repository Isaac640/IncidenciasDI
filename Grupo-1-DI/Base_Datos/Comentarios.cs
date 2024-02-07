using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Comentarios
    {
        public int id {  get; set; }
        public string texto { get; set; }
        public DateTime fechahora {  get; set; }
        public int incidencia_num {  get; set; }
        public int personal_id { get; set; }
        public string adjunto_url { get; set; }
    }
}
