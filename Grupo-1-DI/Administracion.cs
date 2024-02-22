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
            consumer = new WebConsumer("http://localhost:8089/api");
        }

        // METODOS DE OBTENCION DE DATOS POR API


        // OBTENCION DE TODAS LAS INCIDENCIAS

        public async static Task<List<Incidencias>> ObtenerIncidencias()
        {
            return await consumer.GetAsyncIncidencias<List<Incidencias>>("/incidencias");
        }

        // OBTENCION DE INCIDENCIAS POR ID PROFESOR
        public async static Task<List<Incidencias>> ObtenerIncidenciasByProfesor(long id)
        {
            return await consumer.GetAsyncIncidenciasIDProf<List<Incidencias>>("/incidencias", id);
        }

        // OBTENER INCIDENCIAS POR ID DE INCIDENCIA
        public async static Task<Incidencias> ObtenerIncidenciaByID(long id)
        {
            return await consumer.GetAsyncIncidenciaByID<Incidencias>("/incidencias", id);
        }

        // OBTENER PERSONAL POR ID DE PERFIL 

        public async static Task<Personal> ObtenerPersonalByPerfil(long id)
        {
            return await consumer.GetAsyncPersonal<Personal>("/personal",  id);
        }

        // OBTENER EL PERFIL DEL USUARIO POR NOMBRE DE DOMINIO
        public async static Task<Perfiles> ObtenerPerfilByDominio(string dominio)
        {
            return await consumer.GetAsyncPerfil<Perfiles>("/perfiles/dominio", dominio);
        }

        // OBTENER COMENTARIOS POR ID INCIDENCIAS
        public async static Task<List<Comentarios>> ObtenerComentariosByIncidenciasId(int id)
        {
            return await consumer.GetAsyncComentariosList<List<Comentarios>>("/comentarios/incidencia", id);
        }

        // BORRAR INCIDENCIA POR ID
        public async static Task<bool> BorrarIncidencia(int id)
        {
            bool resultado = await consumer.DeleteAsyncIncidencia("/incidencias", id);
            return resultado;
        }
    }
}
