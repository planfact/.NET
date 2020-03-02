using System;
using System.Collections.Generic;
using System.Text;

namespace Request.Models
{
    public class AccountCreationRequest
    {
        public string Title { get; set; }
        public string LongTitle { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public string AccountType { get; set;}
        public string AccountAcct { get; set; }
        public string AccountBik { get; set; }
        public string AccountBank { get; set; }
        public string CurrencyCode { get; set; }
        public bool Active { get; set; }
        public decimal Remainder { get; set; }
        public string RemainderDate { get; set; }
    }
}
