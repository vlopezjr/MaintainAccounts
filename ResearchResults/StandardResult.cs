namespace MaintainAccount.ResearchResults
{
    public class StandardResult : CheckNumberResult
    {
        // dgv columns to display:
        // TranCmnt
        // TranDate
        // CustID
        // CustName
        // CustPONo
        // TranAmt
        // TranID

        public string TranCmnt { get; set; }
        public string CustPONo { get; set; }
        public string TranID { get; set; }
    }
}
