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
            HttpClient client = CreateClient();
            RequestExample request = new RequestExample();
            List<OperationItemRequest> items = new List<OperationItemRequest>();
            items.Add(new OperationItemRequest { CalculationDate = "2020-02-25", ContrAgentId = null, Value = 123, IsCalculationCommitted = false, OperationCategoryId = null, ProjectId = null });
            AccountCreationRequest dataForPost = new AccountCreationRequest { Title = "test class request", AccountBank = null, AccountBik = null, AccountType = "Cash", AccountAcct = null, Active = true, CompanyId = 41104, CurrencyCode = "USD", Description = null, LongTitle = "", Remainder = 0, RemainderDate = "2020-03-02" };
            OperationModificationRequest dataForPut = new OperationModificationRequest { AccountId = 106080, Comment = "", IsCommitted = false, OperationDate = "2020-02-25", Items = items };
            string apiKey = "DoSxssgpo1jcSfGVB2nS4hTlgP_QfXdx42eOnhnIZcJHc5SDo9i6OuMPB46zVduOKoE65ajOivvjM02RpnZ6HjbRx4v4a4Om3E9lGY3AHL6RTkCEsud_3sm3HHvE2WamNl2gfYD7hnQ2O__3QwVMdUUsae5AkXPMWmSVppCQvvxinVrqnjTmJ2hz_GauwgaqO_1jrR24RTyzOCC0BRfbskbdIj6md5n4Ds6wS8rHfR-I525Tnp6G7hdaoEwPkfCivsvHfhQA_TJHb9_Upv2wd02pBZOF7dtOxThEs1PNQEyOnbvlopRAvwuEIkLknMpaoJPz01C8eic2zsTno-xmw9u5L_0N_zHuRwBp0KubuakiaCLBKavDvcfE8EsWF7eha6y7Bj467B9BiH-ut-h6_TsT8XhaXCYXr__SdrxPs2N2ElzJzN5prZqK5Tfd6HX9hXQMYVEC8vVZZsyaYGp56In4UCte0d8c08VukZRVDtCHWpOCMryaUfGk3OsbUX3-YTIfctROJBRhDs8r1cI930wbId3HgpAYKMrgi0b-YmJHNO4qv3ZaVATO8hKseUb6gIgmZQ";
            request.Delete(apiKey, 16367698, client);
            request.Get(apiKey, client);
            Console.WriteLine(request.Post(apiKey, dataForPost, client).GetAwaiter().GetResult());
            Console.WriteLine(request.Put(apiKey,16367698, dataForPut, client).GetAwaiter().GetResult());
        }

        static HttpClient CreateClient()
        {
           return new HttpClient();
        }
    }
}
