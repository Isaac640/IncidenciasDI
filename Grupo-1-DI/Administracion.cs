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
    /// Clase para la obtención de datos desde una API.
    /// </summary>
    public class Administracion
    {
        private static WebConsumer consumer;

        /// <summary>
        /// Constructor estático que inicializa el consumidor web con la URL base de la API.
        /// </summary>
        static Administracion()
        {
            consumer = new WebConsumer("http://localhost:8089/api");
        }

        // Métodos para la obtención de datos desde la API

        /// <summary>
        /// Obtiene todas las incidencias desde la API.
        /// </summary>
        /// <returns>Una lista de incidencias.</returns>
        public async static Task<List<Incidencias>> ObtenerIncidencias()
        {
            return await consumer.GetAsyncIncidencias<List<Incidencias>>("/incidencias");
        }

        /// <summary>
        /// Obtiene las incidencias asociadas a un profesor por su ID.
        /// </summary>
        /// <param name="id">El ID del profesor.</param>
        /// <returns>Una lista de incidencias.</returns>
        public async static Task<List<Incidencias>> ObtenerIncidenciasByProfesor(long id)
        {
            return await consumer.GetAsyncIncidenciasIDProf<List<Incidencias>>("/incidencias", id);
        }

        /// <summary>
        /// Obtiene una incidencia específica por su ID.
        /// </summary>
        /// <param name="id">El ID de la incidencia.</param>
        /// <returns>La incidencia obtenida.</returns>
        public async static Task<Incidencias> ObtenerIncidenciaByID(long id)
        {
            return await consumer.GetAsyncIncidenciaByID<Incidencias>("/incidencias", id);
        }

        /// <summary>
        /// Obtiene información de personal por su ID.
        /// </summary>
        /// <param name="id">El ID del personal.</param>
        /// <returns>Los datos del personal.</returns>
        public async static Task<Personal> ObtenerPersonalByID(long id)
        {
            return await consumer.GetAsyncPersonalByID<Personal>("/personal", id);
        }

        /// <summary>
        /// Obtiene información de Los subtipos
        /// </summary>
        /// <returns>Los datos de los tipos.</returns>
        public async static Task<List<Incidencias_Subtipos>> ObtenerTipos()
        {
            return await consumer.GetAsyncTipo<List<Incidencias_Subtipos>>("/incidenciasSubtipos");
        }

        /// <summary>
        /// Obtiene toda la lista de personal desde la API.
        /// </summary>
        /// <returns>Una lista de personal.</returns>
        public async static Task<List<Personal>> ObtenerPersonal()
        {
            return await consumer.GetAsyncPersonal<List<Personal>>("/personal");
        }

        /// <summary>
        /// Obtiene el perfil del usuario por su nombre de dominio.
        /// </summary>
        /// <param name="dominio">El nombre de dominio del usuario.</param>
        /// <returns>El perfil del usuario.</returns>
        public async static Task<Perfiles> ObtenerPerfilByDominio(string dominio)
        {
            return await consumer.GetAsyncPerfil<Perfiles>("/perfiles/dominio", dominio);
        }

        /// <summary>
        /// Obtiene los comentarios asociados a una incidencia por su ID.
        /// </summary>
        /// <param name="id">El ID de la incidencia.</param>
        /// <returns>Una lista de comentarios.</returns>
        public async static Task<List<Comentarios>> ObtenerComentariosByIncidenciasId(long id)
        {
            return await consumer.GetAsyncComentariosList<List<Comentarios>>("/comentarios/incidencia", id);
        }

        /// <summary>
        /// Publica un comentario en la API.
        /// </summary>
        /// <param name="com">El comentario a publicar.</param>
        /// <returns>True si se publica correctamente, false en caso contrario.</returns>
        public async static Task<bool> PublicarComentario(Comentarios com)
        {
            return await consumer.PostAsyncComentario(com);
        }

        /// <summary>
        /// Actualiza los datos de un personal en la API.
        /// </summary>
        /// <param name="per">Los datos del personal a actualizar.</param>
        /// <returns>True si se actualiza correctamente, false en caso contrario.</returns>
        public async static Task<bool> ActualizarPersonal(Personal per)
        {
            return await consumer.PutPersonalAsync("/personal", per.id, per);
        }

        /// <summary>
        /// Elimina una incidencia de la API por su ID.
        /// </summary>
        /// <param name="id">El ID de la incidencia a eliminar.</param>
        /// <returns>True si se elimina correctamente, false en caso contrario.</returns>
        public async static Task<bool> BorrarIncidencia(int id)
        {
            bool resultado = await consumer.DeleteAsyncIncidencia("/incidencias", id);
            return resultado;
        }
    }
}
