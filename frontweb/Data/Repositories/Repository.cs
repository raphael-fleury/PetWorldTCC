using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetWorldWeb.Data.Repositories
{
    public abstract class Repository
    {
        public static string ApiUrl { get; set; } = "http://localhost:8080/";

        protected abstract string Href { get; }

        protected HttpClient client = new HttpClient();

        private JsonSerializerOptions serializerOptions = new JsonSerializerOptions();

        public Repository()
        {
            client.BaseAddress = new System.Uri(ApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            serializerOptions.PropertyNameCaseInsensitive = true;
        }

        protected async Task CheckForError(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpException(
                    response.StatusCode,
                    await response.Content.ReadAsStringAsync()
                );
            }
        }

        protected async Task<T> GetContent<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content, serializerOptions);
        }

        protected string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, serializerOptions);
        }
    }
}