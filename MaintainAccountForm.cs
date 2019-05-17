using AddressManager;
using ARStatus;
using ContactManager;
using CreateAccountWizard;
using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using CreditCardManager;
using MaintainAccount;
using MemoMeister;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace MaintainCustomer
{
    public partial class MaintainAccountsForm : Form
    {
        private bool isDirty;
        private bool taxExemptionsWereAltered;
        private bool loading;
        private bool arStatusTypeChanged;

        private List<PaymentTerms> paymentTerms;
        private List<ShipMethod> shipMethods;
        private Group collectorGroup;
        private List<string> standAloneCustIds;
        private CalculateARStatus arStatus;
        private Customer customer;
        private CustomerService customerService;
        private LookUpService lookupService;


        private static MaintainAccountsForm _form = null;
        public static MaintainAccountsForm Instance()
        {
            if (_form == null)
            {
                _form = new MaintainAccountsForm();
            }
            return _form;
        }


        private MaintainAccountsForm()
        {
            InitializeComponent();
        }




        #region FORM LOAD
        private async void MaintainAccountForm_Load(object sender, EventArgs e)
        {
            SetUpPermissions();

            if (ConfigurationManager.ConnectionStrings["CustomerContext"].ConnectionString.Contains("server=sql18dev"))
            {
                ConnectionLabel.Text = "Database: SQL18DEV";
            }

            customer = new Customer();
            customerService = new CustomerService();
            lookupService = new LookUpService();

            await SetCustIDTextBoxCustIdsSourceAsync();

            paymentTerms = lookupService.GetPaymentTerms();
            shipMethods = lookupService.GetShipMethods();
            collectorGroup = lookupService.GetGroupByGroupID("Collectors");
            standAloneCustIds = await customerService.GetStandAloneCustIds();

            paymentTerms.ForEach(term => cboPaymentTerms.Items.Add(term.Id));
            shipMethods.ForEach(meth => cboShipMethod.Items.Add(meth.ShipMethID));
            collectorGroup.Users.ForEach(usr => cboCollector.Items.Add(usr.UserID));

            ARResearchControl.ErrorOccured += (error) =>
            {
                lblGeneralStatus.Text = error;
                lblGeneralStatus.ForeColor = Color.Red;
            };

            ARResearchControl.ClearError += () =>
            {
                lblGeneralStatus.Text = lblGeneralStatus.Text.Contains("Error") ? "" : lblGeneralStatus.Text;
            };

            TurboTenKeyControl turboTenControl = new TurboTenKeyControl() { Dock = DockStyle.Fill };
            TurboTenKeyTab.Controls.Add(turboTenControl);
        }



        private async Task SetCustIDTextBoxCustIdsSourceAsync()
        {
            var custIds = await customerService.GetCustIdsWithQualifiersAsync();

            txtCustID.AutoCompleteCustomSource.Clear();
            txtCustID.AutoCompleteCustomSource.AddRange(custIds.ToArray());
        }

        #endregion







        #region PERMISSIONS
        bool isSuper;
        bool isInCC;
        bool isInCustCreate;

        private void SetUpPermissions()
        {
            isSuper = false;
            isInCC = false;
            isInCustCreate = false;

            var userName = Environment.UserName;

            var context = new PrincipalContext(ContextType.Domain, "caseparts");
            var superGroup = GroupPrincipal.FindByIdentity(context, "ARSuper");
            var ccGroup = GroupPrincipal.FindByIdentity(context, "CC");
            var custCreateGroup = GroupPrincipal.FindByIdentity(context, "CustCreation");
            var devGroup = GroupPrincipal.FindByIdentity(context, "Developers");

            var user = UserPrincipal.FindByIdentity(context, userName);

            if (user != null)
            {
                if (user.IsMemberOf(devGroup))
                {
                    isSuper = true;
                    isInCC = true;
                    isInCustCreate = true;
                }
                else
                {
                    isSuper = superGroup != null ? user.IsMemberOf(superGroup) : false;
                    isInCC = ccGroup != null ? user.IsMemberOf(ccGroup) : false;
                    isInCustCreate = custCreateGroup != null ? user.IsMemberOf(custCreateGroup) : false;
                }
            }

            if (!isInCustCreate)
            {
                grpGeneral.Height = 177;
                txtOnHold.Location = new Point(97, 139);
                txtOnHold.Parent = grpGeneral;
                txtOnHold.Width = 137;
                lblOnHold.Location = new Point(11, 144);
                lblOnHold.Parent = grpGeneral;
            }

            btnCreateLetters.Visible = isSuper;
            grpLetterType.Visible = isSuper;
            btnCallSheets.Visible = isSuper;
            btnCreateAccount.Visible = isInCustCreate;
            btnCreateAccount.Enabled = isInCustCreate;
            btnCreateHQ.Visible = isSuper;
            btnCreateHQ.Enabled = false;
            btnCreditCards.Visible = isInCC;
            btnCreditCards.Enabled = false;
            remarkViewer.Visible = isInCustCreate;
            grpOptions.Visible = isInCustCreate;
            grpARStatus.Visible = isInCustCreate;
            grpCredit.Visible = isInCustCreate;
            grpTaxExmpt.Visible = isInCustCreate;
            grpClass.Visible = isInCustCreate;
            grpAccountStatus.Visible = isInCustCreate;
            chkNuclearHold.Visible = isInCustCreate;
            btnSave.Visible = isInCustCreate;
            dgvBranches.ReadOnly = !isSuper;


            if (superGroup == null || ccGroup == null || custCreateGroup == null)
            {
                lblGeneralStatus.Text = "Failed to set permissions. Contact IT if this problem persist.";
                lblGeneralStatus.ForeColor = Color.Red;
            }
            else
            {
                lblGeneralStatus.Text = "Permissions set for " + userName;
                lblGeneralStatus.ForeColor = Color.Green;
            }

            context.Dispose();

            if (superGroup != null)
                superGroup.Dispose();
            if (ccGroup != null)
                ccGroup.Dispose();
            if (custCreateGroup != null)
                custCreateGroup.Dispose();
        }
        #endregion








        #region TEXTBOX BEHAVIOR
        bool alreadyFocused;
        private void txtCustID_Enter(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                txtCustID.SelectAll();
                alreadyFocused = true;
            }
        }

        private void txtCustID_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && txtCustID.SelectionLength == 0)
            {
                alreadyFocused = true;
                txtCustID.SelectAll();
            }
        }

        private void txtCustID_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;

            if (!string.IsNullOrEmpty(txtCustID.Text) && customer != null && customer.Id != null && customer.Id.TrimEnd() != txtCustID.Text.TrimEnd())
            {
                Search();
                SendKeys.Send("{ESCAPE}"); //closes the auto complete panel on custid textbox
                btnAddresses.Focus();
            }
        }

        private void txtCustID_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (!string.IsNullOrEmpty(txtCustID.Text)))
            {
                Search();
                SendKeys.Send("{ESCAPE}"); //closes the auto complete panel on custid textbox
                btnAddresses.Focus();
            }
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            lblGeneralStatus.Text = "";
        }
        #endregion








        //BRANCH ACCOUNT NAVIGATION
        private void listBoxBranches_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = lbBranches.SelectedItem;
            if (selectedItem == null) return;

            txtCustID.Text = lbBranches.SelectedItem.ToString();
            txtCustID_KeyUp(this, new KeyEventArgs(Keys.Enter));
        }



        //FORM CLOSING
        private void MaintainCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NotifyIfCustomerIsDirty();
        }








        #region SEARCH
        private void Search()
        {
            NotifyIfCustomerIsDirty();

            Cursor = Cursors.WaitCursor;

            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Loading....";

            SearchForCustomer();

            if (customer != null && customer.Key != 0)
            {
                lblGeneralStatus.ForeColor = Color.Green;
                lblGeneralStatus.Text = "Customer loaded.";

                arStatus = new CalculateARStatus();
                arStatus.Load(customer.Key);

                SetUpBranchesListBox();
                SetUpAccountTypeSpecificControls();
                LoadCustomerDetails();
                EnableCustomerControls();
                SetUpRemarkViewer();
            }

            Cursor = Cursors.Default;
        }

        private void SetUpRemarkViewer()
        {
            if (isInCustCreate)
            {
                remarkViewer.Enabled = true;
                remarkViewer.UserId = Environment.UserName;
                remarkViewer.OwnerId = customer.Id.TrimEnd();
            }
            else
            {
                remarkViewer.Visible = false;
            }
        }

        private void LogTaxExemptionsForDevPurposes()
        {
            foreach (var custAddr in customer.CustAddresses)
            {
                Console.WriteLine("Current cust address: " + custAddr.Key);
                Console.WriteLine("TaxExemption Count: " + custAddr.TaxExemptionsAcuity.Count);
                Console.WriteLine("--List of exemptions--");
                foreach (var exempt in custAddr.TaxExemptionsAcuity)
                {
                    Console.WriteLine("Tax Code Key: " + exempt.STaxCodeKey);
                    Console.WriteLine("Exmpt No: " + exempt.ExmptNo);
                    Console.WriteLine("-------------------");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        private void NotifyIfCustomerIsDirty()
        {
            if (isDirty)
            {
                isDirty = false;

                var result = MessageBox.Show("Customer has been modified. Do you want to save changes?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    btnSave.PerformClick();
                else
                    ReloadCurrentCustomerAndRefreshUI();
            }

            isDirty = false;
        }

        private void SearchForCustomer()
        {
            try
            {
                string custId = txtCustID.Text.Replace(" - HQ", "").Replace(" - BR", "").Replace(" - SA", "").TrimEnd();
                txtCustID.Text = txtCustID.Text.Replace(" - HQ", "").Replace(" - BR", "").Replace(" - SA", "").TrimEnd();
                customer = customerService.LoadCustomerWithDependenciesById(custId);
            }
            catch
            {
                customer = null;

                lblGeneralStatus.Text = "Customer not found.";
                lblGeneralStatus.ForeColor = Color.Red;

                grpGeneral.Enabled = false;
                grpOptions.Enabled = false;
                grpCredit.Enabled = false;
                grpBranchSettings.Enabled = false;
                grpOptions.Enabled = false;
                grpTaxExmpt.Enabled = false;
                grpARStatus.Enabled = false;
                grpTaxExmpt.Enabled = false;
                grpClass.Enabled = false;
                grpAccountStatus.Enabled = false;
                chkNuclearHold.Enabled = false;

                btnSave.Enabled = false;
                remarkViewer.Enabled = false;
                btnContacts.Enabled = false;
                btnAddresses.Enabled = false;
                btnCreditCards.Enabled = false;

                ClearForm();
            }
        }

        private void ClearForm()
        {
            UnsubscribeFromStateChangedEvents();

            txtAccountType.Clear();
            txtCustomerID.Clear();
            txtCustName.Clear();
            txtCreateDate.Clear();
            rdoEndUser.Checked = false;
            rdoDealer.Checked = false;
            rdoWholesaler.Checked = false;
            chkStatements.Checked = false;
            chkPricePackingSlip.Checked = false;
            chkPORequired.Checked = false;
            rdoActive.Checked = false;
            rdoInactive.Checked = false;

            cboCollector.Text = "";
            cboPaymentTerms.Text = "";
            cboShipMethod.Text = "";

            txtCreditLimit.Clear();
            txtCATaxExempt.Clear();
            txtWATaxExempt.Clear();
            txtMOTaxExempt.Clear();

            lbBranches.Items.Clear();

            SubscribeToStateChangedEvents();
        }

        private void SetUpBranchesListBox()
        {
            lbBranches.Items.Clear();

            if (customer.IsHQ)
            {
                var branchCustIDs = customer.Branches.Select(c => c.Id).ToList();
                branchCustIDs.ForEach(c => lbBranches.Items.Add(c));
                lblBranches.Text = "Branches";
            }

            if (customer.IsBranch)
            {
                lbBranches.Items.Add(customer.Parents[0].Id);
                lblBranches.Text = "Headquarters";
            }

            lbBranches.Visible = !customer.IsStandAlone;
            lblBranches.Visible = !customer.IsStandAlone;
        }

        private void SetUpAccountTypeSpecificControls()
        {
            grpBranchSettings.Visible = customer.IsBranch && isInCustCreate;
            dgvBranches.Visible = customer.IsHQ && isInCustCreate;
            dgvBranches.ReadOnly = !isSuper;
            lblManageBranches.Visible = customer.IsHQ && isSuper;
            lblBranchCount.Visible = customer.IsHQ && isSuper;
            chkNuclearHold.Visible = customer.IsHQ && isInCustCreate;
            btnCreateHQ.Enabled = customer.IsStandAlone || customer.IsHQ;
            cboCollector.Enabled = customer.IsHQ || customer.IsStandAlone;

            if (customer.IsStandAlone)
                btnCreateHQ.Text = "Convert to HQ";

            if (customer.IsHQ)
            {
                LoadBranchesDataGridView();
                btnCreateHQ.Text = "Delete National Account";
            }

            if (customer.IsBranch)
                SetBranchControls();
        }

        private void SetBranchControls()
        {
            UnsubscribeFromStateChangedEvents();

            cboDefaultBillTo.Items.Add("HQ");
            cboDefaultBillTo.Items.Add("Branch");
            cboDefaultBillTo.SelectedIndex = customer.BillToNationalAcctParent == 1 ? 0 : 1;

            chkAllowParentToPay.Checked = customer.PmtByNationalAcctParent == 1;
            chkConsolidatedStatement.Checked = customer.ConsolidatedStatement == 1;

            SubscribeToStateChangedEvents();
        }

        private void LoadBranchesDataGridView()
        {
            loading = true;

            dgvBranches.Rows.Clear();

            foreach (var branch in customer.Branches)
            {
                var index = dgvBranches.Rows.Add();
                var row = dgvBranches.Rows[index];

                row.Cells["CustomerID"].Value = branch.Id;
                row.Cells["CustomerID"].ReadOnly = true;
                row.Cells["CustomerName"].Value = branch.Name;
                row.Cells["ApplyCreditLimit"].Value = branch.CreditLimitUsed == 1;
                row.Cells["CreditLimit"].Value = branch.CreditLimit;
                var comboBoxBillTo = (row.Cells["DefaultBillTo"] as DataGridViewComboBoxCell);
                comboBoxBillTo.Items.Add("HQ");
                comboBoxBillTo.Items.Add("Branch");
                comboBoxBillTo.Value = branch.BillToNationalAcctParent == 1 ? "HQ" : "Branch";
                row.Cells["AllowParentToPay"].Value = branch.PmtByNationalAcctParent == 1;
                row.Cells["ConsolidatedStatement"].Value = branch.ConsolidatedStatement == 1;
            }

            lblBranchCount.Text = "Count: " + customer.Branches.Count.ToString();
            lblBranchCount.ForeColor = customer.Branches.Count == 0 ? Color.Red : Color.Green;

            loading = false;
        }

        private void LoadCustomerDetails()
        {
            UnsubscribeFromStateChangedEvents();

            txtAccountType.Text = DetermineAccountType();
            txtCustomerID.Text = customer.Id;
            txtCustName.Text = customer.Name;
            txtCreateDate.Text = customer.CreateDate == null ? "" : Convert.ToDateTime(customer.CreateDate).ToString("MM/dd/yyyy");
            rdoEndUser.Checked = customer.CustClassKey == 38;
            rdoDealer.Checked = customer.CustClassKey == 40;
            rdoWholesaler.Checked = customer.CustClassKey == 44;
            chkStatements.Checked = customer.UserFld3 == "99";
            chkPricePackingSlip.Checked = customer.UserFld2 == "Yes";
            chkPORequired.Checked = customer.ReqPO == 1;
            rdoActive.Checked = customer.Status == 1;
            rdoInactive.Checked = customer.Status == 2;
            rdoNeverOnHold.Checked = arStatus.HoldStatusId == "VIP";
            rdoAlwaysOnHold.Checked = arStatus.HoldStatusId == "Manual_Hold";
            rdoStatusUpdate.Checked = arStatus.HoldStatusId == "Auto_Hold" || arStatus.HoldStatusId == "Good";
            txtAgingDate.Text = arStatus.AgingDate == null ? "" : Convert.ToDateTime(arStatus.AgingDate).ToShortDateString();
            txtHoldStatus.Text = arStatus.ARStatus;
            txtOnHold.Text = arStatus.HoldStatusKey == null ? "No" : (int)arStatus.HoldStatusKey.GetValueOrDefault() > 2 ? "Yes" : "No";

            SetNuclearHold();
            SetCreditLimit();
            SetTaxExemptions();
            SetCollectors();
            SetPaymentTerms();
            SetShipMethod();

            SubscribeToStateChangedEvents();
        }

        private void SetNuclearHold()
        {
            if (customer.IsHQ)
            {
                chkNuclearHold.Checked = customer.NationalAccountLevel.NationalAccount.Hold == 1;
            }
        }

        private void SetCreditLimit()
        {
            var periodIndex = customer.CreditLimit.ToString().IndexOf('.');
            if (periodIndex == -1)
                txtCreditLimit.Text = "$" + customer.CreditLimit.ToString() + ".00";
            else
                txtCreditLimit.Text = "$" + customer.CreditLimit.ToString().Substring(0, periodIndex + 3);
        }

        private void SetTaxExemptions()
        {
            var caTaxExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("CA"));
            var waTaxExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("WA"));
            var moTaxExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("MO"));

            txtCATaxExempt.Text = caTaxExemption == null ? "" : caTaxExemption.ExemptNo;
            txtWATaxExempt.Text = waTaxExemption == null ? "" : waTaxExemption.ExemptNo;
            txtMOTaxExempt.Text = moTaxExemption == null ? "" : moTaxExemption.ExemptNo;
        }

        private void SetCollectors()
        {
            var index = collectorGroup.Users.FindIndex(c => c.UserID == customer.UserFld1);
            if (index == -1)
            {
                cboCollector.Text = customer.UserFld1;
            }
            else
            {
                cboCollector.SelectedIndex = index;
            }
        }

        private string DetermineAccountType()
        {
            if (customer.IsStandAlone)
                return "Single-Branch";
            else if (customer.IsBranch)
                return "Branch";
            else if (customer.IsHQ)
                return "Headquarters";
            else
                return "Failed to Qualify";
        }

        private void SetPaymentTerms()
        {
            var custAddr = customer.CustAddresses.First(c => c.Key == customer.PrimaryAddrKey);
            var paymentTerm = paymentTerms.First(c => c.Key == custAddr.PmtTermsKey);
            cboPaymentTerms.Text = paymentTerm.Id;
        }

        private void SetShipMethod()
        {
            var custAddr = customer.CustAddresses.First(c => c.Key == customer.PrimaryAddrKey);
            if (custAddr.ShipMethKey == null)
            {
                cboShipMethod.Text = "";
            }
            else
            {
                cboShipMethod.Text = shipMethods.First(c => c.Key == custAddr.ShipMethKey).ShipMethID;
            }
        }

        private void EnableCustomerControls()
        {
            grpGeneral.Enabled = isSuper;
            grpOptions.Enabled = isSuper;
            grpBranchSettings.Enabled = isSuper;
            grpOptions.Enabled = isSuper;
            grpARStatus.Enabled = isSuper;
            grpClass.Enabled = isSuper;
            grpAccountStatus.Enabled = isSuper;
            chkNuclearHold.Enabled = isSuper;
            grpTaxExmpt.Enabled = isInCustCreate;

            //credit group box
            grpCredit.Enabled = true;
            txtCreditLimit.Enabled = isSuper;
            cboCollector.Enabled = isSuper;
            cboPaymentTerms.Enabled = isInCustCreate;

            btnCreditCards.Enabled = isInCC;
            btnCreateAccount.Enabled = isInCustCreate;
            btnAddresses.Enabled = true;
            btnContacts.Enabled = true;
            btnSave.Enabled = false;
            remarkViewer.Enabled = true;
        }
        #endregion








        #region SAVE CUSTOMER
        //SAVE CUSTOMER
        private async void btnSave_Click(object sender, EventArgs e)
        {
            SyncAllCustAddresses();

            if (taxExemptionsWereAltered)
            {
                SetAcuityTaxExemptions();
                SetCPCTaxExemptions();
            }

            if (arStatusTypeChanged)
                UpdateARStatus();


            customerService.UpdateCustomer(customer);

            btnSave.Enabled = false;
            isDirty = false;

            customerService = new CustomerService();
            standAloneCustIds = await customerService.GetStandAloneCustIds();
            await SetCustIDTextBoxCustIdsSourceAsync();

            ReloadCurrentCustomerAndRefreshUI();

            lblGeneralStatus.ForeColor = Color.Green;
            lblGeneralStatus.Text = "Customer has been updated.";
        }

        private void UpdateARStatus()
        {
            if (rdoAlwaysOnHold.Checked)
                arStatus.Update(customer.Key, AccountStatus.ManualHold);

            if (rdoStatusUpdate.Checked)
                arStatus.Update(customer.Key, AccountStatus.AutoHold);

            if (rdoNeverOnHold.Checked)
                arStatus.Update(customer.Key, AccountStatus.VIP);

            arStatusTypeChanged = false;
        }

        private void SyncAllCustAddresses()
        {
            var primaryCustAddr = customer.CustAddresses.First(c => c.Key == customer.PrimaryAddrKey);

            foreach (var custAddr in customer.CustAddresses)
            {
                custAddr.ShipMethKey = primaryCustAddr.ShipMethKey;
                custAddr.PmtTermsKey = primaryCustAddr.PmtTermsKey;
            }
        }


        private void ReloadCurrentCustomerAndRefreshUI()
        {
            var currentText = txtCustID.Text;
            txtCustID.Text = customer.Id;
            Search();
            txtCustID.Text = currentText;
        }
        #endregion








        #region CONTROL STATE CHANGED
        //CONTROL STATE CHANGED
        private void UnsubscribeFromStateChangedEvents()
        {
            txtCreditLimit.TextChanged -= txtCreditLimit_TextChanged;
            cboPaymentTerms.SelectedIndexChanged -= cboPaymentTerms_SelectedIndexChanged;
            rdoEndUser.CheckedChanged -= rdoEndUser_CheckedChanged;
            rdoDealer.CheckedChanged -= rdoDealer_CheckedChanged;
            rdoWholesaler.CheckedChanged -= rdoWholesaler_CheckedChanged;
            chkStatements.CheckedChanged -= chkInvoiceCopies_CheckedChanged;
            chkPricePackingSlip.CheckedChanged -= chkPricePackingSlip_CheckedChanged;
            chkPORequired.CheckedChanged -= chkPORequired_CheckedChanged;
            cboShipMethod.SelectedIndexChanged -= cboShipMethod_SelectedIndexChanged;
            cboCollector.SelectedIndexChanged -= cboCollector_SelectedIndexChanged;
            rdoInactive.CheckedChanged -= rdoInActive_CheckedChanged;
            rdoActive.CheckedChanged -= rdoActive_CheckedChanged;
            chkNuclearHold.CheckedChanged -= chkNuclearHold_CheckedChanged;

            rdoAlwaysOnHold.CheckedChanged -= rdoAlwaysOnHold_CheckedChanged;
            rdoNeverOnHold.CheckedChanged -= rdoNeverOnHold_CheckedChanged;
            rdoStatusUpdate.CheckedChanged -= rdoStatusUpdate_CheckedChanged;

            cboDefaultBillTo.SelectedIndexChanged -= cboDefaultBillTo_SelectedIndexChanged;
            chkAllowParentToPay.CheckedChanged -= chkAllowParentToPay_CheckedChanged;
            chkConsolidatedStatement.CheckedChanged -= chkConsolidatedStatement_CheckedChanged;

            txtCATaxExempt.TextChanged -= txtCATaxExempt_TextChanged;
            txtWATaxExempt.TextChanged -= txtWATaxExempt_TextChanged;
            txtMOTaxExempt.TextChanged -= txtMOTaxExempt_TextChanged;
        }

        private void SubscribeToStateChangedEvents()
        {
            txtCreditLimit.TextChanged += txtCreditLimit_TextChanged;
            cboPaymentTerms.SelectedIndexChanged += cboPaymentTerms_SelectedIndexChanged;
            rdoEndUser.CheckedChanged += rdoEndUser_CheckedChanged;
            rdoDealer.CheckedChanged += rdoDealer_CheckedChanged;
            rdoWholesaler.CheckedChanged += rdoWholesaler_CheckedChanged;
            chkStatements.CheckedChanged += chkInvoiceCopies_CheckedChanged;
            chkPricePackingSlip.CheckedChanged += chkPricePackingSlip_CheckedChanged;
            chkPORequired.CheckedChanged += chkPORequired_CheckedChanged;
            cboShipMethod.SelectedIndexChanged += cboShipMethod_SelectedIndexChanged;
            cboCollector.SelectedIndexChanged += cboCollector_SelectedIndexChanged;
            rdoInactive.CheckedChanged += rdoInActive_CheckedChanged;
            rdoActive.CheckedChanged += rdoActive_CheckedChanged;
            chkNuclearHold.CheckedChanged += chkNuclearHold_CheckedChanged;

            rdoAlwaysOnHold.CheckedChanged += rdoAlwaysOnHold_CheckedChanged;
            rdoNeverOnHold.CheckedChanged += rdoNeverOnHold_CheckedChanged;
            rdoStatusUpdate.CheckedChanged += rdoStatusUpdate_CheckedChanged;


            cboDefaultBillTo.SelectedIndexChanged += cboDefaultBillTo_SelectedIndexChanged;
            chkAllowParentToPay.CheckedChanged += chkAllowParentToPay_CheckedChanged;
            chkConsolidatedStatement.CheckedChanged += chkConsolidatedStatement_CheckedChanged;

            txtCATaxExempt.TextChanged += txtCATaxExempt_TextChanged;
            txtWATaxExempt.TextChanged += txtWATaxExempt_TextChanged;
            txtMOTaxExempt.TextChanged += txtMOTaxExempt_TextChanged;
        }

        private void chkNuclearHold_CheckedChanged(object sender, EventArgs e)
        {
            customer.NationalAccountLevel.NationalAccount.Hold = chkNuclearHold.Checked ? (short)1 : (short)0;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void txtCreditLimit_TextChanged(object sender, EventArgs e)
        {
            rfvCreditLimit.Validate();

            try
            {
                var input = txtCreditLimit.Text.TrimEnd().Replace("$", "");
                customer.CreditLimit = Convert.ToDecimal(input);
                btnSave.Enabled = true;
                isDirty = true;
                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Customer has been modified";

            }
            catch
            {
                customer.CreditLimit = 0;
                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Error could not convert credit limit to decimal number.";

            }
        }

        private void cboPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paymentTerms = this.paymentTerms.First(c => c.Id == cboPaymentTerms.Text);
            customer.CustAddresses.First(c => c.Key == customer.PrimaryAddrKey).PmtTermsKey = paymentTerms.Key;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void rdoEndUser_CheckedChanged(object sender, EventArgs e)
        {
            //38 enduser
            //40 dealer
            //44 wholesaler
            customer.CustClassKey = 38;
            var primaryCustAddr = customer.CustAddresses.FirstOrDefault(c => c.Key == customer.PrimaryAddrKey);
            if (primaryCustAddr != null)
                primaryCustAddr.CustPriceGroupKey = 9;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void rdoDealer_CheckedChanged(object sender, EventArgs e)
        {
            customer.CustClassKey = 40;
            var primaryCustAddr = customer.CustAddresses.FirstOrDefault(c => c.Key == customer.PrimaryAddrKey);
            if (primaryCustAddr != null)
                primaryCustAddr.CustPriceGroupKey = 8;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void rdoWholesaler_CheckedChanged(object sender, EventArgs e)
        {
            customer.CustClassKey = 44;
            var primaryCustAddr = customer.CustAddresses.FirstOrDefault(c => c.Key == customer.PrimaryAddrKey);
            if (primaryCustAddr != null)
                primaryCustAddr.CustPriceGroupKey = 7;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void chkInvoiceCopies_CheckedChanged(object sender, EventArgs e)
        {
            customer.UserFld3 = chkStatements.Checked ? "99" : "1";
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void chkPricePackingSlip_CheckedChanged(object sender, EventArgs e)
        {
            customer.UserFld2 = chkPricePackingSlip.Checked ? "Yes" : "No";
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void chkPORequired_CheckedChanged(object sender, EventArgs e)
        {
            customer.ReqPO = chkPORequired.Checked ? (short)1 : (short)0;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void cboShipMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shipMeth = shipMethods.First(c => c.ShipMethID == cboShipMethod.Text);
            customer.CustAddresses.First(c => c.Key == customer.PrimaryAddrKey).ShipMethKey = shipMeth.Key;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";

        }

        private void cboDefaultBillTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer.BillToNationalAcctParent = cboDefaultBillTo.Text == "HQ" ? (short)1 : (short)0;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void chkAllowParentToPay_CheckedChanged(object sender, EventArgs e)
        {
            customer.PmtByNationalAcctParent = chkAllowParentToPay.Checked ? (short)1 : (short)0;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void chkConsolidatedStatement_CheckedChanged(object sender, EventArgs e)
        {
            customer.ConsolidatedStatement = chkConsolidatedStatement.Checked ? (short)1 : (short)0;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void cboCollector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer.UserFld1 != cboCollector.Text)
            {
                customer.UserFld1 = cboCollector.Text.TrimEnd();
                btnSave.Enabled = true;
                isDirty = true;
                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Customer has been modified";
            }
        }

        private void rdoActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoActive.Checked)
            {
                customer.Status = 1;
                btnSave.Enabled = true;
                isDirty = true;
                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Customer has been modified";
            }
        }

        private void rdoInActive_CheckedChanged(object sender, EventArgs e)
        {
            if (customer.IsStandAlone)
            {
                customer.Status = rdoInactive.Checked ? (short)2 : (short)1;
                btnSave.Enabled = true;
                isDirty = true;
                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Customer has been modified";
            }
            else if (rdoInactive.Checked)
            {
                rdoInactive.CheckedChanged -= rdoInActive_CheckedChanged;
                rdoActive.CheckedChanged -= rdoActive_CheckedChanged;

                rdoInactive.Checked = false;
                rdoActive.Checked = true;

                rdoInactive.CheckedChanged += rdoInActive_CheckedChanged;
                rdoActive.CheckedChanged += rdoActive_CheckedChanged;


                lblGeneralStatus.ForeColor = Color.Red;
                lblGeneralStatus.Text = "Only deleting stand alone account is allowed.";
            }
        }

        private void rdoNeverOnHold_CheckedChanged(object sender, EventArgs e)
        {
            arStatusTypeChanged = true;
            btnSave.Enabled = true;
        }

        private void rdoAlwaysOnHold_CheckedChanged(object sender, EventArgs e)
        {
            arStatusTypeChanged = true;
            btnSave.Enabled = true;
        }

        private void rdoStatusUpdate_CheckedChanged(object sender, EventArgs e)
        {
            arStatusTypeChanged = true;
            btnSave.Enabled = true;
        }
        #endregion









        #region TAX EXEMPTION CHANGED
        private void txtCATaxExempt_TextChanged(object sender, EventArgs e)
        {
            taxExemptionsWereAltered = true;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void txtWATaxExempt_TextChanged(object sender, EventArgs e)
        {
            taxExemptionsWereAltered = true;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void txtMOTaxExempt_TextChanged(object sender, EventArgs e)
        {
            taxExemptionsWereAltered = true;
            btnSave.Enabled = true;
            isDirty = true;
            lblGeneralStatus.ForeColor = Color.Red;
            lblGeneralStatus.Text = "Customer has been modified";
        }

        private void SetMOCPCTaxExemption()
        {
            var moExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("MO"));

            if (string.IsNullOrEmpty(txtMOTaxExempt.Text.TrimEnd())) //deleting exemption
            {
                if (moExemption != null)
                {
                    customer.TaxExemptionsCPC.Remove(moExemption);
                }
            }
            else //adding or updating exemption
            {
                if (moExemption == null) //user trying to add new
                {
                    customer.TaxExemptionsCPC.Add(new TaxExemptionCPC
                    {
                        CustKey = customer.Key,
                        State = "MO",
                        ExemptNo = txtMOTaxExempt.Text.TrimEnd()
                    });
                }
                else //user trying to update existing
                {
                    moExemption.ExemptNo = txtMOTaxExempt.Text.TrimEnd();
                }
            }
        }

        private void SetWACPCTaxExemption()
        {
            var waExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("WA"));

            if (string.IsNullOrEmpty(txtWATaxExempt.Text.TrimEnd())) //deleting exemption
            {
                if (waExemption != null)
                {
                    customer.TaxExemptionsCPC.Remove(waExemption);
                }
            }
            else //add or update exemption
            {
                if (waExemption == null) //user trying to add new
                {
                    customer.TaxExemptionsCPC.Add(new TaxExemptionCPC
                    {
                        CustKey = customer.Key,
                        State = "WA",
                        ExemptNo = txtWATaxExempt.Text.TrimEnd()
                    });
                }
                else //user trying to update existing
                {
                    waExemption.ExemptNo = txtWATaxExempt.Text.TrimEnd();
                }
            }
        }

        private void SetCACPCTaxExemption()
        {
            var caExemption = customer.TaxExemptionsCPC.FirstOrDefault(c => c.State.Contains("CA"));

            if (string.IsNullOrEmpty(txtCATaxExempt.Text.TrimEnd())) //deleting exemption
            {
                if (caExemption != null)
                {
                    customer.TaxExemptionsCPC.Remove(caExemption);
                }
            }
            else //adding or updating exemption
            {
                if (caExemption == null) //user trying to add new
                {
                    customer.TaxExemptionsCPC.Add(new TaxExemptionCPC
                    {
                        CustKey = customer.Key,
                        State = "CA",
                        ExemptNo = txtCATaxExempt.Text.TrimEnd()
                    });
                }
                else //user trying to update existing
                {
                    caExemption.ExemptNo = txtCATaxExempt.Text.TrimEnd();
                }
            }
        }


        private void SetCPCTaxExemptions()
        {
            SetCACPCTaxExemption();
            SetWACPCTaxExemption();
            SetMOCPCTaxExemption();
        }

        private void SetAcuityTaxExemptions()
        {
            bool doCATaxExemptions = !string.IsNullOrEmpty(txtCATaxExempt.Text.TrimEnd()); //not null or empty
            bool doWATaxExemptions = !string.IsNullOrEmpty(txtWATaxExempt.Text.TrimEnd());
            bool doMOTaxExemptions = !string.IsNullOrEmpty(txtMOTaxExempt.Text.TrimEnd());

            AddTaxExemptionsToCustAddresses(doCATaxExemptions, doWATaxExemptions, doMOTaxExemptions);

            taxExemptionsWereAltered = false;
        }

        private void AddTaxExemptionsToCustAddresses(bool addCA, bool addWA, bool addMO)
        {
            //create lists to hold onto taxcodes from current addresses
            var caTaxCodes = new List<TaxCode>();
            var waTaxCodes = new List<TaxCode>();
            var moTaxCodes = new List<TaxCode>();

            //loop through all cust addresses
            foreach (var custAddr in customer.CustAddresses)
            {
                //get all tax codes bundled in a list
                if (custAddr.Address.State == "CA")
                    caTaxCodes.AddRange(custAddr.TaxSchedule.TaxCodes);

                if (custAddr.Address.State == "WA")
                    waTaxCodes.AddRange(custAddr.TaxSchedule.TaxCodes);

                if (custAddr.Address.State == "MO")
                    moTaxCodes.AddRange(custAddr.TaxSchedule.TaxCodes);
            }

            //clear current tax exemptions list
            customer.CustAddresses.ForEach(custAddr => custAddr.TaxExemptionsAcuity.Clear());

            //distinct only
            if (caTaxCodes.Count != 0)
                caTaxCodes = caTaxCodes.GroupBy(c => c.Key).Select(c => c.First()).ToList();

            if (waTaxCodes.Count != 0)
                waTaxCodes = waTaxCodes.GroupBy(c => c.Key).Select(c => c.First()).ToList();

            if (moTaxCodes.Count != 0)
                moTaxCodes = moTaxCodes.GroupBy(c => c.Key).Select(c => c.First()).ToList();

            //add tax codes and exemptions belonging to CA
            if (addCA)
            {
                foreach (var caTaxCode in caTaxCodes)
                {
                    foreach (var custAddr in customer.CustAddresses)
                    {
                        custAddr.TaxExemptionsAcuity.Add(new TaxExemptionAcuity
                        {
                            AddrKey = custAddr.Key,
                            STaxCodeKey = caTaxCode.Key,
                            ExmptNo = txtCATaxExempt.Text.TrimEnd()
                        });
                    }
                }
            }


            //add tax codes and exemption belonging to MO
            if (addMO)
            {
                foreach (var moTaxCode in moTaxCodes)
                {
                    foreach (var custAddr in customer.CustAddresses)
                    {
                        custAddr.TaxExemptionsAcuity.Add(new TaxExemptionAcuity
                        {
                            AddrKey = custAddr.Key,
                            STaxCodeKey = moTaxCode.Key,
                            ExmptNo = txtMOTaxExempt.Text.TrimEnd()
                        });
                    }
                }
            }


            //add tax codes and exemption belonging to WA
            if (addWA)
            {
                foreach (var waTaxCode in waTaxCodes)
                {
                    foreach (var custAddr in customer.CustAddresses)
                    {
                        custAddr.TaxExemptionsAcuity.Add(new TaxExemptionAcuity
                        {
                            AddrKey = custAddr.Key,
                            STaxCodeKey = waTaxCode.Key,
                            ExmptNo = txtWATaxExempt.Text.TrimEnd()
                        });
                    }
                }
            }
        }

        #endregion









        #region MANAGERS
        //SEARCH ZIP / PHONE
        private void txtPhoneZipSearch_Click(object sender, EventArgs e)
        {
            var lookupForm = new LookUpAccountForm();
            lookupForm.EnableDoubleClick();
            lookupForm.DoubleClicked += (custId) =>
            {
                txtCustID.Text = custId;
                Search();
            };

            lookupForm.ShowDialog();
        }







        //MANAGE ADDRESSES
        private async void btnAddresses_Click(object sender, EventArgs e)
        {
            if (customer.Key != 0)
            {
                NotifyIfCustomerIsDirty();

                var addrViewer = new AddressManagerForm();
                addrViewer.Initialize(customer.Key, customerService);
                addrViewer.ShowDialog();

                //reload customer
                customerService = new CustomerService();
                standAloneCustIds = await customerService.GetStandAloneCustIds();
                await SetCustIDTextBoxCustIdsSourceAsync();
                customer = customerService.LoadCustomerWithDependenciesByKey(customer.Key);

                txtCustomerID.Text = customer.Id;
                txtCustName.Text = customer.Name;
            }
        }






        //MANAGE CONTACTS
        private void btnContacts_Click(object sender, EventArgs e)
        {
            if (customer.Key != 0)
            {
                var contactViewer = new ContactManagerForm();
                contactViewer.Initialize(customer.Key, ContactManager.Module.AR);
                contactViewer.ShowDialog();

                //reload customer
                var id = customer.Id;
                customerService = new CustomerService();
                customer = customerService.LoadCustomerWithDependenciesById(id);
            }
        }






        //MANAGE CREDIT CARDS
        private void btnCreditCards_Click(object sender, EventArgs e)
        {
            if (customer.Key != 0)
            {
                var ccManager = new CreditCardForm();
                ccManager.Initialize(customer.Key, CreditCardManager.Module.AR);
                ccManager.ShowDialog();
            }
        }







        //NAVIGATE TO CREATE ACCOUNT WIZARD
        private async void Wizard_Done(string _custID)
        {
            customerService = new CustomerService();
            standAloneCustIds = await customerService.GetStandAloneCustIds();
            await SetCustIDTextBoxCustIdsSourceAsync();

            txtCustID.Text = _custID;
            Search();
        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var wizard = new CreateAccountForm();
            wizard.Done += Wizard_Done;
            wizard.ShowDialog();
        }
        #endregion








        #region CREATE / DELETE NATIONAL ACCOUNT
        private async void btnCreateHQ_Click(object sender, EventArgs e)
        {
            if (customer.IsStandAlone)
            {
                var result = MessageBox.Show("Are you sure you want to convert this account to a National Account HQ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await CreateNationalAccount();
                }
            }

            else if (customer.IsHQ)
            {
                var result = MessageBox.Show("Are you sure you want to DELETE this national account?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await DestroyNationalAccount();
                }
            }
        }

        private async Task CreateNationalAccount()
        {
            customerService.CreateNationalAccount(customer);

            ReloadCurrentCustomerAndRefreshUI();

            lblGeneralStatus.Text = "HQ has been created!";
            lblGeneralStatus.ForeColor = Color.Green;

            standAloneCustIds = await customerService.GetStandAloneCustIds();
            await SetCustIDTextBoxCustIdsSourceAsync();
        }

        private async Task DestroyNationalAccount()
        {
            try
            {
                customerService.DeleteNationalAccount(customer);

                ReloadCurrentCustomerAndRefreshUI();

                lblGeneralStatus.Text = "National Account has been deleted.";
                lblGeneralStatus.ForeColor = Color.Green;

                standAloneCustIds = await customerService.GetStandAloneCustIds();
                await SetCustIDTextBoxCustIdsSourceAsync();
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached)
                    throw ex;
                else
                    MessageBox.Show("Error could not delete national account.");
            }
        }
        #endregion








        #region ADD BRANCH / MANAGE BRANCH

        private async void dgvBranches_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (loading) return;
            if (e.RowIndex < 0) return;

            int currentRowIndex = e.RowIndex;
            int branchesIndexesCount = customer.Branches.Count - 1;
            bool moreRowsThanBranches = currentRowIndex > branchesIndexesCount;
            bool isInCustomerIDCell = e.ColumnIndex == 0;

            if ((moreRowsThanBranches) && (isInCustomerIDCell)) //user trying to add a new branch
            {
                bool success = ValidateCustId(e.RowIndex);
                if (success)
                {
                    await AddNewBranch(e.RowIndex);
                }
                else
                {
                    RemoveCellValuesOnCurrentRow(e.RowIndex);
                }

                return;
            }
            else if ((moreRowsThanBranches) && (!isInCustomerIDCell)) //editing a cell that has no branch
            {
                lblGeneralStatus.Text = "This row has no branch yet. Enter the Customer ID to load an account first.";
                lblGeneralStatus.ForeColor = Color.Red;

                loading = true;
                dgvBranches.Rows.RemoveAt(e.RowIndex);
                loading = false;

                return;
            }


            //trying to edit a valid cell with a branch
            var branch = customer.Branches[e.RowIndex];
            var value = dgvBranches.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (dgvBranches.Columns[e.ColumnIndex].Name)
            {
                case "ApplyCreditLimit":
                    branch.CreditLimitUsed = (bool)value == true ? (short)1 : (short)0;
                    break;

                case "CreditLimit":
                    decimal result;
                    if (Decimal.TryParse((string)value, out result))
                    {
                        branch.CreditLimit = result;
                        break;
                    }
                    else
                    {
                        lblGeneralStatus.Text = "Error -Unable to set credit limit. Must be numeric.";
                        lblGeneralStatus.ForeColor = Color.Red;
                        return;
                    }

                case "DefaultBillTo":
                    branch.BillToNationalAcctParent = (string)value == "HQ" ? (short)1 : (short)0;
                    break;

                case "AllowParentToPay":
                    branch.PmtByNationalAcctParent = (bool)value == true ? (short)1 : (short)0;
                    break;

                case "ConsolidatedStatement":
                    branch.ConsolidatedStatement = (bool)value == true ? (short)1 : (short)0;
                    break;
            }

            customerService.UpdateCustomer(customer);

            lblGeneralStatus.ForeColor = Color.Green;
            lblGeneralStatus.Text = $"{branch.Name} has been updated";
        }


        private bool ValidateCustId(int rowIndex)
        {
            var custID = (string)dgvBranches.Rows[rowIndex].Cells[0].Value ?? "";

            var match = standAloneCustIds.FirstOrDefault(c => c.TrimEnd() == custID.TrimEnd());
            return match != null;
        }

        private async Task AddNewBranch(int rowIndex)
        {
            var custID = (string)dgvBranches.Rows[rowIndex].Cells[0].Value ?? "";
            var branch = customerService.LoadCustomerWithDependenciesById(custID);

            customerService.AddBranchToNationalAccount(branch, customer);

            ReloadCurrentCustomerAndRefreshUI();
            btnSave.Enabled = false;
            isDirty = false;
            lblGeneralStatus.Text = "Branch has been added.";
            lblGeneralStatus.ForeColor = Color.Green;

            standAloneCustIds = await customerService.GetStandAloneCustIds();
            await SetCustIDTextBoxCustIdsSourceAsync();
        }


        private void RemoveCellValuesOnCurrentRow(int rowIndex)
        {
            var custID = (string)dgvBranches.Rows[rowIndex].Cells[0].Value ?? "";

            lblGeneralStatus.Text = "'" + custID + "' is not a valid stand alone account.";
            lblGeneralStatus.ForeColor = Color.Red;

            loading = true;
            dgvBranches.Rows[rowIndex].Cells["CustomerName"].Value = "";
            dgvBranches.Rows[rowIndex].Cells["ApplyCreditLimit"].Value = false;
            dgvBranches.Rows[rowIndex].Cells["CreditLimit"].Value = 0;
            dgvBranches.Rows[rowIndex].Cells["AllowParentToPay"].Value = false;
            dgvBranches.Rows[rowIndex].Cells["ConsolidatedStatement"].Value = false;
            dgvBranches.Rows[rowIndex].Cells["DefaultBillTo"].Value = "";
            loading = false;
        }




        private void dgvBranches_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (loading) return;

            //dont commit if it's the custid column. wait till loses focus. (default behavior)
            if (dgvBranches.IsCurrentCellDirty && dgvBranches.CurrentCell.ColumnIndex != 0)
            {
                dgvBranches.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvBranches_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvBranches.CurrentCell.ColumnIndex == 0)
            {
                //set the auto complete properties
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.AutoCompleteCustomSource.Clear();
                    txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txt.AutoCompleteCustomSource.AddRange(standAloneCustIds.ToArray());
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.CharacterCasing = CharacterCasing.Upper;
                }
            }
            else
            {
                if (e.Control is TextBox)
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.AutoCompleteMode = AutoCompleteMode.None;
                        txt.AutoCompleteSource = AutoCompleteSource.None;
                        txt.CharacterCasing = CharacterCasing.Normal;
                    }
                }
            }
        }

        private void dgvBranches_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //disable cell after branch has been added
                dgvBranches.Rows[e.RowIndex].Cells[0].ReadOnly = true;
            }
        }

        private void dgvBranches_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //if branch is not valid allow custid to be changed
                var value = (string)dgvBranches.Rows[e.RowIndex].Cells[0].Value ?? "";

                var match = standAloneCustIds.FirstOrDefault(c => c == value.TrimEnd());
                var branch = customer.Branches.FirstOrDefault(c => c.Id.TrimEnd() == value.TrimEnd());

                if (match == null && branch == null)
                {
                    dgvBranches.Rows[e.RowIndex].Cells[0].ReadOnly = false;
                }
                else
                {
                    dgvBranches.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                }
            }
        }
        #endregion








        #region DELETE BRANCH

        private Customer currentBranch;

        private void dgvBranches_MouseClick(object sender, MouseEventArgs e)
        {
            int currentRowIndex = dgvBranches.HitTest(e.X, e.Y).RowIndex;
            int currentColIndex = dgvBranches.HitTest(e.X, e.Y).ColumnIndex;
            if (currentRowIndex < 0) return;

            dgvBranches.Rows[currentRowIndex].Cells[currentColIndex].Selected = true;

            string currentBranchID = (string)dgvBranches.Rows[currentRowIndex].Cells["CustomerID"].Value;
            if (string.IsNullOrEmpty(currentBranchID)) return;

            currentBranch = customer.Branches.FirstOrDefault(c => c.Id.Contains(currentBranchID));

            if (e.Button == MouseButtons.Right && customer.IsHQ)
            {
                var menu = new ContextMenu();
                menu.MenuItems.Add("Remove Branch", OnRemoveBranch);

                menu.Show(dgvBranches, new Point(e.X, e.Y));
            }
        }

        private async void OnRemoveBranch(object sender, EventArgs e)
        {
            if (currentBranch != null)
            {
                var result = MessageBox.Show($"You are about to remove {currentBranch.Id}. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    customerService.RemoveBranchFromNationalAccount(customer, currentBranch);

                    var activeLocalContacts = currentBranch.Contacts.Where(c => c.ParentKey == null &&
                                                                                c.Module == "AR" &&
                                                                                !c.IsDeleted).ToList();
                    if (activeLocalContacts.Count > 1) //allow user to choose primary
                    {
                        customerService.UpdateCustomer(currentBranch);

                        var contactManager = new ContactManagerForm();
                        contactManager.Initialize(currentBranch.Key, ContactManager.Module.AR, true);
                        contactManager.SetStatusLabel(Color.Red, "Branch is now a stand alone account. Choose new primary contact");
                        contactManager.ShowDialog();
                        customerService = new CustomerService();
                        customer = customerService.LoadCustomerWithDependenciesById(customer.Id.TrimEnd());
                    }

                    //reload
                    Search();

                    standAloneCustIds = await customerService.GetStandAloneCustIds();
                    await SetCustIDTextBoxCustIdsSourceAsync();
                }
            }
        }
        #endregion








        #region CURRENCY FORMATTING
        private void txtCreditLimit_Enter(object sender, EventArgs e)
        {
            txtCreditLimit.TextChanged -= txtCreditLimit_TextChanged;
            txtCreditLimit.Text = txtCreditLimit.Text.Replace("$", "");
            txtCreditLimit.SelectionStart = 0;
            txtCreditLimit.SelectionLength = txtCreditLimit.Text.Length;
            txtCreditLimit.TextChanged += txtCreditLimit_TextChanged;
        }

        private void txtCreditLimit_Leave(object sender, EventArgs e)
        {
            txtCreditLimit.TextChanged -= txtCreditLimit_TextChanged;

            var inputWithoutCurrencyChar = txtCreditLimit.Text.Replace("$", "");

            var suceeded = decimal.TryParse(inputWithoutCurrencyChar, out decimal creditLimit);
            if (suceeded)
            {
                var periodIndex = creditLimit.ToString().IndexOf('.');
                if (periodIndex == -1)
                    txtCreditLimit.Text = "$" + creditLimit.ToString() + ".00";
                else
                    txtCreditLimit.Text = "$" + creditLimit.ToString().Substring(0, periodIndex + 3);
            }
            txtCreditLimit.TextChanged += txtCreditLimit_TextChanged;
        }




        #endregion








        #region Calling Sheets

        private int currentExcelRow;
        private int totalCustHoldCount;
        private string currentExcelSection;


        private async void btnCallSheets_Click(object sender, EventArgs e)
        {
            callSheetStatusLabel.Visible = true;
            lblLetterStatus.Visible = false;

            btnCreateLetters.Enabled = false;
            btnCallSheets.Enabled = false;

            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbook workbook = excelApplication.Workbooks.Add();

            try
            {
                if (excelApplication == null)
                {
                    MessageBox.Show("Excel is not properly installed.");
                    return;
                }

                // get collectors
                var collectorGroup = lookupService.GetGroupByGroupID("Collectors");
                var collectors = collectorGroup.Users.Where(c => c.UserID != "InCollection" && c.UserID != "WriteOff").ToList();

                foreach (var user in collectors)
                {
                    // get customers on hold
                    var late = customerService.GetLateCustHold(user.UserID);
                    var over = customerService.GetOverCustHold(user.UserID);
                    var credit = customerService.GetCreditCustHold(user.UserID);

                    totalCustHoldCount = late.Count;
                    totalCustHoldCount += over.Count;
                    totalCustHoldCount += credit.Count;

                    if (totalCustHoldCount == 0)
                        continue;

                    // create worksheet per user
                    var worksheet = workbook.Worksheets.Add();

                    // ui
                    progressBarCallSheets.Maximum = totalCustHoldCount + 6;
                    callSheetStatusLabel.Text = $"Generating calling sheet for {user.UserID}...";

                    currentExcelRow = 2;

                    // populate spreadsheet
                    await Task.Run(() =>
                    {
                        currentExcelSection = "LATE CUSTOMERS";
                        FillWorkSheetPartial(late, worksheet);

                        currentExcelSection = "OVER CREDIT LIMIT";
                        FillWorkSheetPartial(over, worksheet);

                        currentExcelSection = "CREDITS";
                        FillWorkSheetPartial(credit, worksheet);
                    });

                    progressBarCallSheets.Value = progressBarCallSheets.Maximum;
                    callSheetCountLabel.Text = "Current row: " + totalCustHoldCount.ToString() + "/" + totalCustHoldCount.ToString();


                    callSheetStatusLabel.Text = $"Laying out sheet for printing..";
                    callSheetCountLabel.Text = "";
                    progressBarCallSheets.Visible = false;

                    // lay out spreadsheet
                    await Task.Run(() =>
                    {
                        worksheet.Name = user.UserID;
                        worksheet.Range("A1:M1").value = new string[] { "CustID", "CustName", "Contact", "Phone", "Ext", "90+", "60+", "45+", "Total", "Late", "Over", "Terms", "Status" };
                        worksheet.Range("A1:M1").Font.Bold = true;
                        worksheet.Cells.Font.Name = "Arial";
                        worksheet.Cells.Font.Size = 7;
                        worksheet.Rows.RowHeight = 15;

                        var range = worksheet.Range("D1").EntireColumn;
                        range.TextToColumns();
                        range.NumberFormat = "[<=9999999]###-####;(###) ###-####";

                        worksheet.Range("F2:K2").EntireColumn.NumberFormat = "#,##0.00";
                        worksheet.Columns("A:J").AutoFit();
                        worksheet.Columns("K").ColumnWidth = 5.9;
                        worksheet.Columns("L:M").AutoFit();
                    });

                    await Task.Run(() =>
                    {
                        worksheet.PageSetup.Orientation = 2;
                        worksheet.PageSetup.PrintTitleRows = "$1:$1";
                        worksheet.PageSetup.LeftFooter = worksheet.Name;
                        worksheet.PageSetup.CenterFooter = DateTime.Now;
                        worksheet.PageSetup.RightFooter = "Page &P";
                        worksheet.PageSetup.TopMargin = excelApplication.InchesToPoints(0.5);
                        worksheet.PageSetup.HeaderMargin = excelApplication.InchesToPoints(0.5);
                        worksheet.PageSetup.LeftMargin = excelApplication.InchesToPoints(0.1);
                        worksheet.PageSetup.RightMargin = excelApplication.InchesToPoints(0.1);
                        worksheet.PageSetup.BottomMargin = excelApplication.InchesToPoints(0.6);
                        worksheet.PageSetup.FooterMargin = excelApplication.InchesToPoints(0.2);
                    });
                }

                callSheetStatusLabel.Text = "Saving spreadsheet...";

                // save spreadsheet
                var collectionsPath = ConfigurationManager.AppSettings["Collections"];
                workbook.SaveAs(string.Format(@"{0}Collections{1}.xls", collectionsPath, DateTime.Now.ToString("MM-dd-yyyy")));

                // ui
                progressBarCallSheets.Visible = false;
                callSheetStatusLabel.Text = "Completed creating calling spreadsheets.";
                callSheetStatusLabel.ForeColor = Color.Green;

                btnCallSheets.Enabled = true;
                btnCreateLetters.Enabled = true;

                //quit excel
                foreach (var ws in workbook.Worksheets)
                {
                    Marshal.ReleaseComObject(ws);
                }

                workbook.Close(0);
                excelApplication.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApplication);
            }
            catch (Exception ex)
            {
                // email exception details
                EmailSender.EmailError(ex);
                MessageBox.Show("Something went wrong..An email has been sent to IT. Please restart program.");

                // quit excel application
                if(workbook != null)
                {
                    foreach (var ws in workbook.Worksheets)
                    {
                        Marshal.ReleaseComObject(ws);
                    }

                    workbook.Close(0);
                    Marshal.ReleaseComObject(workbook);
                }

                if (excelApplication != null)
                {
                    excelApplication.Quit();
                    Marshal.ReleaseComObject(excelApplication);
                }
            }
        }

        private void FillWorkSheetPartial(List<CustHold> customersOnHold, dynamic worksheet)
        {
            worksheet.Cells[currentExcelRow, 2] = currentExcelSection;
            worksheet.Cells[currentExcelRow, 1].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 2].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 3].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 4].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 5].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 6].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 7].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 8].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 9].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 10].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 11].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 12].Interior.Color = Excel.XlRgbColor.rgbYellow;
            worksheet.Cells[currentExcelRow, 13].Interior.Color = Excel.XlRgbColor.rgbYellow;

            currentExcelRow += 1;

            foreach (var cust in customersOnHold)
            {

                BeginInvoke((Action)(() =>
                {
                    progressBarCallSheets.Visible = true;
                    progressBarCallSheets.Value = currentExcelRow;
                    progressBarCallSheets.Value = progressBarCallSheets.Value - 1;
                    callSheetCountLabel.Text = "Current row: " + currentExcelRow.ToString() + "/" + totalCustHoldCount.ToString();
                }));

                worksheet.Cells[currentExcelRow, 1] = cust.CustID;
                worksheet.Cells[currentExcelRow, 2] = cust.CustName;
                worksheet.Cells[currentExcelRow, 3] = cust.ContactName;
                worksheet.Cells[currentExcelRow, 4] = cust.ContactPhone;
                worksheet.Cells[currentExcelRow, 5] = cust.ContactPhoneExt;
                worksheet.Cells[currentExcelRow, 6] = cust.Balance90;
                worksheet.Cells[currentExcelRow, 7] = cust.Balance60;
                worksheet.Cells[currentExcelRow, 8] = cust.Balance45;
                worksheet.Cells[currentExcelRow, 9] = cust.TotalBalance;
                worksheet.Cells[currentExcelRow, 10] = cust.TotalLate;
                worksheet.Cells[currentExcelRow, 11] = cust.Over > 0 ? cust.Over.ToString() : "";
                worksheet.Cells[currentExcelRow, 12] = cust.PmtTerms;
                worksheet.Cells[currentExcelRow, 13] = cust.HoldStatus.HoldStatusID == "Auto_Hold" ? "" : cust.HoldStatus.HoldStatusID;

                currentExcelRow += 1;
            }
        }


        #endregion








        #region Letter Generation

        private async void btnGenerateLetters_Click(object sender, EventArgs e)
        {
            callSheetStatusLabel.Visible = false;
            lblLetterStatus.Visible = true;

            btnCreateLetters.Enabled = false;
            btnCallSheets.Enabled = false;

            lblLetterStatus.Text = "Loading customers to send letters to...";
            lblLetterStatus.ForeColor = Color.Green;

            // set file names & memo text
            List<CustHold> customersOnHold = new List<CustHold>();
            String excelFileName = "";
            String wordFileName = "";
            String templateLetterPath = "";
            String memoText = "";
            String chosenDays = "";

            if (rdoLetters45.Checked)
            {
                customersOnHold = customerService.GetCustomerLetters45();
                excelFileName = "Over45(" + DateTime.Now.ToString("MM-dd-yyyy") + ").xls";
                wordFileName = "LettersOver45(" + DateTime.Now.ToString("MM-dd-yyyy") + ").doc";
                templateLetterPath =  ConfigurationManager.AppSettings["Collections"]+ @"\Templates\Over45Letter.doc";
                memoText = "Sent 45-day letter.";

                chosenDays = "45";
            }
            else if (rdoLetters60.Checked)
            {
                customersOnHold = customerService.GetCustomerLetters60();
                excelFileName = "Over60(" + DateTime.Now.ToString("MM-dd-yyyy") + ").xls";
                wordFileName = "LettersOver60(" + DateTime.Now.ToString("MM-dd-yyyy") + ").doc";
                templateLetterPath = ConfigurationManager.AppSettings["Collections"] + @"\Templates\Over60Letter.doc";
                memoText = "Sent 60-day letter.";

                chosenDays = "60";
            }
            else if (rdoLetters90.Checked)
            {
                customersOnHold = customerService.GetCustomerLetters90();
                excelFileName = "Over90(" + DateTime.Now.ToString("MM-dd-yyyy") + ").xls";
                wordFileName = "LettersOver90(" + DateTime.Now.ToString("MM-dd-yyyy") + ").doc";
                templateLetterPath = ConfigurationManager.AppSettings["Collections"] + @"\Templates\Over90Letter.doc";
                memoText = "Sent 90-day letter. Send to Collections on " + DateTime.Now.AddDays(12).ToString("MMMM dd, yyyy");

                chosenDays = "90";
            }

            if (customersOnHold.Count == 0)
            {
                lblLetterStatus.Text = $"Customers over {chosenDays}-days have already had letters generated.";
                MessageBox.Show($"Customers over {chosenDays}-days have already had letters generated. Check in {ConfigurationManager.AppSettings["Collections"]} to reprint letters.");
                Process.Start(ConfigurationManager.AppSettings["Collections"]);

                btnCreateLetters.Enabled = true;
                btnCallSheets.Enabled = true;

                return;
            }

            lblLetterStatus.Text = "Starting Excel program...";

            // start excel application
            var excelApplication = new Excel.Application();
            if (excelApplication == null)
            {
                MessageBox.Show("Excel is not properly installed.");
                lblLetterStatus.Text = "Excel is not properly installed.";
                lblLetterStatus.ForeColor = Color.Red;

                btnCreateLetters.Enabled = true;
                btnCallSheets.Enabled = true;

                return;
            }

            // verify clean data source template
            var workbook = excelApplication.Workbooks.Open(ConfigurationManager.AppSettings["Collections"] + @"\Templates\DataSourceTemplate.xls");
            var worksheet = workbook.Worksheets[1];

            var val = ((Excel.Range)worksheet.Cells[2, 1]).Value2;

            if (val != null)
            {
                MessageBox.Show("Your Excel data source template has data in it, and it shouldn't. Call IT to straighten it out. Thanks.");
                btnCreateLetters.Enabled = true;
                btnCallSheets.Enabled = true;

                foreach (var ws in workbook.Worksheets)
                {
                    Marshal.ReleaseComObject(ws);
                }

                workbook.Close(0);
                excelApplication.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApplication);

                return;
            }


            lblLetterStatus.Text = "Generating spreadsheet...";
            progressBarLetters.Maximum = customersOnHold.Count;
            progressBarLetters.Value = 0;
            progressBarLetters.Visible = true;
            lblLettersCount.Visible = true;

            // populate template spreadsheet
            await Task.Run(() =>
            {
                FillWorksheet(customersOnHold, worksheet);

                var range = worksheet.Range("W2").EntireColumn;
                range.NumberFormat = "mmmm d, yyyy";
            });

            progressBarLetters.Value = progressBarLetters.Maximum;
            progressBarLetters.Value = progressBarLetters.Value - 1;
            progressBarLetters.Value = progressBarLetters.Maximum;

            // save spreadsheet
            string savedExcelSheetPath = ConfigurationManager.AppSettings["Collections"] + excelFileName;
            workbook.SaveAs(savedExcelSheetPath);

            // close excel
            Marshal.ReleaseComObject(worksheet);

            excelApplication.Workbooks.Close();
            excelApplication.Quit();

            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApplication);

            worksheet = null;
            workbook = null;
            excelApplication = null;

            GC.Collect();

            progressBarLetters.Visible = false;
            lblLettersCount.Visible = false;
            lblLetterStatus.Text = "Starting Word program...";

            await Task.Run(() =>
            {

                // start word
                var wordApplication = new Word.Application();
                var wordDoc = wordApplication.Documents.Open(templateLetterPath);

                BeginInvoke((Action)(() =>
                {
                    lblLetterStatus.Text = "Mail merging...";
                }));

                // merge from spreadsheet
                wordDoc.MailMerge.OpenDataSource(Name: savedExcelSheetPath, SQLStatement: "SELECT * FROM `Sheet1$`");
                wordDoc.MailMerge.Execute();
                wordDoc.Close();

                // save the letters
                var resultDoc = wordApplication.ActiveDocument;
                resultDoc.SaveAs2(ConfigurationManager.AppSettings["Collections"] + wordFileName);
                resultDoc.Close();
                resultDoc = null;
                wordDoc = null;
                wordApplication.Quit();
                GC.Collect();

                // delete excel spreadsheet after merge
                File.Delete(savedExcelSheetPath);

                BeginInvoke((Action)(() =>
                {
                    progressBarLetters.Visible = true;
                    lblLettersCount.Visible = true;
                    progressBarLetters.Value = 0;
                    lblLetterStatus.Text = "Adding remarks..";
                }));


                RemarkContext context = new RemarkContext();

                for (int currentCustomer = 0; currentCustomer < customersOnHold.Count; currentCustomer++)
                {
                    BeginInvoke((Action)(() =>
                    {
                        progressBarLetters.Value = currentCustomer;
                        lblLettersCount.Text = progressBarLetters.Value.ToString() + "/" + customersOnHold.Count.ToString();
                    }));

                    CustHold customer = customersOnHold[currentCustomer];

                    // inject remarks
                    context.Load("ARCustLoad", customer.CustID.TrimEnd(), Environment.UserName);
                    context.AddRemark("Cust.AR.Coll", memoText, Environment.UserName);
                    context.Save(true);

                    // mark customers
                    customer.Letter45 = rdoLetters45.Checked ? (short)-1 : (short)0;
                    customer.Letter60 = rdoLetters60.Checked ? (short)-1 : (short)0;
                    customer.Letter90 = rdoLetters90.Checked ? (short)-1 : (short)0;

                    customerService.UpdateCustHold(customer);
                }
            });


            progressBarLetters.Value = progressBarLetters.Maximum;
            progressBarLetters.Value = progressBarLetters.Value - 1;
            progressBarLetters.Value = progressBarLetters.Maximum;
            lblLetterStatus.Text = "Letters have successfully been generated.";
            lblLettersCount.Text = "";
            btnCreateLetters.Enabled = true;
            btnCallSheets.Enabled = true;

            progressBarLetters.Visible = false;
            lblLettersCount.Visible = false;

            Process.Start(ConfigurationManager.AppSettings["Collections"] + wordFileName);
        }


        private void FillWorksheet(List<CustHold> customersOnHold, dynamic worksheet)
        {
            int lettersCurrentExcelRow = 2; // columns are first row

            foreach (var cust in customersOnHold)
            {
                BeginInvoke((Action)(() =>
                {
                    progressBarLetters.Value = lettersCurrentExcelRow - 1;
                    lblLettersCount.Text = "Current row: " + progressBarLetters.Value.ToString() + "/" + customersOnHold.Count.ToString();
                }));

                worksheet.Cells[lettersCurrentExcelRow, 1] = cust.Key;
                worksheet.Cells[lettersCurrentExcelRow, 2] = cust.CustID;
                worksheet.Cells[lettersCurrentExcelRow, 3] = cust.CustName;
                worksheet.Cells[lettersCurrentExcelRow, 4] = cust.HoldStatus.HoldStatusID;
                worksheet.Cells[lettersCurrentExcelRow, 5] = Convert.ToInt32((DateTime.Now - cust.OnHoldDate).TotalDays);
                worksheet.Cells[lettersCurrentExcelRow, 6] = cust.Balance45;
                worksheet.Cells[lettersCurrentExcelRow, 7] = cust.Balance60;
                worksheet.Cells[lettersCurrentExcelRow, 8] = cust.Balance90;
                worksheet.Cells[lettersCurrentExcelRow, 9] = cust.TotalLate;
                worksheet.Cells[lettersCurrentExcelRow, 10] = cust.Letter45;
                worksheet.Cells[lettersCurrentExcelRow, 11] = cust.Letter60;
                worksheet.Cells[lettersCurrentExcelRow, 12] = cust.CreditLimit;
                worksheet.Cells[lettersCurrentExcelRow, 13] = cust.TotalBalance;
                worksheet.Cells[lettersCurrentExcelRow, 14] = cust.Over;
                worksheet.Cells[lettersCurrentExcelRow, 15] = cust.Customer.DefaultBillToAddress.Line1;
                worksheet.Cells[lettersCurrentExcelRow, 16] = cust.Customer.DefaultBillToAddress.Line2;
                worksheet.Cells[lettersCurrentExcelRow, 17] = cust.Customer.DefaultBillToAddress.City;
                worksheet.Cells[lettersCurrentExcelRow, 18] = cust.Customer.DefaultBillToAddress.State;

                var zipcode = cust.Customer.DefaultBillToAddress.Zip;

                if (zipcode.Length > 5)
                    zipcode = zipcode.Substring(0, 5) + "-" + zipcode.Substring(4);

                worksheet.Cells[lettersCurrentExcelRow, 19] = zipcode;

                worksheet.Cells[lettersCurrentExcelRow, 20] = cust.Customer.DefaultBillToAddress.Country;
                worksheet.Cells[lettersCurrentExcelRow, 21] = cust.User.LastName;
                worksheet.Cells[lettersCurrentExcelRow, 22] = cust.User.FirstName;
                worksheet.Cells[lettersCurrentExcelRow, 23] = DateTime.Now.AddDays(12).ToString("MMMM dd, yyyy");

                lettersCurrentExcelRow += 1;
            }
        }

        private void rdoLetters45_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLetters45.Checked)
                btnCreateLetters.Text = "Create Letters (45-days)";
        }

        private void rdoLetters60_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLetters60.Checked)
                btnCreateLetters.Text = "Create Letters (60-days)";
        }

        private void rdoLetters90_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLetters90.Checked)
                btnCreateLetters.Text = "Create Letters (90-days)";
        }
        #endregion



        #region Form Closed
        private void MaintainAccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
        }
        #endregion

    }
}
