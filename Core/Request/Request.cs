using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System;
using System.Threading.Tasks;
using Request.Models;

namespace Request
{
    public class RequestExample
    {
        public void Delete (string apiKey, int operationId, HttpClient client)
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
        
        public void Get (string apiKey, HttpClient client)
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
        
        public async Task<string> Post (string apiKey, AccountCreationRequest data, HttpClient client)
        {
            client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.planfact.io/api/v1/accounts");
            var json = JsonConvert.SerializeObject(data);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = stringContent;
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Put(string apiKey, int operationId, OperationModificationRequest data, HttpClient client)
        {
            client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
            var request = new HttpRequestMessage(HttpMethod.Put,
                "https://api.planfact.io/api/v1/operations/income/" + operationId.ToString());
            var json = JsonConvert.SerializeObject(data);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = stringContent;
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}