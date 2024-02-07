using Grupo_1_DI.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI.Base_Datos
{
    public class Perfiles
    {
        public int personal_id {  get; set; }
        public string dominio {  get; set; }
        public string educantabria { get; set; }
        public char password { get; set; }
        public Perfil perfil { get; set; }
    }
}
