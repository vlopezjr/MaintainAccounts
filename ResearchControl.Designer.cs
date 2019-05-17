namespace MaintainAccount
{
    partial class ResearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreditCardButton = new System.Windows.Forms.Button();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OPTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PurchaseOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.SORadioButton = new System.Windows.Forms.RadioButton();
            this.CheckNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.ShipmentRadioButton = new System.Windows.Forms.RadioButton();
            this.LimitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountRadioButton = new System.Windows.Forms.RadioButton();
            this.InvoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.OPRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(41, 159);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 13);
            this.CountLabel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CreditCardButton);
            this.panel2.Controls.Add(this.TransactionsButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.OPTextBox);
            this.panel2.Location = new System.Drawing.Point(394, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 128);
            this.panel2.TabIndex = 20;
            // 
            // CreditCardButton
            // 
            this.CreditCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardButton.Location = new System.Drawing.Point(44, 77);
            this.CreditCardButton.Name = "CreditCardButton";
            this.CreditCardButton.Size = new System.Drawing.Size(130, 24);
            this.CreditCardButton.TabIndex = 14;
            this.CreditCardButton.Text = "View &Credit Card";
            this.CreditCardButton.UseVisualStyleBackColor = true;
            this.CreditCardButton.Click += new System.EventHandler(this.CreditCardButton_Click);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(44, 47);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(130, 24);
            this.TransactionsButton.TabIndex = 13;
            this.TransactionsButton.Text = "View &Transactions";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "OP# ";
            // 
            // OPTextBox
            // 
            this.OPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTextBox.Location = new System.Drawing.Point(44, 16);
            this.OPTextBox.Name = "OPTextBox";
            this.OPTextBox.Size = new System.Drawing.Size(130, 21);
            this.OPTextBox.TabIndex = 9;
            this.OPTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OPTextBox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PurchaseOrderRadioButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.FindTextBox);
            this.panel1.Controls.Add(this.SORadioButton);
            this.panel1.Controls.Add(this.CheckNumberRadioButton);
            this.panel1.Controls.Add(this.ShipmentRadioButton);
            this.panel1.Controls.Add(this.LimitNumeric);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountRadioButton);
            this.panel1.Controls.Add(this.InvoiceRadioButton);
            this.panel1.Controls.Add(this.OPRadioButton);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 128);
            this.panel1.TabIndex = 19;
            // 
            // PurchaseOrderRadioButton
            // 
            this.PurchaseOrderRadioButton.AutoSize = true;
            this.PurchaseOrderRadioButton.Location = new System.Drawing.Point(10, 96);
            this.PurchaseOrderRadioButton.Name = "PurchaseOrderRadioButton";
            this.PurchaseOrderRadioButton.Size = new System.Drawing.Size(99, 17);
            this.PurchaseOrderRadioButton.TabIndex = 5;
            this.PurchaseOrderRadioButton.Text = "&Purchase Order";
            this.PurchaseOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(173, 11);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 24);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "&Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindTextBox.Location = new System.Drawing.Point(10, 13);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(157, 20);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FindTextBox_KeyUp);
            // 
            // SORadioButton
            // 
            this.SORadioButton.AutoSize = true;
            this.SORadioButton.Location = new System.Drawing.Point(233, 73);
            this.SORadioButton.Name = "SORadioButton";
            this.SORadioButton.Size = new System.Drawing.Size(50, 17);
            this.SORadioButton.TabIndex = 9;
            this.SORadioButton.Text = "&SO #";
            this.SORadioButton.UseVisualStyleBackColor = true;
            // 
            // CheckNumberRadioButton
            // 
            this.CheckNumberRadioButton.AutoSize = true;
            this.CheckNumberRadioButton.Checked = true;
            this.CheckNumberRadioButton.Location = new System.Drawing.Point(10, 50);
            this.CheckNumberRadioButton.Name = "CheckNumberRadioButton";
            this.CheckNumberRadioButton.Size = new System.Drawing.Size(96, 17);
            this.CheckNumberRadioButton.TabIndex = 3;
            this.CheckNumberRadioButton.TabStop = true;
            this.CheckNumberRadioButton.Text = "&Check Number";
            this.CheckNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShipmentRadioButton
            // 
            this.ShipmentRadioButton.AutoSize = true;
            this.ShipmentRadioButton.Location = new System.Drawing.Point(124, 73);
            this.ShipmentRadioButton.Name = "ShipmentRadioButton";
            this.ShipmentRadioButton.Size = new System.Drawing.Size(83, 17);
            this.ShipmentRadioButton.TabIndex = 7;
            this.ShipmentRadioButton.Text = "S&hipment ID";
            this.ShipmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // LimitNumeric
            // 
            this.LimitNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitNumeric.Location = new System.Drawing.Point(322, 14);
            this.LimitNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LimitNumeric.Name = "LimitNumeric";
            this.LimitNumeric.Size = new System.Drawing.Size(38, 20);
            this.LimitNumeric.TabIndex = 2;
            this.LimitNumeric.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Max records";
            // 
            // AmountRadioButton
            // 
            this.AmountRadioButton.AutoSize = true;
            this.AmountRadioButton.Location = new System.Drawing.Point(124, 50);
            this.AmountRadioButton.Name = "AmountRadioButton";
            this.AmountRadioButton.Size = new System.Drawing.Size(61, 17);
            this.AmountRadioButton.TabIndex = 6;
            this.AmountRadioButton.Text = "&Amount";
            this.AmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceRadioButton
            // 
            this.InvoiceRadioButton.AutoSize = true;
            this.InvoiceRadioButton.Location = new System.Drawing.Point(10, 73);
            this.InvoiceRadioButton.Name = "InvoiceRadioButton";
            this.InvoiceRadioButton.Size = new System.Drawing.Size(60, 17);
            this.InvoiceRadioButton.TabIndex = 4;
            this.InvoiceRadioButton.Text = "&Invoice";
            this.InvoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // OPRadioButton
            // 
            this.OPRadioButton.AutoSize = true;
            this.OPRadioButton.Location = new System.Drawing.Point(233, 50);
            this.OPRadioButton.Name = "OPRadioButton";
            this.OPRadioButton.Size = new System.Drawing.Size(50, 17);
            this.OPRadioButton.TabIndex = 8;
            this.OPRadioButton.Text = "&OP #";
            this.OPRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.AllowUserToResizeRows = false;
            this.ResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Location = new System.Drawing.Point(4, 174);
            this.ResultsDataGridView.MultiSelect = false;
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.Size = new System.Drawing.Size(741, 263);
            this.ResultsDataGridView.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Results:";
            // 
            // ResearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.label3);
            this.Name = "ResearchControl";
            this.Size = new System.Drawing.Size(748, 440);
            this.Load += new System.EventHandler(this.ResearchControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreditCardButton;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OPTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PurchaseOrderRadioButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.RadioButton SORadioButton;
        private System.Windows.Forms.RadioButton CheckNumberRadioButton;
        private System.Windows.Forms.RadioButton ShipmentRadioButton;
        private System.Windows.Forms.NumericUpDown LimitNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AmountRadioButton;
        private System.Windows.Forms.RadioButton InvoiceRadioButton;
        private System.Windows.Forms.RadioButton OPRadioButton;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Label label3;
    }
}
