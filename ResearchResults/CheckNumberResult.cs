using System;

namespace MaintainAccount.ResearchResults
{
    public class CheckNumberResult
    {
        // dgv columns to display:
        // TranNo
        // TranAmt
        // TranDate
        // CustID
        // CustName

        public int Key { get; set; }
        public string TranNo { get; set; }
        public decimal TranAmt { get; set; }
        public DateTime TranDate { get; set; }
        public string CustID { get; set; }
        public string CustName { get; set; }
    }
}
