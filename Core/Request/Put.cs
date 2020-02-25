using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System;

namespace Request
{
    public class Put
    {
        static readonly HttpClient client = new HttpClient();
        public Put(string apiKey, int operationId, DataForPut data)
        {
            client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
            using (var request = new HttpRequestMessage(HttpMethod.Put, "https://api.planfact.io/api/v1/operations/income/" + operationId.ToString()))
            {
                var json = JsonConvert.SerializeObject(data);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;

                    using (var response = client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult())
                    {
                        response.EnsureSuccessStatusCode();
                        Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                    }
                }
            }
        }
    }
}
