using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Wel3a.BL;
using System.Drawing;
using System.Drawing.Printing;

namespace Wel3a.IL
{
    public partial class frmSellingInvoice : Form
    {
        List<ItemTitle> currentTitles;
        List<Item> currentItems;

        public frmSellingInvoice()
        {
            InitializeComponent();
            ConfigurateDesign();
            currentTitles = new ItemTitleR().ItemTitles;
            currentItems = new ItemR().Items;
        }

        private void ConfigurateDesign()
        {
            new DragControl().TargetControl = pnlHeader;
            new DragControl().TargetControl = lblTitle;
            txtInvoiceNumber.PreventLitters();
            txtQuantity.PreventLitters();
            txtNumberOfPrinting.PreventLitters();
            lblDate.Text = DateTime.Now.GetStringOfDate();
            ShowNextInvoiceNumber();
            Helper.MakeBtnsElipse(this);
        }

        private void frmSellingInvoice_Load(object sender, EventArgs e)
        {
            ShowTitles();
            ShowCustomers();
        }

        private void ShowTitles()
        {
            pnlTitles.Controls.Clear();
            int[] Loc = { 2, 7 };
            for (int x = 0; x < currentTitles.Count; x++)
            {
                Button button = new Button();
                ConfigurateBtnTitle(ref button, currentTitles[x], Loc);
                pnlTitles.Controls.Add(button);
                UpdateLocation(ref Loc, x);
                if (x == 0) button.PerformClick();
            }
        }

        private void UpdateLocation(ref int[] loc, int x)
        {
            loc[1] += 82;
            if (((x + 1) % 7) == 0)
            {
                loc[0] += 82;
                loc[1] = 7;
            }
        }

        private void ConfigurateBtnTitle(ref Button button, ItemTitle itemTitle, int[] loc)
        {
            button.Width = 80;
            button.Height = 80;
            button.BackColor = Color.FromArgb(11, 168, 149);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Text = itemTitle.item_name;
            button.Top = loc[0];
            button.Left = loc[1];
            button.Font = new Font("Tajawal", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.Name = "btn" + itemTitle.title_id;
            button.Click += btnTitle_Click;
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            Button btnTitle = sender as Button;
            if (btnTitle == null) return;
            int titleID = int.Parse(btnTitle.Name.Remove(0, 3));
            List<Item> items = currentItems.Where(item => item.title_id == titleID).ToList();
            int[] Loc = { 2, 7 };
            int Mod = 0;
            for (int x = 0; x < items.Count; x++)
            {
                Button btnItem = new Button();
                ConfigurateBtnItem(ref btnItem, items[x], Loc);
                pnlItems.Controls.Add(btnItem);
                if ((Mod % 5 == 0) && (Mod != 0))
                {
                    Loc[0] += 82;
                    Loc[1] = 7;
                }
                Mod++;
            }
        }

        private void ConfigurateBtnItem(ref Button btnItem, Item item, int[] loc)
        {
            btnItem.Width = 80;
            btnItem.Height = 80;
            btnItem.BackColor = Color.FromArgb(166, 13, 78);
            btnItem.ForeColor = Color.White;
            btnItem.FlatStyle = FlatStyle.Flat;
            btnItem.Text = item.item_name;
            btnItem.FlatAppearance.BorderSize = 0;
            btnItem.Top = loc[0];
            btnItem.Left = loc[1];
            btnItem.Font = new Font("Tajawal", 10, FontStyle.Bold);
            loc[1] += 82;
            btnItem.Name = "btnItem" + item.item_id;
            btnItem.Click += btnItem_Click;
        }

        protected void btnItem_Click(object sender, EventArgs e)
        {
            Button btnItem = sender as Button;
            if (btnItem == null) return;
            btnItem.BackColor = Color.FromArgb(23, 33, 43);
        }

        private void AddExistedInvoiceRow(object[] checkingResult)
        {
            DataGridViewRow row = checkingResult[1] as DataGridViewRow;
            if (row == null) return;
            double newQuantity = double.Parse(txtQuantity.Text);
            double oldQuantity = double.Parse($"{row.Cells[colItemQuantity.Name].Value}");
            row.Cells[colItemQuantity.Name].Value = newQuantity + oldQuantity;
            double oldSubTotal = double.Parse($"{row.Cells[colItemSubTotal.Name].Value}");
            double itemPrice = oldSubTotal / oldQuantity;
            row.Cells[colItemSubTotal.Name].Value = (newQuantity + oldQuantity) * itemPrice;
        }

        private object[] CheckIfItemFound(int itemID)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row == null) continue;
                int itemIdFromRow = int.Parse($"{row.Cells[colItemID.Name].Value}");
                if (itemID == itemIdFromRow)
                    return new object[2] { true, row };
            }
            return null;
        }

        private void ShowCustomers()
        {
            Dictionary<int, string> dicCustomers = new Dictionary<int, string>();
            FillCustomersDectionary();
            cbxCustomers.FillCbx(dicCustomers);

            void FillCustomersDectionary()
            {
                List<Customer> customers = new CustomerR().Customers;
                foreach (Customer customer in customers)
                    dicCustomers.Add(customer.customer_id, customer.customer_name);
            }
        }

        private void AddInvoiceRow(Item item)
        {
            string[] row = new string[5];
            row[0] = item.item_name;
            row[1] = $"{item.item_price}";
            row[2] = $"{double.Parse(txtQuantity.Text)}";
            row[3] = $"{item.item_price * double.Parse(txtQuantity.Text)}";
            row[4] = $"{item.item_id}";
            dgvItems.Rows.Add(row);
        }

        private void CalculateInvoice()
        {
            double total = GetTotalAmmountOfInvoice();
            nudDiscount.Value = 0;
            total = total - (total * (double.Parse($"{nudDiscount.Value}") / 100));
            lblInvoiceTotla.Text = $"{total}";
            nudPaied.Value = decimal.Parse($"{total}");
            CalculateRest();
        }

        private double GetTotalAmmountOfInvoice()
        {
            double total = 0.0;
            for (int x = 0; x < dgvItems.Rows.Count; x++)
                total += double.Parse($"{dgvItems.Rows[x].Cells[colItemSubTotal.Name].Value}");
            return total;
        }

        private void CalculateRest()
        {
            double rest = double.Parse(lblInvoiceTotla.Text) - double.Parse($"{nudPaied.Value}");
            if (rest < 0) rest = 0;
            lblRest.Text = $"{rest}";
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
            => CalculateInvoice();

        private void nudPaied_ValueChanged(object sender, EventArgs e)
            => CalculateRest();

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (dgvItems.Rows.Count != 0)
                dgvItems.Rows.RemoveAt(0);
            CalculateInvoice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.Rows.Count == 0) return;
                if (string.IsNullOrEmpty(txtInvoiceNumber.Text))
                {
                    MessageBox.Show("ادخل رقم الفاتورة");
                    return;
                }
                if (!cbxCustomers.IsCurrentItemValidate())
                    cbxCustomers.SelectedIndex = 0;
                Invoice invoice = GetInvoice();
                new InvoiceR().Add(invoice);
                if (cbPrintInvoice.Checked)
                    for (int x = 0; x < 
                        int.Parse(txtNumberOfPrinting.GetFilteredString()); x++) 
                        InvoiceDocument.Print(); btnClear.PerformClick();
                txtInvoiceNumber.Clear();
                lblInvoiceTotla.Text = "0";
                lblRest.Text = "0";
                nudDiscount.Value = 0;
                nudPaied.Value = 0;
                ShowNextInvoiceNumber();
                AddMoney(invoice);
            }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            catch { MessageBox.Show(Helper.wrongmessage); }
        }

        private void AddMoney(Invoice invoice)
        {
            MoneyMoving moving = new MoneyMoving
            {
                moving_date = invoice.invoice_date,
                moving_value = invoice.invoice_total,
                moving_direction = invoice.customer.customer_name,
                moving_hint = "فاتورة",
                moving_type = MoneyMovingType.متحصلات,
                account_id = Program.account.account_id
            };
            new MoneyMovingR().Add(moving);
        }

        private Invoice GetInvoice()
        {
            Invoice invoice = new Invoice()
            {
                invoice_date = lblDate.Text,
                account_id = Program.account.account_id,
                invoice_number = txtInvoiceNumber.Text.Replace("'", ""),
                invoice_paid = double.Parse($"{nudPaied.Value}"),
                invoice_rest = double.Parse($"{lblRest.Text}"),
                invoice_total = double.Parse($"{lblInvoiceTotla.Text}"),
                cutomer_id = cbxCustomers.GetSelectedValue(),
                invoiceLines = GetInvoiceLines()
            };
            return invoice;
        }

        private List<SellingInvoiceLine> GetInvoiceLines()
        {
            List<SellingInvoiceLine> invoiceLines = new List<SellingInvoiceLine>();
            for (int x = 0; x < dgvItems.Rows.Count; x++)
            {
                SellingInvoiceLine line = new SellingInvoiceLine()
                {
                    line_quantity = double.Parse($"{dgvItems.Rows[x].Cells[colItemQuantity.Name].Value}"),
                    line_sell_price = double.Parse($"{dgvItems.Rows[x].Cells[colItemPrice.Name].Value}"),
                    item_id = int.Parse($"{dgvItems.Rows[x].Cells[colItemID.Name].Value}")
                };
                invoiceLines.Add(line);
            }
            return invoiceLines;
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (!dgvItems.IsCurrentRowValidate()) return;
            if (e.KeyCode != Keys.Delete) return;
            dgvItems.Rows.Remove(dgvItems.CurrentRow);
            CalculateInvoice();
        }

        private void cbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
            => ShowNextInvoiceNumber();

        private void ShowNextInvoiceNumber()
            => txtInvoiceNumber.Text = 
            $"{new InvoiceR().GetNewINvoiceNumber(Program.account.account_id)}";

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
                txtQuantity.Text = "0";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;
            string strNumber = button.Text;
            txtQuantity.Text += strNumber;
        }

        private void btnAddInvoiceRow_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "0") return;
            Button btnItem = null;
            foreach (Control control in pnlItems.Controls)
                if (control is Button && control.BackColor == Color.FromArgb(23, 33, 43))
                    btnItem = (Button)control;
            if (btnItem == null) return;
            btnItem.BackColor = Color.FromArgb(166, 13, 78);
            int itemID = int.Parse(btnItem.Name.Remove(0, 7));
            object[] checkingResult = CheckIfItemFound(itemID);
            if (checkingResult != null)
            {
                AddExistedInvoiceRow(checkingResult);
                CalculateInvoice();
                return;
            }
            Item item = currentItems.SingleOrDefault(i => i.item_id == itemID);
            AddInvoiceRow(item);
            CalculateInvoice();
            txtQuantity.Text = "0";
        }

        private void txtNumberOfPrinting_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberOfPrinting.Text))
                txtNumberOfPrinting.Text = "1";
            else if (txtNumberOfPrinting.Text.Trim() == "0")
            {
                cbPrintInvoice.Checked = false;
                txtNumberOfPrinting.Text = "1";
            }
        }

        private void cbPrintInvoice_CheckedChanged(object sender, EventArgs e)
            => txtNumberOfPrinting.Visible = label2.Visible = cbPrintInvoice.Checked;

        private void btnMiniMize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;

        private void btnExit_Click(object sender, EventArgs e)
            => this.Close();
    }
}