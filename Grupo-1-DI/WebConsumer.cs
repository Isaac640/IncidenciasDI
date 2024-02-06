using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

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
                T result = JsonSerializer.Deserialize<T>(content, serializerOptions);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }

        public async Task<T> PostAsync<T>(string endpoint, Dictionary<string, string> headers)
        {
            StringContent stringContent = new StringContent("");
            foreach (string key in headers.Keys)
            {
                stringContent.Headers.Add(key, headers[key]);
            };

            HttpResponseMessage response = await client.PostAsync(host + endpoint, stringContent);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = JsonSerializer.Deserialize<T>(content, serializerOptions);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }

        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            string x = JsonSerializer.Serialize(data);
            StringContent stringContent = new StringContent(x, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(host + endpoint, stringContent);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = JsonSerializer.Deserialize<T>(content, serializerOptions);
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
                T result = JsonSerializer.Deserialize<T>(content, serializerOptions);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }
    }
}
