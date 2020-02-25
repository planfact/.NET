using System;
using System.Net.Http;

namespace Request
{
    public class Delete
    {
        static readonly HttpClient client = new HttpClient();
        public Delete (string apiKey, int operationId)
        {
            try
            {
                client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
                HttpResponseMessage response = client.DeleteAsync("https://api.planfact.io/api/v1/operations/" + operationId.ToString()).GetAwaiter().GetResult();
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
