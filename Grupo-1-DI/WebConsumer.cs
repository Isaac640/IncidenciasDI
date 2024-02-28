using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;
using Grupo_1_DI.Enumerados;
using Grupo_1_DI.Base_Datos;
using Grupo_1_DI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;

namespace Grupo_3_Intermodular
{
    /// <summary>
    /// Clase para consumir una API web.
    /// </summary>
    public class WebConsumer
    {
        private string host;

        private HttpClient client;
        private JsonSerializerOptions serializerOptions;

        /// <summary>
        /// Constructor de la clase WebConsumer.
        /// </summary>
        /// <param name="host">La URL base del host de la API.</param>
        public WebConsumer(string host)
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new JsonStringEnumConverter() }
            };

            this.host = host;
        }
        // Métodos para realizar peticiones GET a la API

        public async Task<Perfiles> GetAsyncPerfil<T>(string endpoint, string username)
        {
            string url = $"{endpoint}?dominio={username}"; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Perfiles perfil = System.Text.Json.JsonSerializer.Deserialize<Perfiles>(content, serializerOptions);
                return perfil;
            }
            else
            {
                MessageBox.Show($"Error al obtener el perfil para el usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<Personal> GetAsyncPersonalByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Personal personal = System.Text.Json.JsonSerializer.Deserialize<Personal>(content, serializerOptions);
                return personal;
            }
            else
            {
                MessageBox.Show($"Error al obtener el personal del usuario por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Personal>> GetAsyncPersonal<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Personal> personal = System.Text.Json.JsonSerializer.Deserialize<List<Personal>>(content, serializerOptions);
                return personal;
            }
            else
            {
                MessageBox.Show($"Error al obtener el personal del usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Incidencias>> GetAsyncIncidencias<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Incidencias> incidencias = System.Text.Json.JsonSerializer.Deserialize<List<Incidencias>>(content, serializerOptions);
                return incidencias;
            }
            else
            {
                MessageBox.Show($"Error al obtener las incidencias. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Incidencias>> GetAsyncIncidenciasIDProf<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/creadorId/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Incidencias> incidencias = System.Text.Json.JsonSerializer.Deserialize<List<Incidencias>>(content, serializerOptions);
                return incidencias;
            }
            else
            {
                MessageBox.Show($"Error al obtener las incidencias del usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Incidencias> GetAsyncIncidenciaByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Incidencias incidencia = System.Text.Json.JsonSerializer.Deserialize<Incidencias>(content, serializerOptions);
                return incidencia;
            }
            else
            {
                MessageBox.Show($"Error al obtener las incidencias por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Comentarios>> GetAsyncComentariosList<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                List<Comentarios> comentarios = System.Text.Json.JsonSerializer.Deserialize<List<Comentarios>>(content, serializerOptions);
                return comentarios;
            }
            else
            {
                MessageBox.Show($"Error al obtener los comentarios de la incidencia. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<List<Incidencias_Subtipos>> GetAsyncTipo<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                List<Incidencias_Subtipos> subtipos = System.Text.Json.JsonSerializer.Deserialize<List<Incidencias_Subtipos>>(content, serializerOptions);
                return subtipos;
            }
            else
            {
                MessageBox.Show($"Error al obtener los tipos de incidencia. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Métodos para realizar peticiones PUT a la API

        public async Task<bool> PutPersonalAsync(string endpoint, long id, Personal PersonalActualizado)
        {
            try
            {
                string jsonIncidencia = JsonConvert.SerializeObject(PersonalActualizado);
                string apiUrl = host + $"{endpoint}/{id}";

                string url = apiUrl.Replace("{id}", id.ToString());

                var request = new HttpRequestMessage(HttpMethod.Put, url);
                request.Content = new StringContent(jsonIncidencia, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al dar de baja. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Métodos para realizar peticiones POST a la API

        public async Task<bool> PostAsyncComentario(Comentarios comentario)
        {
            try
            {
                // Serializar el objeto a JSON
                string json = JsonConvert.SerializeObject(comentario);

                // Crear un HttpClient

                // URL de tu API
                string url = "/comentarios/guardarComentario";

                // Convertir el objeto JSON en un StringContent
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(host + url, content);

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al publicar un comentario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error al publicar un comentario. Código de estado: {ex.Message}");
                return false;
            }
        }

        // Métodos para realizar peticiones DELETE a la API

        public async Task<bool> DeleteAsyncIncidencia(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar la incidencia. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la incidencia: {ex.Message}");
                return false;
            }
        }


    }
}
