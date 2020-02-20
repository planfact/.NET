using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Request
{
    class Post
    {
        static readonly HttpClient client = new HttpClient();
        public Post (string apiKey, DataForPost data)
        {
            client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
            using (var request = new HttpRequestMessage(HttpMethod.Post, "https://api.planfact.io/api/v1/accounts"))
            {
                var json = JsonConvert.SerializeObject(data);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;

                    using (var response = client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult())
                    {
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
        }
    }
}
