using System;
using System.Collections.Generic;
using System.Text;

namespace Request
{
    public class DataForPost
    {
        public string title { get; set; }
        public string longTitle { get; set; }
        public string description { get; set; }
        public int companyId { get; set; }
        public string accountType { get; set;}
        public string accoutnAcct { get; set; }
        public string accountBik { get; set; }
        public string accountBank { get; set; }
        public string currencyCode { get; set; }
        public bool active { get; set; }
        public decimal remainder { get; set; }
        public string remainderDate { get; set; }
    }
}
