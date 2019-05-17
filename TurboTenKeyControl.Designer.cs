namespace MaintainAccount
{
    partial class TurboTenKeyControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TapeDGV = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TapeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchDGV = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearCalcButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoDecimalCheckBox = new System.Windows.Forms.CheckBox();
            this.EnterEqualsPlusCheckBox = new System.Windows.Forms.CheckBox();
            this.AllowSubtractionCheckBox = new System.Windows.Forms.CheckBox();
            this.UserAmountTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ReconcileButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BatchTextBox = new System.Windows.Forms.TextBox();
            this.TapeTotalTextBox = new System.Windows.Forms.TextBox();
            this.BatchTotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintTape = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.TapeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchDGV)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TapeDGV
            // 
            this.TapeDGV.AllowUserToAddRows = false;
            this.TapeDGV.AllowUserToDeleteRows = false;
            this.TapeDGV.AllowUserToOrderColumns = true;
            this.TapeDGV.AllowUserToResizeColumns = false;
            this.TapeDGV.AllowUserToResizeRows = false;
            this.TapeDGV.BackgroundColor = System.Drawing.Color.White;
            this.TapeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TapeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.TapeAmount});
            this.TapeDGV.Location = new System.Drawing.Point(295, 27);
            this.TapeDGV.MultiSelect = false;
            this.TapeDGV.Name = "TapeDGV";
            this.TapeDGV.ReadOnly = true;
            this.TapeDGV.RowHeadersVisible = false;
            this.TapeDGV.Size = new System.Drawing.Size(200, 372);
            this.TapeDGV.TabIndex = 43;
            this.TapeDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TapeDGV_CellDoubleClick);
            this.TapeDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TapeDGV_MouseClick);
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.Width = 30;
            // 
            // TapeAmount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.TapeAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.TapeAmount.HeaderText = "Amount";
            this.TapeAmount.Name = "TapeAmount";
            this.TapeAmount.ReadOnly = true;
            this.TapeAmount.Width = 155;
            // 
            // BatchDGV
            // 
            this.BatchDGV.AllowUserToAddRows = false;
            this.BatchDGV.AllowUserToDeleteRows = false;
            this.BatchDGV.AllowUserToOrderColumns = true;
            this.BatchDGV.AllowUserToResizeColumns = false;
            this.BatchDGV.AllowUserToResizeRows = false;
            this.BatchDGV.BackgroundColor = System.Drawing.Color.White;
            this.BatchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BatchDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Amount});
            this.BatchDGV.Location = new System.Drawing.Point(23, 27);
            this.BatchDGV.MultiSelect = false;
            this.BatchDGV.Name = "BatchDGV";
            this.BatchDGV.ReadOnly = true;
            this.BatchDGV.RowHeadersVisible = false;
            this.BatchDGV.Size = new System.Drawing.Size(253, 372);
            this.BatchDGV.TabIndex = 42;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 170;
            // 
            // Amount
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // ClearCalcButton
            // 
            this.ClearCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCalcButton.Location = new System.Drawing.Point(633, 65);
            this.ClearCalcButton.Name = "ClearCalcButton";
            this.ClearCalcButton.Size = new System.Drawing.Size(49, 25);
            this.ClearCalcButton.TabIndex = 58;
            this.ClearCalcButton.Text = "Clear";
            this.ClearCalcButton.UseVisualStyleBackColor = true;
            this.ClearCalcButton.Click += new System.EventHandler(this.ClearCalcButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspaceButton.Location = new System.Drawing.Point(523, 64);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(102, 25);
            this.BackspaceButton.TabIndex = 57;
            this.BackspaceButton.Text = "Backspace";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionButton.Location = new System.Drawing.Point(688, 64);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(37, 92);
            this.SubtractionButton.TabIndex = 56;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(688, 162);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(37, 101);
            this.AddButton.TabIndex = 55;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.Location = new System.Drawing.Point(633, 222);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(49, 36);
            this.DecimalButton.TabIndex = 54;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(523, 222);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(102, 36);
            this.ZeroButton.TabIndex = 53;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(633, 180);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(49, 36);
            this.ThreeButton.TabIndex = 52;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(576, 180);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(49, 36);
            this.TwoButton.TabIndex = 51;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(523, 180);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(49, 36);
            this.OneButton.TabIndex = 50;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(633, 138);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(49, 36);
            this.SixButton.TabIndex = 49;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(578, 138);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(49, 36);
            this.FiveButton.TabIndex = 48;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(523, 138);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(49, 36);
            this.FourButton.TabIndex = 47;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(633, 96);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(49, 36);
            this.NineButton.TabIndex = 46;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(578, 96);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(49, 36);
            this.EightButton.TabIndex = 45;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(523, 96);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(49, 36);
            this.SevenButton.TabIndex = 44;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.AutoDecimalCheckBox);
            this.OptionsGroupBox.Controls.Add(this.EnterEqualsPlusCheckBox);
            this.OptionsGroupBox.Controls.Add(this.AllowSubtractionCheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(526, 287);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(174, 112);
            this.OptionsGroupBox.TabIndex = 40;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // AutoDecimalCheckBox
            // 
            this.AutoDecimalCheckBox.AutoSize = true;
            this.AutoDecimalCheckBox.Checked = true;
            this.AutoDecimalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoDecimalCheckBox.Location = new System.Drawing.Point(25, 78);
            this.AutoDecimalCheckBox.Name = "AutoDecimalCheckBox";
            this.AutoDecimalCheckBox.Size = new System.Drawing.Size(114, 17);
            this.AutoDecimalCheckBox.TabIndex = 8;
            this.AutoDecimalCheckBox.Text = "Automatic &Decimal";
            this.AutoDecimalCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnterEqualsPlusCheckBox
            // 
            this.EnterEqualsPlusCheckBox.AutoSize = true;
            this.EnterEqualsPlusCheckBox.Checked = true;
            this.EnterEqualsPlusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnterEqualsPlusCheckBox.Location = new System.Drawing.Point(25, 51);
            this.EnterEqualsPlusCheckBox.Name = "EnterEqualsPlusCheckBox";
            this.EnterEqualsPlusCheckBox.Size = new System.Drawing.Size(77, 17);
            this.EnterEqualsPlusCheckBox.TabIndex = 7;
            this.EnterEqualsPlusCheckBox.Text = "\'&Enter\' = \'+\'";
            this.EnterEqualsPlusCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllowSubtractionCheckBox
            // 
            this.AllowSubtractionCheckBox.AutoSize = true;
            this.AllowSubtractionCheckBox.Checked = true;
            this.AllowSubtractionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllowSubtractionCheckBox.Location = new System.Drawing.Point(25, 24);
            this.AllowSubtractionCheckBox.Name = "AllowSubtractionCheckBox";
            this.AllowSubtractionCheckBox.Size = new System.Drawing.Size(108, 17);
            this.AllowSubtractionCheckBox.TabIndex = 6;
            this.AllowSubtractionCheckBox.Text = "&Allow Subtraction";
            this.AllowSubtractionCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserAmountTextBox
            // 
            this.UserAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAmountTextBox.Location = new System.Drawing.Point(523, 27);
            this.UserAmountTextBox.Name = "UserAmountTextBox";
            this.UserAmountTextBox.Size = new System.Drawing.Size(202, 26);
            this.UserAmountTextBox.TabIndex = 38;
            this.UserAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAmountTextBox_KeyPress);
            this.UserAmountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserAmountTextBox_KeyUp);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(451, 455);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 36;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(370, 455);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 34;
            this.PrintButton.Text = "&Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReconcileButton
            // 
            this.ReconcileButton.Location = new System.Drawing.Point(289, 455);
            this.ReconcileButton.Name = "ReconcileButton";
            this.ReconcileButton.Size = new System.Drawing.Size(75, 23);
            this.ReconcileButton.TabIndex = 33;
            this.ReconcileButton.Text = "&Reconcile";
            this.ReconcileButton.UseVisualStyleBackColor = true;
            this.ReconcileButton.Click += new System.EventHandler(this.ReconcileButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(208, 455);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 32;
            this.LoadButton.Text = "&Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Batch Number";
            // 
            // BatchTextBox
            // 
            this.BatchTextBox.Location = new System.Drawing.Point(99, 457);
            this.BatchTextBox.Name = "BatchTextBox";
            this.BatchTextBox.Size = new System.Drawing.Size(100, 20);
            this.BatchTextBox.TabIndex = 31;
            this.BatchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BatchTextBox_KeyUp);
            // 
            // TapeTotalTextBox
            // 
            this.TapeTotalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TapeTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapeTotalTextBox.Location = new System.Drawing.Point(295, 405);
            this.TapeTotalTextBox.Name = "TapeTotalTextBox";
            this.TapeTotalTextBox.ReadOnly = true;
            this.TapeTotalTextBox.Size = new System.Drawing.Size(200, 26);
            this.TapeTotalTextBox.TabIndex = 39;
            this.TapeTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatchTotalTextBox
            // 
            this.BatchTotalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BatchTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchTotalTextBox.Location = new System.Drawing.Point(21, 405);
            this.BatchTotalTextBox.Name = "BatchTotalTextBox";
            this.BatchTotalTextBox.ReadOnly = true;
            this.BatchTotalTextBox.Size = new System.Drawing.Size(255, 26);
            this.BatchTotalTextBox.TabIndex = 37;
            this.BatchTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tape Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Batch Detail";
            // 
            // PrintTape
            // 
            this.PrintTape.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintTape_PrintPage);
            // 
            // TurboTenKeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TapeDGV);
            this.Controls.Add(this.BatchDGV);
            this.Controls.Add(this.ClearCalcButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.UserAmountTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ReconcileButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BatchTextBox);
            this.Controls.Add(this.TapeTotalTextBox);
            this.Controls.Add(this.BatchTotalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TurboTenKeyControl";
            this.Size = new System.Drawing.Size(946, 637);
            this.Load += new System.EventHandler(this.TurboTenKeyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TapeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchDGV)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TapeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TapeAmount;
        private System.Windows.Forms.DataGridView BatchDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button ClearCalcButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox AutoDecimalCheckBox;
        private System.Windows.Forms.CheckBox EnterEqualsPlusCheckBox;
        private System.Windows.Forms.CheckBox AllowSubtractionCheckBox;
        private System.Windows.Forms.TextBox UserAmountTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ReconcileButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BatchTextBox;
        private System.Windows.Forms.TextBox TapeTotalTextBox;
        private System.Windows.Forms.TextBox BatchTotalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument PrintTape;
    }
}
