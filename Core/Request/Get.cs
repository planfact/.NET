using System;
using System.Net.Http;

namespace Request
{
    public class Get
    {
        static readonly HttpClient client = new HttpClient();
        public Get (string apiKey)
        {
            try
            {
                client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
                HttpResponseMessage response = client.GetAsync("https://api.planfact.io/api/v1/accounts").GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
