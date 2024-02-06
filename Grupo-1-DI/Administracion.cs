using Grupo_3_Intermodular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_1_DI
{
    /// <summary>
    /// Obtención de datos de API
    /// </summary>
    public class Administracion
    {
        private static int userId;
        private static WebConsumer consumer;
    
        static Administracion()
        {
            consumer = new WebConsumer("http://IP:PORT");
        }

        //METODOS DE OBTENCION DE DATOS POR API


    }
}
