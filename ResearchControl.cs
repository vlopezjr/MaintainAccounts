using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using MaintainAccount.ResearchResults;

namespace MaintainAccount
{
    public partial class ResearchControl : UserControl
    {
        private ARResearchService service;
        public delegate void ErrorEventHandler(string error);
        public event ErrorEventHandler ErrorOccured = delegate { };
        public event Action ClearError = delegate { };


        public ResearchControl()
        {
            InitializeComponent();
        }

        private void ResearchControl_Load(object sender, EventArgs e)
        {
            service = new ARResearchService();
            var preloadEF = service.GetCreditCardByOP(0);

            foreach (Control control in Controls)
            {
                control.KeyUp += KeyUpEventHandler;

                if (control.Controls.Count > 0)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.KeyUp += KeyUpEventHandler;
                    }
                }
            }
        }





        #region SEARCH
        private async void FindButton_Click(object sender, EventArgs e)
        {
            // search types:
            // Check Number
            // Invoice
            // Purchase Order
            // Amount
            // Shipment ID
            // OP#
            // SO#

            if (CheckNumberRadioButton.Checked)
                await SearchByCheckNumber();

            if (InvoiceRadioButton.Checked)
                await SearchByInvoiceNumber();

            if (PurchaseOrderRadioButton.Checked)
                await SearchByPONumber();

            if (AmountRadioButton.Checked)
                await SearchByAmount();

            if (OPRadioButton.Checked)
                await SearchByOPNumber();

            if (SORadioButton.Checked)
                await SearchBySONumber();
        }

        private async Task SearchByCheckNumber()
        {
            // dgv columns:
            // TranNo
            // TranAmt
            // TranDate
            // CustID
            // CustName
            ClearError();
            FindButton.Enabled = false;
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            List<CustPayment> results = await service.GetCustPaymentsByTranNoAsync(userSearchText, (int)LimitNumeric.Value);

            List<CheckNumberResult> checkNumberResults = new List<CheckNumberResult>();
            foreach (var item in results)
            {
                checkNumberResults.Add(new CheckNumberResult
                {
                    Key = item.Key,
                    TranNo = item.TranNo,
                    TranAmt = item.TranAmt,
                    TranDate = item.TranDate,
                    CustID = item.Customer.Id,
                    CustName = item.Customer.Name
                });
            }

            if (checkNumberResults.Count > 0)
            {
                ResultsDataGridView.DataSource = checkNumberResults;
                ResultsDataGridView.Columns["Key"].Visible = false;
                ResultsDataGridView.Columns["TranAmt"].DefaultCellStyle.Format = "c";
            }

            CountLabel.Text = checkNumberResults.Count.ToString();

            FindButton.Enabled = true;
        }

        private async Task SearchByInvoiceNumber()
        {
            // dgv columns:
            // TranCmnt
            // TranDate
            // CustID
            // CustName
            // CustPONo
            // TranAmt
            // TranID
            ClearError();
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();
            FindButton.Enabled = false;

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            List<Invoice> results = await service.GetInvoicesByTranNoAsync(userSearchText, (int)LimitNumeric.Value);

            PopulateDataGridView(results);

            FindButton.Enabled = true;
        }

        private async Task SearchByPONumber()
        {
            // dgv columns:
            // TranCmnt
            // TranDate
            // CustID
            // CustName
            // CustPONo
            // TranAmt
            // TranID
            ClearError();
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();
            FindButton.Enabled = false;

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            List<Invoice> results = await service.GetInvoicesByPONumberAsync(userSearchText, (int)LimitNumeric.Value);

            PopulateDataGridView(results);

            FindButton.Enabled = true;
        }

        private async Task SearchByAmount()
        {
            ClearError();
            FindButton.Enabled = false;
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            var success = Decimal.TryParse(userSearchText, out decimal result);
            if (success)
            {
                List<Invoice> invoices = await service.GetInvoicesByTranAmtAsync(result, (int)LimitNumeric.Value);

                PopulateDataGridView(invoices);
            }
            else
            {
                ErrorOccured("Error - Cannot convert input into number");

                FindTextBox.Focus();
                FindTextBox.Select(0, FindTextBox.Text.Length);

                CountLabel.Text = "0";
            }

            FindButton.Enabled = true;
        }

        private async Task SearchByOPNumber()
        {
            ClearError();
            FindButton.Enabled = false;
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            var orders = await service.GetCPSalesOrdersByOPAsync(userSearchText, (int)LimitNumeric.Value);

            List<OrderResult> orderResults = new List<OrderResult>();
            foreach (var order in orders)
            {
                Invoice invoice = order.SalesOrder.SOLines[0].ShipLines[0].InvoiceShipment.Invoice;
                SalesOrder salesOrder = order.SalesOrder;

                orderResults.Add(new OrderResult
                {
                    OrderNo = order.Key,
                    SalesOrder = salesOrder.TranNo,
                    InvNo = invoice.TranID,
                    InvDate = invoice.TranDate,
                    InvAmt = invoice.TranAmt,
                    CustID = order.Customer.Id,
                    CustName = order.Customer.Name,
                    CustPONo = invoice.CustPONo
                });
            }

            if (orderResults.Count > 0)
            {
                ResultsDataGridView.DataSource = orderResults;
                ResultsDataGridView.Columns["InvAmt"].DefaultCellStyle.Format = "c";
            }

            CountLabel.Text = orderResults.Count.ToString();
            FindButton.Enabled = true;
        }

        private async Task SearchBySONumber()
        {
            ClearError();
            FindButton.Enabled = false;
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            StartCountLoadingEffect();

            string userSearchText = FindTextBox.Text.TrimEnd();
            var orders = await service.GetSalesOrdersByTranNoAsync(userSearchText, (int)LimitNumeric.Value);

            List<OrderResult> orderResults = new List<OrderResult>();
            foreach (var order in orders)
            {
                Invoice invoice = order.SOLines[0].ShipLines[0].InvoiceShipment.Invoice;

                orderResults.Add(new OrderResult
                {
                    OrderNo = order.Key,
                    SalesOrder = order.TranNo,
                    InvNo = invoice.TranID,
                    InvDate = invoice.TranDate,
                    InvAmt = invoice.TranAmt,
                    CustID = order.Customer.Id,
                    CustName = order.Customer.Name,
                    CustPONo = invoice.CustPONo
                });
            }

            if (orderResults.Count > 0)
            {
                ResultsDataGridView.DataSource = orderResults;
                ResultsDataGridView.Columns["InvAmt"].DefaultCellStyle.Format = "c";
                ResultsDataGridView.Columns["OrderNo"].Visible = false;
            }

            CountLabel.Text = orderResults.Count.ToString();
            FindButton.Enabled = true;
        }


        private void PopulateDataGridView(List<Invoice> invoices)
        {
            List<StandardResult> standardResults = new List<StandardResult>();
            foreach (var invoice in invoices)
            {
                standardResults.Add(new StandardResult
                {
                    Key = invoice.Key,
                    TranCmnt = invoice.TranCmnt,
                    TranDate = invoice.TranDate,
                    CustID = invoice.Customer.Id,
                    CustName = invoice.Customer.Name,
                    CustPONo = invoice.CustPONo,
                    TranAmt = invoice.TranAmt,
                    TranID = invoice.TranID
                });
            }

            if (standardResults.Count > 0)
            {
                ResultsDataGridView.DataSource = standardResults;
                ResultsDataGridView.Columns["Key"].Visible = false;
                ResultsDataGridView.Columns["TranAmt"].DefaultCellStyle.Format = "c";
                ResultsDataGridView.Columns["TranNo"].Visible = false;
            }

            CountLabel.Text = standardResults.Count.ToString();
        }

        #endregion





        #region UI HELPER METHODS
        private void FindTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton.PerformClick();

                FindTextBox.Focus();
                FindTextBox.Select(0, FindTextBox.TextLength);
            }
        }

        private void KeyUpEventHandler(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.F)
            {
                FindTextBox.Focus();
                FindTextBox.Select(0, FindTextBox.TextLength);
            }
        }

        private void OPTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TransactionsButton.PerformClick();

                OPTextBox.Focus();
                OPTextBox.Select(0, OPTextBox.TextLength);
            }
        }

        Timer timer;
        private void StartCountLoadingEffect()
        {
            if (timer != null)
                timer.Dispose();

            CountLabel.Text = "-";
            int turn = 0;
            string[] loadingTexts =
            {
                "-",
                "--",
                "---",
                "----"
            };

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (o, i) =>
            {
                BeginInvoke((Action)(() =>
                {
                    if (!CountLabel.Text.Contains("-"))
                    {
                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        CountLabel.Text = loadingTexts[turn++];
                        turn %= loadingTexts.Length;
                    }
                }));
            };

            timer.Start();
        }
        #endregion






        #region TRANSACTIONS
        private async void TransactionsButton_Click(object sender, EventArgs e)
        {
            ClearError();
            TransactionsButton.Enabled = false;
            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            bool success = Int32.TryParse(OPTextBox.Text.TrimEnd(), out int result);
            if (success)
            {
                var transactions = await service.GetCCTransactionsByOPAsync(result, (int)LimitNumeric.Value);

                if (transactions.Count > 0)
                {
                    ResultsDataGridView.DataSource = transactions;
                    ResultsDataGridView.Columns["Amount"].DefaultCellStyle.Format = "c";
                    ResultsDataGridView.Columns["Key"].Visible = false;
                    ResultsDataGridView.Columns["OPKey"].Visible = false;
                }

                CountLabel.Text = transactions.Count.ToString();
            }
            else
            {
                ErrorOccured("Error - Cannot convert input into number");

                OPTextBox.Focus();
                OPTextBox.Select(0, OPTextBox.TextLength);

                CountLabel.Text = "0";
            }

            TransactionsButton.Enabled = true;
        }

        private async void CreditCardButton_Click(object sender, EventArgs e)
        {
            ClearError();

            ResultsDataGridView.DataSource = null;
            ResultsDataGridView.Rows.Clear();
            ResultsDataGridView.Columns.Clear();

            CreditCardButton.Enabled = false;

            bool success = Int32.TryParse(OPTextBox.Text.TrimEnd(), out int result);
            if (success)
            {
                var creditcard = await service.GetCreditCardByOP(result);

                if (creditcard != null)
                {
                    ResultsDataGridView.Columns.Add("CrCardTypeName", "Card Type");
                    ResultsDataGridView.Columns.Add("CrCardNo", "Card No");
                    ResultsDataGridView.Columns.Add("CrCardExp", "Expire Date");
                    ResultsDataGridView.Columns.Add("CardHolderName", "Card Holder");
                    ResultsDataGridView.Columns.Add("CrCardStreetNbrZip", "Street");
                    ResultsDataGridView.Columns.Add("CrCardZipCode", "Zip");

                    var index = ResultsDataGridView.Rows.Add();
                    var row = ResultsDataGridView.Rows[index];

                    row.Cells["CrCardTypeName"].Value = creditcard.CrCardTypeName;
                    row.Cells["CrCardNo"].Value = creditcard.CrCardNo;
                    row.Cells["CrCardExp"].Value = creditcard.CrCardExp;
                    row.Cells["CardHolderName"].Value = creditcard.CardHolderName;
                    row.Cells["CrCardStreetNbrZip"].Value = creditcard.CrCardStreetNbrZip;
                    row.Cells["CrCardZipCode"].Value = creditcard.CrCardZipCode;

                    CountLabel.Text = "1";
                }

                CountLabel.Text = "0";
            }
            else
            {
                OPTextBox.Text += " Error can't convert to number";
                OPTextBox.Select(0, OPTextBox.TextLength);

                CountLabel.Text = "0";
            }


            CreditCardButton.Enabled = true;
        }

        #endregion

    }
}
