using System;
using System.Collections.Generic;
using System.Text;

namespace Request.Models
{
    public class OperationModificationRequest
    {
        public string OperationDate { get; set; }
        public int AccountId { get; set; }
        public string Comment { get; set; }
        public bool IsCommitted { get; set; }
        public List<OperationItemRequest> Items { get; set; }
    }
    public class OperationItemRequest
    {
        public string CalculationDate { get; set; }
        public bool IsCalculationCommitted { get; set; }
        public object ContrAgentId { get; set; }
        public object OperationCategoryId { get; set; }
        public object ProjectId { get; set; }
        public int Value { get; set; }
    }
}
