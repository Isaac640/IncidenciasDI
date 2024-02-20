using Grupo_1_DI.Base_Datos;
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
        private static WebConsumer consumer;

        static Administracion()
        {
            consumer = new WebConsumer("http://localhost:8089");
        }

        // METODOS DE OBTENCION DE DATOS POR API


        // OBTENCION DE TODAS LAS INCIDENCIAS

        public async static Task<List<Incidencias>> ObtenerIncidencias()
        {
            return await consumer.GetAsyncIncidencias<List<Incidencias>>("/api/incidencias");
        }

        // OBTENCION DE INCIDENCIAS POR ID PROFESOR
        public async static Task<List<Incidencias>> ObtenerIncidenciasByProfesor(long id)
        {
            return await consumer.GetAsyncIncidenciasID<List<Incidencias>>("/api/incidencias", id);

        }

        // OBTENER PERSONAL POR ID DE PERFIL 

        public async static Task<Personal> ObtenerPersonalByPerfil(long id)
        {
            return await consumer.GetAsyncPersonal<Personal>("/api/personal",  id);
        }

        // OBTENER EL PERFIL DEL USUARIO POR NOMBRE DE DOMINIO
        public async static Task<Perfiles> ObtenerPerfilByDominio(string dominio)
        {
            return await consumer.GetAsyncPerfil<Perfiles>("/api/perfiles/dominio", dominio);
        }
    }
}
