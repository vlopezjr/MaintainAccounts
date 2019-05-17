using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MaintainAccount
{
    public partial class TurboTenKeyControl : UserControl
    {
        private LookUpService service;
        private List<Tape> tapes;
        private List<Batch> batches;

        private ContextMenu menu;
        private bool clearUserAmountTextBoxNextDigit;


        public TurboTenKeyControl()
        {
            InitializeComponent();

            service = new LookUpService();
            tapes = new List<Tape>();
            batches = new List<Batch>();
        }




        private async void TurboTenKeyControl_Load(object sender, EventArgs e)
        {
            var preloadEF = await service.GetARBatchesAsync("");

            menu = new ContextMenu();
            menu.MenuItems.Add("Delete row", DeleteRow);


            foreach (Control control in Controls)
            {
                if (control.Name == "BatchTextBox" || control.Name == "UserAmountTextBox")
                    continue;

                control.KeyUp += FocusUserAmountTextBox;

                if (control.Controls.Count > 0)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.KeyUp += FocusUserAmountTextBox;
                    }
                }
            }

            BatchTextBox.Focus();
        }



        private void FocusUserAmountTextBox(object sender, KeyEventArgs e)
        {
            if (sender is TextBox && (sender as TextBox).Name == "BatchTextBox") return;

            switch (e.KeyCode)
            {
                case Keys.Back:
                    SendKeys.Send("{BACKSPACE}");
                    break;
                case Keys.Enter:
                    SendKeys.Send("{ENTER}");
                    break;
                case Keys.Add:
                    SendKeys.Send("{ADD}");
                    break;
                case Keys.Subtract:
                    SendKeys.Send("{SUBTRACT}");
                    break;
                case Keys.NumPad0:
                    SendKeys.Send("0");
                    break;
                case Keys.NumPad1:
                    SendKeys.Send("1");
                    break;
                case Keys.NumPad2:
                    SendKeys.Send("2");
                    break;
                case Keys.NumPad3:
                    SendKeys.Send("3");
                    break;
                case Keys.NumPad4:
                    SendKeys.Send("4");
                    break;
                case Keys.NumPad5:
                    SendKeys.Send("5");
                    break;
                case Keys.NumPad6:
                    SendKeys.Send("6");
                    break;
                case Keys.NumPad7:
                    SendKeys.Send("7");
                    break;
                case Keys.NumPad8:
                    SendKeys.Send("8");
                    break;
                case Keys.NumPad9:
                    SendKeys.Send("9");
                    break;
                case Keys.Decimal:
                    SendKeys.Send(".");
                    break;
                case Keys.Tab:
                    return;
                default:
                    break;
            }

            UserAmountTextBox.Focus();
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            BatchDGV.Rows.Clear();

            //test #: ARCR-0050090
            var userInput = BatchTextBox.Text.TrimEnd();
            batches = await service.GetARBatchesAsync(userInput);

            var batchWithNullTranAmt = batches.FirstOrDefault(c => c.TranAmt == null);
            if (batchWithNullTranAmt != null) return; //exit

            decimal total = 0;

            foreach (var batch in batches)
            {
                total += (decimal)batch.TranAmt;

                var index = BatchDGV.Rows.Add();
                var row = BatchDGV.Rows[index];

                row.Cells["Description"].Value = batch.TranNo;
                row.Cells["Amount"].Value = batch.TranAmt;
            }

            BatchTotalTextBox.Text = total.ToString("N2");
            UserAmountTextBox.Focus();
        }

        private void UserAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (UserAmountTextBox.Text == string.Empty) return;

            if ((e.KeyCode == Keys.Enter && EnterEqualsPlusCheckBox.Checked) || (e.KeyCode == Keys.Add))
            {
                decimal value = 0;
                string symbol = "";

                if (AutoDecimalCheckBox.Checked && !UserAmountTextBox.Text.Contains("."))
                    value = Convert.ToDecimal(UserAmountTextBox.Text) * (decimal)0.01;
                else
                    value = Convert.ToDecimal(UserAmountTextBox.Text);

                symbol = "+";

                AddTapeToDGV(symbol, value);

                AddToTapesCollection(symbol, value);

                UpdateTotalTextBox();

                clearUserAmountTextBoxNextDigit = true;
            }
            else if (e.KeyCode == Keys.Subtract && AllowSubtractionCheckBox.Checked)
            {
                decimal value = 0;
                string symbol = "";

                if (AutoDecimalCheckBox.Checked && !UserAmountTextBox.Text.Contains("."))
                    value = Convert.ToDecimal(UserAmountTextBox.Text) * (decimal)0.01 * -1;
                else
                    value = Convert.ToDecimal(UserAmountTextBox.Text) * -1;

                symbol = "-";

                AddTapeToDGV(symbol, value);

                AddToTapesCollection(symbol, value);

                UpdateTotalTextBox();

                clearUserAmountTextBoxNextDigit = true;
            }
        }

        private void AddTapeToDGV(string symbol, decimal value)
        {
            var index = TapeDGV.Rows.Add();
            var row = TapeDGV.Rows[index];

            row.Cells["Symbol"].Value = symbol;
            row.Cells["TapeAmount"].Value = value;
        }

        private void AddToTapesCollection(string symbol, decimal value)
        {
            tapes.Add(new Tape
            {
                Symbol = symbol,
                Amount = value
            });
        }

        private void UpdateTotalTextBox()
        {
            decimal newTotal = 0;

            tapes.ForEach(tape => newTotal += tape.Amount);

            TapeTotalTextBox.Text = string.Format("{0:n}", newTotal);
        }

        private void UserAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow backspace
            if (e.KeyChar == (char)Keys.Back) return;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.') // not a digit and not decimal
            {
                // don't write - exit
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == '.' && UserAmountTextBox.Text.Contains(".")) // decimal but contains decimal already
            {
                // don't write - don't clear on next digit - exit
                e.Handled = true;
                clearUserAmountTextBoxNextDigit = false;
                return;
            }
            else if (e.KeyChar == '.') // decimal
            {
                // allow - don't clear on next digit - exit
                clearUserAmountTextBoxNextDigit = false;
                return;
            }

            var enter = (char)Keys.Enter;
            var userKey = e.KeyChar;

            if (clearUserAmountTextBoxNextDigit && (userKey != enter) && (userKey != '+') && (userKey != '-'))
            {
                clearUserAmountTextBoxNextDigit = false;
                UserAmountTextBox.Clear();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tapes.Clear();
            TapeDGV.Rows.Clear();
            TapeTotalTextBox.Clear();

            UserAmountTextBox.Focus();
        }

        private void ReconcileButton_Click(object sender, EventArgs e)
        {
            //Batch DGV columns - description 170 width, amount 80 width, total size 253
            //Tape DGV columns - symbol 30 width, amount 155 width, total 200

            if (BatchDGV.Columns["BatchAsterisk"] == null)
            {
                // add asterisk columns to both dgv
                var batchColIndex = BatchDGV.Columns.Add("BatchAsterisk", "");
                var tapeColIndex = TapeDGV.Columns.Add("TapeAsterisk", "");

                // resize columns to fit without scroll
                BatchDGV.Columns[batchColIndex].Width = 20;
                BatchDGV.Columns[batchColIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                BatchDGV.Columns["Description"].Width = 145;

                TapeDGV.Columns[tapeColIndex].Width = 20;
                TapeDGV.Columns[tapeColIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                TapeDGV.Columns["TapeAmount"].Width = 130;
            }
            else
            {
                //clear out *
                foreach (DataGridViewRow row in BatchDGV.Rows)
                {
                    row.Cells["BatchAsterisk"].Value = "";
                }

                foreach (DataGridViewRow row in TapeDGV.Rows)
                {
                    row.Cells["TapeAsterisk"].Value = "";
                }
            }


            // mark with asterisk where match values between both
            for (int i = 0; i < batches.Count; i++)
            {
                var match = tapes.FirstOrDefault(c => c.Amount == batches[i].TranAmt);
                if (match != null)
                {
                    BatchDGV.Rows[i].Cells["BatchAsterisk"].Value = "*";

                    var tapeIndex = tapes.FindIndex(c => c == match);
                    TapeDGV.Rows[tapeIndex].Cells["TapeAsterisk"].Value = "*";
                }
                else
                {
                    BatchDGV.Rows[i].Cells["BatchAsterisk"].Value = "";
                }
            }

            UserAmountTextBox.Focus();
        }







        #region PRINT
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintTape.Print();
        }

        private void PrintTape_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            int vertical = 10;


            if (batches.Count > 0)
            {
                e.Graphics.DrawString(BatchTextBox.Text, font, Brushes.Black, new Point(10, vertical));
                vertical += 15;

                e.Graphics.DrawString(batches[0].BatchCmnt, font, Brushes.Black, new Point(10, vertical));
                vertical += 25;
            }


            decimal total = 0;

            foreach (var item in tapes)
            {
                string textToPrint = string.Format("{0, 10}", item.Amount) + "    " + item.Symbol;
                e.Graphics.DrawString(textToPrint, font, Brushes.Black, new Point(10, vertical));
                vertical += 15;
                total += item.Amount;
            }

            e.Graphics.DrawString("---------------", font, Brushes.Black, new Point(10, vertical));
            vertical += 15;

            e.Graphics.DrawString(string.Format("{0:n}", total), font, Brushes.Black, new Point(10, vertical));

            UserAmountTextBox.Focus();
        }
        #endregion


        private void BatchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadButton.PerformClick();
                UserAmountTextBox.Focus();
            }
        }

        private void ClearCalcButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Clear();
        }

        private void TapeDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TapeDGV.Rows.Count == 0) return;

            var currFont = TapeDGV.Rows[e.RowIndex].DefaultCellStyle.Font;

            if (e.ColumnIndex == 0)
            {
                if (TapeDGV.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Blue)
                {
                    TapeDGV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    TapeDGV.Rows[e.RowIndex].DefaultCellStyle.Font = BatchDGV.DefaultCellStyle.Font;
                }
                else
                {
                    TapeDGV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                    TapeDGV.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
            }
        }

        private void TapeDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (TapeDGV.Rows.Count == 0) return;
            if (TapeDGV.HitTest(e.X, e.Y).RowIndex < 0) return;

            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = TapeDGV.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    TapeDGV.CurrentCell.Selected = false;
                    TapeDGV.Rows[currentMouseOverRow].Selected = true;
                    menu.Show(TapeDGV, new Point(e.X, e.Y));
                }
            }
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            var currentRowIndex = TapeDGV.SelectedRows[0].Index;

            TapeDGV.Rows.RemoveAt(currentRowIndex);
            tapes.RemoveAt(currentRowIndex);

            UpdateTotalTextBox();
        }





        #region 0-9 BUTTONS
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("0");
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send(".");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("9");
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("{SUBTRACT}");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("{ADD}");
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            UserAmountTextBox.Focus();
            SendKeys.Send("{BACKSPACE}");
        }
        #endregion

    }

    internal class Tape
    {
        public string Symbol { get; set; }
        public decimal Amount { get; set; }
    }
}
