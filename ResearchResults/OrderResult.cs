using System;

namespace MaintainAccount.ResearchResults
{
    public class OrderResult
    {
        public int OrderNo { get; set; }
        public string SalesOrder { get; set; }
        public string InvNo { get; set; }
        public DateTime InvDate { get; set; }
        public decimal InvAmt { get; set; }
        public string CustID { get; set; }
        public string CustName { get; set; }
        public string CustPONo { get; set; }
    }
}
