using Grupo_1_DI.Enumerados;
 
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{

    public class Equipos
    {
        public int id { get; set; }
        public Tipo_equipo tipo_equipo { get; set; }
        // FORMATEAR CON SOLO LA FECHA AL SUBIR EL EQUIPO
        public DateTime fecha_adquisicion { get; set; }
        public string etiqueta {  get; set; }
        public string marca {  get; set; }
        public string modelo {  get; set; }
        public string descripcion { get; set; }
        public bool baja { get; set; }

    }
}
