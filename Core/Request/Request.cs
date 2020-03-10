using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Request.Models;

namespace Request
{
    public class RequestExample
    {
        /// <summary>
        /// DELETE-запрос для удаления счёта
        /// </summary>
        /// <param name="apiKey">Ваш api-ключ</param>
        /// <param name="operationId">Id операции, которую хотим удалить</param>
        /// <param name="client">Объект класса HttpClient</param>
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
        /// <summary>
        /// GET-запрос для получения списка счётов
        /// </summary>
        /// <param name="apiKey">Ваш api-ключ</param>
        /// <param name="client">Объект класса HttpClient</param>
        public async void Get (string apiKey, HttpClient client)
        {
            try
            {
                client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
                HttpResponseMessage response = client.GetAsync("https://api.planfact.io/api/v1/accounts").GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                Console.WriteLine(responseBody);
                var result = JsonConvert.DeserializeObject<Response<List<AccountModel>>>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        /// <summary>
        /// POST-запрос для добавления счёта
        /// </summary>
        /// <param name="apiKey">Ваш api-ключ</param>
        /// <param name="data">Данные счёта для добавления (данные хранятся в объекте класса AccountCreationReques)</param>
        /// <param name="client">Объект класса HttpClient</param>
        /// <returns>Возвращает строку с ответом</returns>
        public async Task<string> Post (string apiKey, AccountCreationRequest data, HttpClient client)
        {
            client.DefaultRequestHeaders.Add("X-ApiKey", apiKey);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.planfact.io/api/v1/accounts");
            var json = JsonConvert.SerializeObject(data);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = stringContent;
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var result = JsonConvert.DeserializeObject<Response<AccountModel>>(responseBody);
            return await response.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// PUT-запрос для изменения операции
        /// </summary>
        /// <param name="apiKey">Ваш api-ключ</param>
        /// <param name="operationId">Id операции, которую хотем изменить</param>
        /// <param name="data">Данные операции для изменения (данные хранятся в объекте класса OperationModificationRequest</param>
        /// <param name="client">Объект класса HttpClient</param>
        /// <returns>Возвращает строку с ответом</returns>
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