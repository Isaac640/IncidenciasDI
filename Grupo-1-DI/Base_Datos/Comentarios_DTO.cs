using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Comentarios_DTO
    {
        public string texto { get; set; }
        public DateTime fechahora { get; set; }
        public long incidencia_num { get; set; }
        public long personal_id { get; set; }
        public string CuerpoBase64 { get; set; }
        public string Extension { get; set; }

    }
}
