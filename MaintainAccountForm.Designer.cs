namespace MaintainCustomer
{
    partial class MaintainAccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainAccountsForm));
            this.btnAddresses = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblGeneralStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.callSheetStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.callSheetCountLabel = new System.Windows.Forms.ToolStripLabel();
            this.progressBarCallSheets = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLetterStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLettersCount = new System.Windows.Forms.ToolStripLabel();
            this.progressBarLetters = new System.Windows.Forms.ToolStripProgressBar();
            this.lbBranches = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBranches = new System.Windows.Forms.Label();
            this.chkNuclearHold = new System.Windows.Forms.CheckBox();
            this.lblBranchCount = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCollector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpAccountStatus = new System.Windows.Forms.GroupBox();
            this.rdoInactive = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyCreditLimit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultBillTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllowParentToPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ConsolidatedStatement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpBranchSettings = new System.Windows.Forms.GroupBox();
            this.cboDefaultBillTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkConsolidatedStatement = new System.Windows.Forms.CheckBox();
            this.chkAllowParentToPay = new System.Windows.Forms.CheckBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.rdoDealer = new System.Windows.Forms.RadioButton();
            this.rdoEndUser = new System.Windows.Forms.RadioButton();
            this.rdoWholesaler = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkStatements = new System.Windows.Forms.CheckBox();
            this.cboShipMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPORequired = new System.Windows.Forms.CheckBox();
            this.chkPricePackingSlip = new System.Windows.Forms.CheckBox();
            this.lblManageBranches = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCredit = new System.Windows.Forms.GroupBox();
            this.cboPaymentTerms = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpARStatus = new System.Windows.Forms.GroupBox();
            this.txtOnHold = new System.Windows.Forms.TextBox();
            this.lblOnHold = new System.Windows.Forms.Label();
            this.txtAgingDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHoldStatus = new System.Windows.Forms.TextBox();
            this.rdoAlwaysOnHold = new System.Windows.Forms.RadioButton();
            this.rdoStatusUpdate = new System.Windows.Forms.RadioButton();
            this.rdoNeverOnHold = new System.Windows.Forms.RadioButton();
            this.grpTaxExmpt = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMOTaxExempt = new System.Windows.Forms.TextBox();
            this.txtWATaxExempt = new System.Windows.Forms.TextBox();
            this.txtCATaxExempt = new System.Windows.Forms.TextBox();
            this.btnCreateHQ = new System.Windows.Forms.Button();
            this.rfvCreditLimit = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.btnCreditCards = new System.Windows.Forms.Button();
            this.remarkViewer = new RemarkViewer.RemarkViewer();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPhoneZipSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.grpLetterType = new System.Windows.Forms.GroupBox();
            this.rdoLetters60 = new System.Windows.Forms.RadioButton();
            this.rdoLetters90 = new System.Windows.Forms.RadioButton();
            this.rdoLetters45 = new System.Windows.Forms.RadioButton();
            this.btnCreateLetters = new System.Windows.Forms.Button();
            this.btnCallSheets = new System.Windows.Forms.Button();
            this.panelAccountDetails = new System.Windows.Forms.Panel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ARResearchControl = new MaintainAccount.ResearchControl();
            this.TurboTenKeyTab = new System.Windows.Forms.TabPage();
            this.toolStrip.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpAccountStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.grpBranchSettings.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpCredit.SuspendLayout();
            this.grpARStatus.SuspendLayout();
            this.grpTaxExmpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCreditLimit)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpLetterType.SuspendLayout();
            this.panelAccountDetails.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddresses
            // 
            this.btnAddresses.Enabled = false;
            this.btnAddresses.Location = new System.Drawing.Point(14, 190);
            this.btnAddresses.Name = "btnAddresses";
            this.btnAddresses.Size = new System.Drawing.Size(139, 28);
            this.btnAddresses.TabIndex = 2;
            this.btnAddresses.Text = "Manage Addresses";
            this.btnAddresses.UseVisualStyleBackColor = true;
            this.btnAddresses.Click += new System.EventHandler(this.btnAddresses_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Enabled = false;
            this.btnContacts.Location = new System.Drawing.Point(14, 232);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(139, 28);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "Manage Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustID.Location = new System.Drawing.Point(14, 20);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(139, 20);
            this.txtCustID.TabIndex = 0;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);
            this.txtCustID.Enter += new System.EventHandler(this.txtCustID_Enter);
            this.txtCustID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustID_KeyUp);
            this.txtCustID.Leave += new System.EventHandler(this.txtCustID_Leave);
            this.txtCustID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtCustID_MouseUp);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGeneralStatus,
            this.toolStripSeparator1,
            this.callSheetStatusLabel,
            this.toolStripSeparator2,
            this.callSheetCountLabel,
            this.progressBarCallSheets,
            this.toolStripSeparator3,
            this.lblLetterStatus,
            this.toolStripSeparator4,
            this.lblLettersCount,
            this.progressBarLetters});
            this.toolStrip.Location = new System.Drawing.Point(0, 655);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(932, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip";
            // 
            // lblGeneralStatus
            // 
            this.lblGeneralStatus.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralStatus.ForeColor = System.Drawing.Color.Green;
            this.lblGeneralStatus.Name = "lblGeneralStatus";
            this.lblGeneralStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // callSheetStatusLabel
            // 
            this.callSheetStatusLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callSheetStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.callSheetStatusLabel.Name = "callSheetStatusLabel";
            this.callSheetStatusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // callSheetCountLabel
            // 
            this.callSheetCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callSheetCountLabel.ForeColor = System.Drawing.Color.Green;
            this.callSheetCountLabel.Name = "callSheetCountLabel";
            this.callSheetCountLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // progressBarCallSheets
            // 
            this.progressBarCallSheets.Name = "progressBarCallSheets";
            this.progressBarCallSheets.Size = new System.Drawing.Size(100, 22);
            this.progressBarCallSheets.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblLetterStatus
            // 
            this.lblLetterStatus.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterStatus.Name = "lblLetterStatus";
            this.lblLetterStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblLettersCount
            // 
            this.lblLettersCount.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettersCount.ForeColor = System.Drawing.Color.Green;
            this.lblLettersCount.Name = "lblLettersCount";
            this.lblLettersCount.Size = new System.Drawing.Size(0, 22);
            this.lblLettersCount.Visible = false;
            // 
            // progressBarLetters
            // 
            this.progressBarLetters.Name = "progressBarLetters";
            this.progressBarLetters.Size = new System.Drawing.Size(100, 22);
            this.progressBarLetters.Visible = false;
            // 
            // lbBranches
            // 
            this.lbBranches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBranches.FormattingEnabled = true;
            this.lbBranches.Location = new System.Drawing.Point(14, 104);
            this.lbBranches.Name = "lbBranches";
            this.lbBranches.Size = new System.Drawing.Size(139, 67);
            this.lbBranches.TabIndex = 1;
            this.lbBranches.Visible = false;
            this.lbBranches.DoubleClick += new System.EventHandler(this.listBoxBranches_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID";
            // 
            // lblBranches
            // 
            this.lblBranches.AutoSize = true;
            this.lblBranches.Location = new System.Drawing.Point(11, 88);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(52, 13);
            this.lblBranches.TabIndex = 9;
            this.lblBranches.Text = "Branches";
            this.lblBranches.Visible = false;
            // 
            // chkNuclearHold
            // 
            this.chkNuclearHold.AutoSize = true;
            this.chkNuclearHold.Enabled = false;
            this.chkNuclearHold.Location = new System.Drawing.Point(647, 325);
            this.chkNuclearHold.Name = "chkNuclearHold";
            this.chkNuclearHold.Size = new System.Drawing.Size(88, 17);
            this.chkNuclearHold.TabIndex = 37;
            this.chkNuclearHold.Text = "Nuclear Hold";
            this.chkNuclearHold.UseVisualStyleBackColor = true;
            this.chkNuclearHold.Visible = false;
            this.chkNuclearHold.CheckedChanged += new System.EventHandler(this.chkNuclearHold_CheckedChanged);
            // 
            // lblBranchCount
            // 
            this.lblBranchCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranchCount.AutoSize = true;
            this.lblBranchCount.Location = new System.Drawing.Point(652, 426);
            this.lblBranchCount.Name = "lblBranchCount";
            this.lblBranchCount.Size = new System.Drawing.Size(0, 13);
            this.lblBranchCount.TabIndex = 155;
            this.lblBranchCount.Visible = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.txtCreateDate);
            this.grpGeneral.Controls.Add(this.label14);
            this.grpGeneral.Controls.Add(this.txtAccountType);
            this.grpGeneral.Controls.Add(this.txtCustomerID);
            this.grpGeneral.Controls.Add(this.txtCustName);
            this.grpGeneral.Controls.Add(this.label5);
            this.grpGeneral.Controls.Add(this.label7);
            this.grpGeneral.Controls.Add(this.label6);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(17, 10);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(256, 152);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(97, 110);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(137, 20);
            this.txtCreateDate.TabIndex = 149;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 150;
            this.label14.Text = "Create Date";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(97, 26);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(137, 20);
            this.txtAccountType.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(97, 54);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerID.TabIndex = 9;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(97, 81);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(137, 20);
            this.txtCustName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Account Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 148;
            this.label7.Text = "Cust Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 147;
            this.label6.Text = "Customer ID";
            // 
            // cboCollector
            // 
            this.cboCollector.FormattingEnabled = true;
            this.cboCollector.Location = new System.Drawing.Point(97, 18);
            this.cboCollector.Name = "cboCollector";
            this.cboCollector.Size = new System.Drawing.Size(137, 21);
            this.cboCollector.TabIndex = 11;
            this.cboCollector.SelectedIndexChanged += new System.EventHandler(this.cboCollector_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 151;
            this.label10.Text = "Collector";
            // 
            // grpAccountStatus
            // 
            this.grpAccountStatus.Controls.Add(this.rdoInactive);
            this.grpAccountStatus.Controls.Add(this.rdoActive);
            this.grpAccountStatus.Enabled = false;
            this.grpAccountStatus.Location = new System.Drawing.Point(638, 219);
            this.grpAccountStatus.Name = "grpAccountStatus";
            this.grpAccountStatus.Size = new System.Drawing.Size(103, 102);
            this.grpAccountStatus.TabIndex = 152;
            this.grpAccountStatus.TabStop = false;
            this.grpAccountStatus.Text = "Account Status";
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Location = new System.Drawing.Point(17, 55);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(63, 17);
            this.rdoInactive.TabIndex = 35;
            this.rdoInactive.TabStop = true;
            this.rdoInactive.Text = "Inactive";
            this.rdoInactive.UseVisualStyleBackColor = true;
            this.rdoInactive.CheckedChanged += new System.EventHandler(this.rdoInActive_CheckedChanged);
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(17, 29);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(55, 17);
            this.rdoActive.TabIndex = 34;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            this.rdoActive.CheckedChanged += new System.EventHandler(this.rdoActive_CheckedChanged);
            // 
            // dgvBranches
            // 
            this.dgvBranches.AllowUserToDeleteRows = false;
            this.dgvBranches.AllowUserToOrderColumns = true;
            this.dgvBranches.AllowUserToResizeRows = false;
            this.dgvBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBranches.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.ApplyCreditLimit,
            this.CreditLimit,
            this.DefaultBillTo,
            this.AllowParentToPay,
            this.ConsolidatedStatement});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBranches.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBranches.Location = new System.Drawing.Point(20, 426);
            this.dgvBranches.MultiSelect = false;
            this.dgvBranches.Name = "dgvBranches";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBranches.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBranches.Size = new System.Drawing.Size(690, 178);
            this.dgvBranches.TabIndex = 39;
            this.dgvBranches.Visible = false;
            this.dgvBranches.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranches_CellEndEdit);
            this.dgvBranches.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranches_CellEnter);
            this.dgvBranches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranches_CellValueChanged);
            this.dgvBranches.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBranches_CurrentCellDirtyStateChanged);
            this.dgvBranches.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBranches_EditingControlShowing);
            this.dgvBranches.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBranches_MouseClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // ApplyCreditLimit
            // 
            this.ApplyCreditLimit.HeaderText = "Apply Credit Limit";
            this.ApplyCreditLimit.Name = "ApplyCreditLimit";
            this.ApplyCreditLimit.Width = 45;
            // 
            // CreditLimit
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.CreditLimit.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreditLimit.HeaderText = "Credit Limit";
            this.CreditLimit.Name = "CreditLimit";
            this.CreditLimit.Width = 70;
            // 
            // DefaultBillTo
            // 
            this.DefaultBillTo.HeaderText = "Default Bill To";
            this.DefaultBillTo.Name = "DefaultBillTo";
            this.DefaultBillTo.Width = 78;
            // 
            // AllowParentToPay
            // 
            this.AllowParentToPay.HeaderText = "Allow Parent To Pay";
            this.AllowParentToPay.Name = "AllowParentToPay";
            this.AllowParentToPay.Width = 70;
            // 
            // ConsolidatedStatement
            // 
            this.ConsolidatedStatement.HeaderText = "Consolidated Statement";
            this.ConsolidatedStatement.Name = "ConsolidatedStatement";
            this.ConsolidatedStatement.Width = 70;
            // 
            // grpBranchSettings
            // 
            this.grpBranchSettings.Controls.Add(this.cboDefaultBillTo);
            this.grpBranchSettings.Controls.Add(this.label2);
            this.grpBranchSettings.Controls.Add(this.chkConsolidatedStatement);
            this.grpBranchSettings.Controls.Add(this.chkAllowParentToPay);
            this.grpBranchSettings.Enabled = false;
            this.grpBranchSettings.Location = new System.Drawing.Point(17, 294);
            this.grpBranchSettings.Name = "grpBranchSettings";
            this.grpBranchSettings.Size = new System.Drawing.Size(256, 108);
            this.grpBranchSettings.TabIndex = 146;
            this.grpBranchSettings.TabStop = false;
            this.grpBranchSettings.Text = "Branch Settings";
            this.grpBranchSettings.Visible = false;
            // 
            // cboDefaultBillTo
            // 
            this.cboDefaultBillTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultBillTo.FormattingEnabled = true;
            this.cboDefaultBillTo.Location = new System.Drawing.Point(95, 27);
            this.cboDefaultBillTo.Name = "cboDefaultBillTo";
            this.cboDefaultBillTo.Size = new System.Drawing.Size(139, 21);
            this.cboDefaultBillTo.TabIndex = 15;
            this.cboDefaultBillTo.SelectedIndexChanged += new System.EventHandler(this.cboDefaultBillTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "Default Bill To";
            // 
            // chkConsolidatedStatement
            // 
            this.chkConsolidatedStatement.AutoSize = true;
            this.chkConsolidatedStatement.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConsolidatedStatement.Location = new System.Drawing.Point(16, 78);
            this.chkConsolidatedStatement.Name = "chkConsolidatedStatement";
            this.chkConsolidatedStatement.Size = new System.Drawing.Size(138, 17);
            this.chkConsolidatedStatement.TabIndex = 17;
            this.chkConsolidatedStatement.Text = "Consolidated Statement";
            this.chkConsolidatedStatement.UseVisualStyleBackColor = true;
            this.chkConsolidatedStatement.CheckedChanged += new System.EventHandler(this.chkConsolidatedStatement_CheckedChanged);
            // 
            // chkAllowParentToPay
            // 
            this.chkAllowParentToPay.AutoSize = true;
            this.chkAllowParentToPay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAllowParentToPay.Location = new System.Drawing.Point(17, 54);
            this.chkAllowParentToPay.Name = "chkAllowParentToPay";
            this.chkAllowParentToPay.Size = new System.Drawing.Size(137, 17);
            this.chkAllowParentToPay.TabIndex = 16;
            this.chkAllowParentToPay.Text = "Allow Parent To Pay     ";
            this.chkAllowParentToPay.UseVisualStyleBackColor = true;
            this.chkAllowParentToPay.CheckedChanged += new System.EventHandler(this.chkAllowParentToPay_CheckedChanged);
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.rdoDealer);
            this.grpClass.Controls.Add(this.rdoEndUser);
            this.grpClass.Controls.Add(this.rdoWholesaler);
            this.grpClass.Enabled = false;
            this.grpClass.Location = new System.Drawing.Point(512, 220);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(120, 101);
            this.grpClass.TabIndex = 146;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class";
            // 
            // rdoDealer
            // 
            this.rdoDealer.AutoSize = true;
            this.rdoDealer.Location = new System.Drawing.Point(22, 47);
            this.rdoDealer.Name = "rdoDealer";
            this.rdoDealer.Size = new System.Drawing.Size(56, 17);
            this.rdoDealer.TabIndex = 32;
            this.rdoDealer.Text = "Dealer";
            this.rdoDealer.UseVisualStyleBackColor = true;
            this.rdoDealer.CheckedChanged += new System.EventHandler(this.rdoDealer_CheckedChanged);
            // 
            // rdoEndUser
            // 
            this.rdoEndUser.AutoSize = true;
            this.rdoEndUser.Location = new System.Drawing.Point(22, 20);
            this.rdoEndUser.Name = "rdoEndUser";
            this.rdoEndUser.Size = new System.Drawing.Size(66, 17);
            this.rdoEndUser.TabIndex = 31;
            this.rdoEndUser.Text = "EndUser";
            this.rdoEndUser.UseVisualStyleBackColor = true;
            this.rdoEndUser.CheckedChanged += new System.EventHandler(this.rdoEndUser_CheckedChanged);
            // 
            // rdoWholesaler
            // 
            this.rdoWholesaler.AutoSize = true;
            this.rdoWholesaler.Location = new System.Drawing.Point(22, 73);
            this.rdoWholesaler.Name = "rdoWholesaler";
            this.rdoWholesaler.Size = new System.Drawing.Size(78, 17);
            this.rdoWholesaler.TabIndex = 33;
            this.rdoWholesaler.Text = "Wholesaler";
            this.rdoWholesaler.UseVisualStyleBackColor = true;
            this.rdoWholesaler.CheckedChanged += new System.EventHandler(this.rdoWholesaler_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkStatements);
            this.grpOptions.Controls.Add(this.cboShipMethod);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.chkPORequired);
            this.grpOptions.Controls.Add(this.chkPricePackingSlip);
            this.grpOptions.Enabled = false;
            this.grpOptions.Location = new System.Drawing.Point(289, 10);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(207, 152);
            this.grpOptions.TabIndex = 145;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkStatements
            // 
            this.chkStatements.AutoSize = true;
            this.chkStatements.Location = new System.Drawing.Point(15, 27);
            this.chkStatements.Name = "chkStatements";
            this.chkStatements.Size = new System.Drawing.Size(79, 17);
            this.chkStatements.TabIndex = 18;
            this.chkStatements.Text = "Statements";
            this.chkStatements.UseVisualStyleBackColor = true;
            this.chkStatements.CheckedChanged += new System.EventHandler(this.chkInvoiceCopies_CheckedChanged);
            // 
            // cboShipMethod
            // 
            this.cboShipMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipMethod.FormattingEnabled = true;
            this.cboShipMethod.Location = new System.Drawing.Point(66, 110);
            this.cboShipMethod.Name = "cboShipMethod";
            this.cboShipMethod.Size = new System.Drawing.Size(121, 21);
            this.cboShipMethod.TabIndex = 21;
            this.cboShipMethod.SelectedIndexChanged += new System.EventHandler(this.cboShipMethod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "Ship Via";
            // 
            // chkPORequired
            // 
            this.chkPORequired.AutoSize = true;
            this.chkPORequired.Location = new System.Drawing.Point(15, 81);
            this.chkPORequired.Name = "chkPORequired";
            this.chkPORequired.Size = new System.Drawing.Size(87, 17);
            this.chkPORequired.TabIndex = 10;
            this.chkPORequired.Text = "PO Required";
            this.chkPORequired.UseVisualStyleBackColor = true;
            this.chkPORequired.CheckedChanged += new System.EventHandler(this.chkPORequired_CheckedChanged);
            // 
            // chkPricePackingSlip
            // 
            this.chkPricePackingSlip.AutoSize = true;
            this.chkPricePackingSlip.Checked = true;
            this.chkPricePackingSlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPricePackingSlip.Location = new System.Drawing.Point(15, 54);
            this.chkPricePackingSlip.Name = "chkPricePackingSlip";
            this.chkPricePackingSlip.Size = new System.Drawing.Size(112, 17);
            this.chkPricePackingSlip.TabIndex = 19;
            this.chkPricePackingSlip.Text = "Price Packing Slip";
            this.chkPricePackingSlip.UseVisualStyleBackColor = true;
            this.chkPricePackingSlip.CheckedChanged += new System.EventHandler(this.chkPricePackingSlip_CheckedChanged);
            // 
            // lblManageBranches
            // 
            this.lblManageBranches.AutoSize = true;
            this.lblManageBranches.Location = new System.Drawing.Point(19, 410);
            this.lblManageBranches.Name = "lblManageBranches";
            this.lblManageBranches.Size = new System.Drawing.Size(94, 13);
            this.lblManageBranches.TabIndex = 154;
            this.lblManageBranches.Text = "Manage Branches";
            this.lblManageBranches.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(625, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.cboCollector);
            this.grpCredit.Controls.Add(this.cboPaymentTerms);
            this.grpCredit.Controls.Add(this.label3);
            this.grpCredit.Controls.Add(this.txtCreditLimit);
            this.grpCredit.Controls.Add(this.label10);
            this.grpCredit.Controls.Add(this.label18);
            this.grpCredit.Enabled = false;
            this.grpCredit.Location = new System.Drawing.Point(17, 174);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(256, 107);
            this.grpCredit.TabIndex = 143;
            this.grpCredit.TabStop = false;
            this.grpCredit.Text = "Credit";
            // 
            // cboPaymentTerms
            // 
            this.cboPaymentTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentTerms.FormattingEnabled = true;
            this.cboPaymentTerms.Location = new System.Drawing.Point(97, 71);
            this.cboPaymentTerms.Name = "cboPaymentTerms";
            this.cboPaymentTerms.Size = new System.Drawing.Size(137, 21);
            this.cboPaymentTerms.TabIndex = 14;
            this.cboPaymentTerms.SelectedIndexChanged += new System.EventHandler(this.cboPaymentTerms_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Payment Terms";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(97, 45);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(137, 20);
            this.txtCreditLimit.TabIndex = 13;
            this.txtCreditLimit.TextChanged += new System.EventHandler(this.txtCreditLimit_TextChanged);
            this.txtCreditLimit.Enter += new System.EventHandler(this.txtCreditLimit_Enter);
            this.txtCreditLimit.Leave += new System.EventHandler(this.txtCreditLimit_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Credit Limit";
            // 
            // grpARStatus
            // 
            this.grpARStatus.Controls.Add(this.txtOnHold);
            this.grpARStatus.Controls.Add(this.lblOnHold);
            this.grpARStatus.Controls.Add(this.txtAgingDate);
            this.grpARStatus.Controls.Add(this.label12);
            this.grpARStatus.Controls.Add(this.label13);
            this.grpARStatus.Controls.Add(this.txtHoldStatus);
            this.grpARStatus.Controls.Add(this.rdoAlwaysOnHold);
            this.grpARStatus.Controls.Add(this.rdoStatusUpdate);
            this.grpARStatus.Controls.Add(this.rdoNeverOnHold);
            this.grpARStatus.Enabled = false;
            this.grpARStatus.Location = new System.Drawing.Point(512, 10);
            this.grpARStatus.Name = "grpARStatus";
            this.grpARStatus.Size = new System.Drawing.Size(229, 203);
            this.grpARStatus.TabIndex = 147;
            this.grpARStatus.TabStop = false;
            this.grpARStatus.Text = "AR Status";
            // 
            // txtOnHold
            // 
            this.txtOnHold.Location = new System.Drawing.Point(79, 143);
            this.txtOnHold.Name = "txtOnHold";
            this.txtOnHold.ReadOnly = true;
            this.txtOnHold.Size = new System.Drawing.Size(107, 20);
            this.txtOnHold.TabIndex = 29;
            // 
            // lblOnHold
            // 
            this.lblOnHold.AutoSize = true;
            this.lblOnHold.Location = new System.Drawing.Point(11, 146);
            this.lblOnHold.Name = "lblOnHold";
            this.lblOnHold.Size = new System.Drawing.Size(46, 13);
            this.lblOnHold.TabIndex = 100;
            this.lblOnHold.Text = "On Hold";
            // 
            // txtAgingDate
            // 
            this.txtAgingDate.Location = new System.Drawing.Point(79, 117);
            this.txtAgingDate.Name = "txtAgingDate";
            this.txtAgingDate.ReadOnly = true;
            this.txtAgingDate.Size = new System.Drawing.Size(107, 20);
            this.txtAgingDate.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "Hold Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Aging Date";
            // 
            // txtHoldStatus
            // 
            this.txtHoldStatus.Location = new System.Drawing.Point(79, 169);
            this.txtHoldStatus.Name = "txtHoldStatus";
            this.txtHoldStatus.ReadOnly = true;
            this.txtHoldStatus.Size = new System.Drawing.Size(107, 20);
            this.txtHoldStatus.TabIndex = 30;
            // 
            // rdoAlwaysOnHold
            // 
            this.rdoAlwaysOnHold.AutoSize = true;
            this.rdoAlwaysOnHold.Location = new System.Drawing.Point(22, 51);
            this.rdoAlwaysOnHold.Name = "rdoAlwaysOnHold";
            this.rdoAlwaysOnHold.Size = new System.Drawing.Size(98, 17);
            this.rdoAlwaysOnHold.TabIndex = 26;
            this.rdoAlwaysOnHold.Text = "Always on Hold";
            this.rdoAlwaysOnHold.UseVisualStyleBackColor = true;
            this.rdoAlwaysOnHold.CheckedChanged += new System.EventHandler(this.rdoAlwaysOnHold_CheckedChanged);
            // 
            // rdoStatusUpdate
            // 
            this.rdoStatusUpdate.AutoSize = true;
            this.rdoStatusUpdate.Location = new System.Drawing.Point(22, 77);
            this.rdoStatusUpdate.Name = "rdoStatusUpdate";
            this.rdoStatusUpdate.Size = new System.Drawing.Size(187, 17);
            this.rdoStatusUpdate.TabIndex = 27;
            this.rdoStatusUpdate.Text = "Hold determined by Status Update";
            this.rdoStatusUpdate.UseVisualStyleBackColor = true;
            this.rdoStatusUpdate.CheckedChanged += new System.EventHandler(this.rdoStatusUpdate_CheckedChanged);
            // 
            // rdoNeverOnHold
            // 
            this.rdoNeverOnHold.AutoSize = true;
            this.rdoNeverOnHold.Location = new System.Drawing.Point(22, 24);
            this.rdoNeverOnHold.Name = "rdoNeverOnHold";
            this.rdoNeverOnHold.Size = new System.Drawing.Size(120, 17);
            this.rdoNeverOnHold.TabIndex = 25;
            this.rdoNeverOnHold.Text = "Never on Hold (VIP)";
            this.rdoNeverOnHold.UseVisualStyleBackColor = true;
            this.rdoNeverOnHold.CheckedChanged += new System.EventHandler(this.rdoNeverOnHold_CheckedChanged);
            // 
            // grpTaxExmpt
            // 
            this.grpTaxExmpt.Controls.Add(this.label8);
            this.grpTaxExmpt.Controls.Add(this.label9);
            this.grpTaxExmpt.Controls.Add(this.label11);
            this.grpTaxExmpt.Controls.Add(this.txtMOTaxExempt);
            this.grpTaxExmpt.Controls.Add(this.txtWATaxExempt);
            this.grpTaxExmpt.Controls.Add(this.txtCATaxExempt);
            this.grpTaxExmpt.Enabled = false;
            this.grpTaxExmpt.Location = new System.Drawing.Point(289, 174);
            this.grpTaxExmpt.Name = "grpTaxExmpt";
            this.grpTaxExmpt.Size = new System.Drawing.Size(207, 107);
            this.grpTaxExmpt.TabIndex = 153;
            this.grpTaxExmpt.TabStop = false;
            this.grpTaxExmpt.Text = "Tax Exemptions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 154;
            this.label8.Text = "MO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 153;
            this.label9.Text = "WA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 152;
            this.label11.Text = "CA";
            // 
            // txtMOTaxExempt
            // 
            this.txtMOTaxExempt.Location = new System.Drawing.Point(50, 78);
            this.txtMOTaxExempt.Name = "txtMOTaxExempt";
            this.txtMOTaxExempt.Size = new System.Drawing.Size(137, 20);
            this.txtMOTaxExempt.TabIndex = 24;
            this.txtMOTaxExempt.TextChanged += new System.EventHandler(this.txtMOTaxExempt_TextChanged);
            // 
            // txtWATaxExempt
            // 
            this.txtWATaxExempt.Location = new System.Drawing.Point(50, 52);
            this.txtWATaxExempt.Name = "txtWATaxExempt";
            this.txtWATaxExempt.Size = new System.Drawing.Size(137, 20);
            this.txtWATaxExempt.TabIndex = 23;
            this.txtWATaxExempt.TextChanged += new System.EventHandler(this.txtWATaxExempt_TextChanged);
            // 
            // txtCATaxExempt
            // 
            this.txtCATaxExempt.Location = new System.Drawing.Point(50, 26);
            this.txtCATaxExempt.Name = "txtCATaxExempt";
            this.txtCATaxExempt.Size = new System.Drawing.Size(137, 20);
            this.txtCATaxExempt.TabIndex = 22;
            this.txtCATaxExempt.TextChanged += new System.EventHandler(this.txtCATaxExempt_TextChanged);
            // 
            // btnCreateHQ
            // 
            this.btnCreateHQ.Enabled = false;
            this.btnCreateHQ.Location = new System.Drawing.Point(14, 358);
            this.btnCreateHQ.Name = "btnCreateHQ";
            this.btnCreateHQ.Size = new System.Drawing.Size(139, 28);
            this.btnCreateHQ.TabIndex = 6;
            this.btnCreateHQ.Text = "Convert to HQ";
            this.btnCreateHQ.UseVisualStyleBackColor = true;
            this.btnCreateHQ.Click += new System.EventHandler(this.btnCreateHQ_Click);
            // 
            // rfvCreditLimit
            // 
            this.rfvCreditLimit.ControlToValidate = this.txtCreditLimit;
            this.rfvCreditLimit.ErrorMessage = "Cannot be left blank. Mark 0 if no credit limit.";
            this.rfvCreditLimit.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvCreditLimit.Icon")));
            // 
            // btnCreditCards
            // 
            this.btnCreditCards.Enabled = false;
            this.btnCreditCards.Location = new System.Drawing.Point(14, 274);
            this.btnCreditCards.Name = "btnCreditCards";
            this.btnCreditCards.Size = new System.Drawing.Size(139, 28);
            this.btnCreditCards.TabIndex = 4;
            this.btnCreditCards.Text = "Manage Credit Cards";
            this.btnCreditCards.UseVisualStyleBackColor = true;
            this.btnCreditCards.Click += new System.EventHandler(this.btnCreditCards_Click);
            // 
            // remarkViewer
            // 
            this.remarkViewer.ContextId = "ViewCustomer";
            this.remarkViewer.Enabled = false;
            this.remarkViewer.Location = new System.Drawing.Point(512, 329);
            this.remarkViewer.Name = "remarkViewer";
            this.remarkViewer.OwnerId = "";
            this.remarkViewer.Size = new System.Drawing.Size(60, 60);
            this.remarkViewer.TabIndex = 36;
            this.remarkViewer.Text = "Remarks";
            this.remarkViewer.UserId = "";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Enabled = false;
            this.btnCreateAccount.Location = new System.Drawing.Point(14, 316);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(139, 28);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtPhoneZipSearch
            // 
            this.txtPhoneZipSearch.Location = new System.Drawing.Point(14, 52);
            this.txtPhoneZipSearch.Name = "txtPhoneZipSearch";
            this.txtPhoneZipSearch.Size = new System.Drawing.Size(139, 28);
            this.txtPhoneZipSearch.TabIndex = 7;
            this.txtPhoneZipSearch.Text = "Search By Phone / Zip";
            this.txtPhoneZipSearch.UseVisualStyleBackColor = true;
            this.txtPhoneZipSearch.Click += new System.EventHandler(this.txtPhoneZipSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ConnectionLabel);
            this.panel1.Controls.Add(this.grpLetterType);
            this.panel1.Controls.Add(this.btnCreateLetters);
            this.panel1.Controls.Add(this.lbBranches);
            this.panel1.Controls.Add(this.lblBranches);
            this.panel1.Controls.Add(this.txtPhoneZipSearch);
            this.panel1.Controls.Add(this.txtCustID);
            this.panel1.Controls.Add(this.btnCallSheets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddresses);
            this.panel1.Controls.Add(this.btnContacts);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.btnCreditCards);
            this.panel1.Controls.Add(this.btnCreateHQ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 623);
            this.panel1.TabIndex = 162;
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Location = new System.Drawing.Point(4, 605);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(0, 13);
            this.ConnectionLabel.TabIndex = 12;
            // 
            // grpLetterType
            // 
            this.grpLetterType.Controls.Add(this.rdoLetters60);
            this.grpLetterType.Controls.Add(this.rdoLetters90);
            this.grpLetterType.Controls.Add(this.rdoLetters45);
            this.grpLetterType.Location = new System.Drawing.Point(19, 475);
            this.grpLetterType.Name = "grpLetterType";
            this.grpLetterType.Size = new System.Drawing.Size(123, 83);
            this.grpLetterType.TabIndex = 11;
            this.grpLetterType.TabStop = false;
            // 
            // rdoLetters60
            // 
            this.rdoLetters60.AutoSize = true;
            this.rdoLetters60.Location = new System.Drawing.Point(28, 36);
            this.rdoLetters60.Name = "rdoLetters60";
            this.rdoLetters60.Size = new System.Drawing.Size(63, 17);
            this.rdoLetters60.TabIndex = 5;
            this.rdoLetters60.Text = "Over 60";
            this.rdoLetters60.UseVisualStyleBackColor = true;
            this.rdoLetters60.CheckedChanged += new System.EventHandler(this.rdoLetters60_CheckedChanged);
            // 
            // rdoLetters90
            // 
            this.rdoLetters90.AutoSize = true;
            this.rdoLetters90.Location = new System.Drawing.Point(28, 59);
            this.rdoLetters90.Name = "rdoLetters90";
            this.rdoLetters90.Size = new System.Drawing.Size(63, 17);
            this.rdoLetters90.TabIndex = 6;
            this.rdoLetters90.Text = "Over 90";
            this.rdoLetters90.UseVisualStyleBackColor = true;
            this.rdoLetters90.CheckedChanged += new System.EventHandler(this.rdoLetters90_CheckedChanged);
            // 
            // rdoLetters45
            // 
            this.rdoLetters45.AutoSize = true;
            this.rdoLetters45.Checked = true;
            this.rdoLetters45.Location = new System.Drawing.Point(28, 13);
            this.rdoLetters45.Name = "rdoLetters45";
            this.rdoLetters45.Size = new System.Drawing.Size(63, 17);
            this.rdoLetters45.TabIndex = 4;
            this.rdoLetters45.TabStop = true;
            this.rdoLetters45.Text = "Over 45";
            this.rdoLetters45.UseVisualStyleBackColor = true;
            this.rdoLetters45.CheckedChanged += new System.EventHandler(this.rdoLetters45_CheckedChanged);
            // 
            // btnCreateLetters
            // 
            this.btnCreateLetters.Location = new System.Drawing.Point(14, 446);
            this.btnCreateLetters.Name = "btnCreateLetters";
            this.btnCreateLetters.Size = new System.Drawing.Size(139, 28);
            this.btnCreateLetters.TabIndex = 10;
            this.btnCreateLetters.Text = "Create Letters (45-days)";
            this.btnCreateLetters.UseVisualStyleBackColor = true;
            this.btnCreateLetters.Click += new System.EventHandler(this.btnGenerateLetters_Click);
            // 
            // btnCallSheets
            // 
            this.btnCallSheets.Location = new System.Drawing.Point(14, 404);
            this.btnCallSheets.Name = "btnCallSheets";
            this.btnCallSheets.Size = new System.Drawing.Size(139, 28);
            this.btnCallSheets.TabIndex = 7;
            this.btnCallSheets.Text = "Create Call Sheets";
            this.btnCallSheets.UseVisualStyleBackColor = true;
            this.btnCallSheets.Click += new System.EventHandler(this.btnCallSheets_Click);
            // 
            // panelAccountDetails
            // 
            this.panelAccountDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAccountDetails.Controls.Add(this.lblBranchCount);
            this.panelAccountDetails.Controls.Add(this.chkNuclearHold);
            this.panelAccountDetails.Controls.Add(this.lblManageBranches);
            this.panelAccountDetails.Controls.Add(this.dgvBranches);
            this.panelAccountDetails.Controls.Add(this.remarkViewer);
            this.panelAccountDetails.Controls.Add(this.grpBranchSettings);
            this.panelAccountDetails.Controls.Add(this.btnSave);
            this.panelAccountDetails.Controls.Add(this.grpGeneral);
            this.panelAccountDetails.Controls.Add(this.grpAccountStatus);
            this.panelAccountDetails.Controls.Add(this.grpOptions);
            this.panelAccountDetails.Controls.Add(this.grpARStatus);
            this.panelAccountDetails.Controls.Add(this.grpCredit);
            this.panelAccountDetails.Controls.Add(this.grpClass);
            this.panelAccountDetails.Controls.Add(this.grpTaxExmpt);
            this.panelAccountDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAccountDetails.Location = new System.Drawing.Point(171, 3);
            this.panelAccountDetails.Name = "panelAccountDetails";
            this.panelAccountDetails.Size = new System.Drawing.Size(750, 623);
            this.panelAccountDetails.TabIndex = 162;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.TurboTenKeyTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(932, 655);
            this.MainTabControl.TabIndex = 156;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panelAccountDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ARResearchControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Research";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ARResearchControl
            // 
            this.ARResearchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARResearchControl.Location = new System.Drawing.Point(3, 3);
            this.ARResearchControl.Name = "ARResearchControl";
            this.ARResearchControl.Size = new System.Drawing.Size(918, 623);
            this.ARResearchControl.TabIndex = 0;
            // 
            // TurboTenKeyTab
            // 
            this.TurboTenKeyTab.Location = new System.Drawing.Point(4, 22);
            this.TurboTenKeyTab.Name = "TurboTenKeyTab";
            this.TurboTenKeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.TurboTenKeyTab.Size = new System.Drawing.Size(924, 629);
            this.TurboTenKeyTab.TabIndex = 2;
            this.TurboTenKeyTab.Text = "Turbo Ten Key";
            this.TurboTenKeyTab.UseVisualStyleBackColor = true;
            // 
            // MaintainAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 680);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.toolStrip);
            this.Name = "MaintainAccountsForm";
            this.ShowIcon = false;
            this.Text = "Maintain Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaintainCustomerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaintainAccountsForm_FormClosed);
            this.Load += new System.EventHandler(this.MaintainAccountForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAccountStatus.ResumeLayout(false);
            this.grpAccountStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.grpBranchSettings.ResumeLayout(false);
            this.grpBranchSettings.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpCredit.ResumeLayout(false);
            this.grpCredit.PerformLayout();
            this.grpARStatus.ResumeLayout(false);
            this.grpARStatus.PerformLayout();
            this.grpTaxExmpt.ResumeLayout(false);
            this.grpTaxExmpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCreditLimit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpLetterType.ResumeLayout(false);
            this.grpLetterType.PerformLayout();
            this.panelAccountDetails.ResumeLayout(false);
            this.panelAccountDetails.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddresses;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblGeneralStatus;
        private System.Windows.Forms.ListBox lbBranches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBranches;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCollector;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.RadioButton rdoDealer;
        private System.Windows.Forms.RadioButton rdoEndUser;
        private System.Windows.Forms.RadioButton rdoWholesaler;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkStatements;
        private System.Windows.Forms.ComboBox cboShipMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPORequired;
        private System.Windows.Forms.CheckBox chkPricePackingSlip;
        private System.Windows.Forms.GroupBox grpCredit;
        private System.Windows.Forms.ComboBox cboPaymentTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpBranchSettings;
        private System.Windows.Forms.ComboBox cboDefaultBillTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkConsolidatedStatement;
        private System.Windows.Forms.CheckBox chkAllowParentToPay;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ApplyCreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultBillTo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowParentToPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ConsolidatedStatement;
        private System.Windows.Forms.RadioButton rdoInactive;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.GroupBox grpAccountStatus;
        private System.Windows.Forms.GroupBox grpTaxExmpt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMOTaxExempt;
        private System.Windows.Forms.TextBox txtWATaxExempt;
        private System.Windows.Forms.TextBox txtCATaxExempt;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblManageBranches;
        private System.Windows.Forms.Label lblBranchCount;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvCreditLimit;
        private System.Windows.Forms.Button btnCreateHQ;
        private System.Windows.Forms.Button btnCreditCards;
        private RemarkViewer.RemarkViewer remarkViewer;
        private System.Windows.Forms.GroupBox grpARStatus;
        private System.Windows.Forms.TextBox txtOnHold;
        private System.Windows.Forms.Label lblOnHold;
        private System.Windows.Forms.TextBox txtAgingDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHoldStatus;
        private System.Windows.Forms.RadioButton rdoAlwaysOnHold;
        private System.Windows.Forms.RadioButton rdoStatusUpdate;
        private System.Windows.Forms.RadioButton rdoNeverOnHold;
        private System.Windows.Forms.CheckBox chkNuclearHold;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAccountDetails;
        private System.Windows.Forms.Button txtPhoneZipSearch;
        private System.Windows.Forms.Button btnCallSheets;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar progressBarCallSheets;
        private System.Windows.Forms.ToolStripLabel callSheetStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel callSheetCountLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblLettersCount;
        private System.Windows.Forms.ToolStripProgressBar progressBarLetters;
        private System.Windows.Forms.GroupBox grpLetterType;
        private System.Windows.Forms.RadioButton rdoLetters60;
        private System.Windows.Forms.RadioButton rdoLetters90;
        private System.Windows.Forms.RadioButton rdoLetters45;
        private System.Windows.Forms.Button btnCreateLetters;
        private System.Windows.Forms.ToolStripLabel lblLetterStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TurboTenKeyTab;
        private MaintainAccount.ResearchControl ARResearchControl;
        private System.Windows.Forms.Label ConnectionLabel;
    }
}

