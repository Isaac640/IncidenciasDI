using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Personal
    {
        public int id {  get; set; }
        public char dni {  get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public char cp {  get; set; }
        public char tlf { get; set; }
        public bool activo { get; set; }
        public int departamento_id { get; set; }
    }
}
