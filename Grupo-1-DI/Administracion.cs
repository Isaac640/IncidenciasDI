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

        // LOGIN
        public async static Task<int> IniciarSesion(string user, string passwd)
        {
            int id = await consumer.PostAsync<int>("/login", new Dictionary<string, string>() { { "user", user }, { "passwd", passwd } });
            userId = id;

            return id;
        }

        // OBTENCION DE INCIDENCIAS

        public async static Task<List<Incidencias>> ObtenerIncidencias()
        {
            return await consumer.GetAsync<List<Incidencias>>("/incidencias");
        }

        // OBTENCION DE INCIDENCIAS POR PROFESOR
        public async static Task<List<Incidencias>> ObtenerIncidenciasProfesor(string id)
        {
            return await consumer.GetAsync<List<Incidencias>>("/incidencias");
        }

    }
}
