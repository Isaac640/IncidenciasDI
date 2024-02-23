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
    public class WebConsumer
    {
        private string host;

        private HttpClient client;
        private JsonSerializerOptions serializerOptions;

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

        public async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await client.GetAsync(host + endpoint);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = System.Text.Json.JsonSerializer.Deserialize<T>(content, serializerOptions);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }

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
                MessageBox.Show("Error al obtener el perfil para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<Personal> GetAsyncPersonal<T>(string endpoint, long id)
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
                MessageBox.Show("Error al obtener el personal del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al obtener las incidencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al obtener las incidencias del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al obtener las incidencias por su ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al obtener los comentarios de la incidencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        

        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            string x = System.Text.Json.JsonSerializer.Serialize(data);
            StringContent stringContent = new StringContent(x, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(host + endpoint, stringContent);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = System.Text.Json.JsonSerializer.Deserialize<T>(content, serializerOptions);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }

        public async Task<bool> PostAsyncComentario(Comentarios comentario)
        {
            try
            {
                // Serializar el objeto a JSON
                string json = JsonConvert.SerializeObject(comentario);

                // Crear un HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // URL de tu API
                    string url = "/comentarios";

                    // Convertir el objeto JSON en un StringContent
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(host + url, content);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // La solicitud fue exitosa
                        return true;
                    }
                    else
                    {
                        // La solicitud falló
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

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
                    Console.WriteLine($"Error al eliminar la incidencia. Código de estado: {response.StatusCode}");
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
