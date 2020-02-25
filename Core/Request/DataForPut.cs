using System;
using System.Collections.Generic;
using System.Text;

namespace Request
{
    public class DataForPut
    {
        public string operationDate { get; set; }
        public int accountId { get; set; }
        public string comment { get; set; }
        public bool isCommitted { get; set; }
        public List<Item> items { get; set; }
        public int value { get; set; }
    }
    public class Item
    {
        public string calculationDate { get; set; }
        public bool isCalculationCommitted { get; set; }
        public object contrAgentId { get; set; }
        public object operationCategoryId { get; set; }
        public object projectId { get; set; }
        public int firstAdditionalOperationAttributeId { get; set; }
        public int value { get; set; }
    }
}
