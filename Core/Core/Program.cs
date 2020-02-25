using System;
using System.Collections.Generic;
using Request;


namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { calculationDate = "2020-02-25", contrAgentId = null, value = 123, isCalculationCommitted = false, operationCategoryId = null, projectId = null });
            DataForPost dataForPost = new DataForPost { title = "test request", accountBank = null, accountBik = null, accountType = "Cash", accoutnAcct = null, active = true, companyId = 41104, currencyCode = "USD", description = null, longTitle = "", remainder = 0, remainderDate = "2020-02-25" };
            DataForPut dataForPut = new DataForPut { accountId = 106080, comment = "", isCommitted = false, operationDate = "2020-02-25", items = items };
            string apiKey = "DoSxssgpo1jcSfGVB2nS4hTlgP_QfXdx42eOnhnIZcJHc5SDo9i6OuMPB46zVduOKoE65ajOivvjM02RpnZ6HjbRx4v4a4Om3E9lGY3AHL6RTkCEsud_3sm3HHvE2WamNl2gfYD7hnQ2O__3QwVMdUUsae5AkXPMWmSVppCQvvxinVrqnjTmJ2hz_GauwgaqO_1jrR24RTyzOCC0BRfbskbdIj6md5n4Ds6wS8rHfR-I525Tnp6G7hdaoEwPkfCivsvHfhQA_TJHb9_Upv2wd02pBZOF7dtOxThEs1PNQEyOnbvlopRAvwuEIkLknMpaoJPz01C8eic2zsTno-xmw9u5L_0N_zHuRwBp0KubuakiaCLBKavDvcfE8EsWF7eha6y7Bj467B9BiH-ut-h6_TsT8XhaXCYXr__SdrxPs2N2ElzJzN5prZqK5Tfd6HX9hXQMYVEC8vVZZsyaYGp56In4UCte0d8c08VukZRVDtCHWpOCMryaUfGk3OsbUX3-YTIfctROJBRhDs8r1cI930wbId3HgpAYKMrgi0b-YmJHNO4qv3ZaVATO8hKseUb6gIgmZQ";
            //new Get(apiKey);
            //new Post(apiKey, dataForPost);
            //new Put(apiKey, 16367691, dataForPut);
            new Delete(apiKey, 16367691);
        }
    }
}
