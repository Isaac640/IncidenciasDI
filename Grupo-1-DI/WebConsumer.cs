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
            string url = $"{endpoint}?dominio={username}"; ; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
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
        public async Task<Personal> GetAsyncPersonal<T>(string endpoint, string username)
        {
            string url = $"{endpoint}?dominio={username}"; ; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Personal personal = System.Text.Json.JsonSerializer.Deserialize<Personal>(content, serializerOptions);
                return personal;
            }
            else
            {
                MessageBox.Show("Error al obtener el perfil para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        

        public async Task<List<Incidencias>> GetAsyncIncidencias<T>(string endpoint, int id)
        {
            string url = $"{endpoint}?incidencias={id}"; ; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Incidencias> incidencias = System.Text.Json.JsonSerializer.Deserialize<List<Incidencias>>(content, serializerOptions);
                return incidencias;
            }
            else
            {
                MessageBox.Show("Error al obtener las incidencias del usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*
        public async Task<T> GetAsync<T>(string endpoint, string domain)
        {
            // Combinar el nombre de usuario y la contraseña en un formato "nombreDeUsuario:contraseña"
            string url = $"{endpoint}?dominio={domain}";
            // Codificar las credenciales en base64

            using (client)
            {
                try
                {
                    // Realizar una solicitud GET a la API
                    HttpResponseMessage response = await client.GetAsync(url);
                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer y deserializar la respuesta en el tipo T
                        string responseBody = await response.Content.ReadAsStringAsync();
                        T result = JsonConvert.DeserializeObject<T>(responseBody);
                        return result;
                    }
                    else
                    {
                        // Si la solicitud no fue exitosa, mostrar el código de estado
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return default(T);
                    }
                }
                catch (HttpRequestException e)
                {
                    // Si ocurre un error al realizar la solicitud, mostrar el mensaje de error
                    Console.WriteLine($"Error: {e.Message}");
                    return default(T);
                }
            }
        }*/


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

        public async Task<T> DeleteAsync<T>(string endpoint, int id)
        {
            StringContent stringContent = new StringContent("");
            stringContent.Headers.Add("id", id.ToString());

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




    }
}
