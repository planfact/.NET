using System;
using System.Collections.Generic;
using Request;
using Request.Models;
using System.Net.Http;


namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём объект класса Response для того, чтобы записать туда ответ.
            Response<AccountModel> response = new Response<AccountModel>();
            //Создаём объект класса HttpClient.
            HttpClient client = CreateClient();
            //Создаём объект класса RequestExample для того, чтобы через него вызывать методы, которые выполняют запросы
            RequestExample request = new RequestExample();
            //Создаём список частей операций.
            List<OperationItemRequest> items = new List<OperationItemRequest>();
            //Заполняем список частей операции
            items.Add(new OperationItemRequest { CalculationDate = "2020-02-25", ContrAgentId = null, Value = 123, IsCalculationCommitted = false, OperationCategoryId = null, ProjectId = null });
            //Создаём объект класса AccountCreationRequest и заполняем его данными для добавления счёта.
            AccountCreationRequest dataForPost = new AccountCreationRequest { Title = "test", AccountBank = null, AccountBik = null, AccountType = "Cash", AccountAcct = null, Active = true, CompanyId = 41104, CurrencyCode = "USD", Description = null, LongTitle = "", Remainder = 0, RemainderDate = "2020-03-02" };
            //Создаём объект класса OperationModificationRequest и заполняем его данными для изменнения операции.
            OperationModificationRequest dataForPut = new OperationModificationRequest { AccountId = 106080, Comment = "", IsCommitted = false, OperationDate = "2020-02-25", Items = items };
            //Создаём переменую для хранения api-ключа.
            string apiKey = "Ваш api-ключ";
            //Вызываем метод Delete для удаления операции и передаём ему в виде параметров api-ключ, id операции и объект класса HttpClient.
            request.Delete(apiKey, 16367698, client);
            //Вызываем метод Get для получения списка счетов и передаём ему в виде параметров api-ключ и объект класса HttpClient. 
            request.Get(apiKey, client);
            //Выводим в консоль результат метода Post для добавления счёта. В параметрах этого метода передаём api-ключ, данные счёта, который мы хотим добавить, объект класса HttpClient.
            Console.WriteLine(request.Post(apiKey, dataForPost, client).GetAwaiter().GetResult());
            //Выводим в консоль результат метода Put для изменения операции. В параметрах этого метода передаём api-ключ, id операции, изменённые данные операции, объект класса HttpClient.
            Console.WriteLine(request.Put(apiKey, 16367698, dataForPut, client).GetAwaiter().GetResult());
        }

        static HttpClient CreateClient()
        {
           return new HttpClient();
        }
    }
}
