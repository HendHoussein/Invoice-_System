using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Wel3a.BL;

namespace Wel3a.IL
{
    public partial class frmItems : Form
    {
        private int currentItemID
        {
            get => int.Parse($"{dgvItems.CurrentRow.Cells[colItemID.Name].Value}");
        }

        public frmItems()
            => InitializeComponent();

        private void ConfigurateDesign()
        {
            new DragControl().TargetControl = pnlHeader;
            new DragControl().TargetControl = lblTitle;
            Helper.MakeBtnsElipse(this);
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            ShowTitles();
            ShowItems(new ItemR().Items);
            ConfigurateDesign();
        }

        private void ShowTitles()
        {
            Dictionary<int, string> dicTitles = new Dictionary<int, string>();
            FillUnitsDictionary();
            cbxTitles.FillCbx(dicTitles);

            void FillUnitsDictionary()
            {
                List<ItemTitle> titles = new ItemTitleR().ItemTitles;
                foreach (ItemTitle title in titles)
                    dicTitles.Add(title.title_id, title.item_name);
            }
        }

        private void ShowItems(List<Item> items)
        {
            try
            {
                dgvItems.Rows.Clear();
                foreach (Item item in items)
                {
                    object[] row = new object[9];
                    row[0] = $"{item.item_id}";
                    row[1] = $"{item.title_id}";
                    row[2] = item.item_name;
                    row[3] = item.item_price;
                    row[4] = item.title.item_name;
                    dgvItems.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show(Helper.wrongmessage);
            }
        }

        private Item GetItem()
        {
            return new Item
            {
                title_id = int.Parse($"{cbxTitles.SelectedValue}"),
                item_name = txtItemName.GetFilteredString(),
                item_price = double.Parse($"{nudItemPrice.Value}")
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = GetItem();
                new ItemR().Add(item);
                ShowItems(new ItemR().Items);
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(Helper.wrongmessage);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dgvItems.IsCurrentRowValidate()) return;
                Item item = GetItem();
                item.item_id = currentItemID;
                new ItemR().Update(item);
                MessageBox.Show("تم تعديل بيانات الصنف بنجاح");
                ShowItems(new ItemR().Items);
            }
            catch
            { MessageBox.Show(Helper.wrongmessage); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dgvItems.IsCurrentRowValidate()) return;
                DialogResult result = MessageBox
                    .Show("هل تريد حذف بيانات الصنف ؟", "تأكيد الحذف",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                result = MessageBox
                    .Show("سيتم حذف كل ما يتعلق بهذا الصنف في المنتجات والفواتير !",
                    "تأكيد الحذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                new ItemR().Delete(currentItemID);
                MessageBox.Show("تم حذف بيانات الصنف بنجاح");
                ShowItems(new ItemR().Items);
                if (dgvItems.Rows.Count == 0)
                    txtItemName.Text = string.Empty;
            }
            catch
            { MessageBox.Show(Helper.wrongmessage); }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
            => ShowItemData();

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
            => ShowItemData();

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
            => ShowItemData();

        private void ShowItemData()
        {
            txtItemName.Text = $"{dgvItems.CurrentRow.Cells[colItemNameAR.Name].Value}";
            cbxTitles.SelectedValue =
                int.Parse($"{dgvItems.CurrentRow.Cells[colTitleID.Name].Value}");
            nudItemPrice.Value =
                decimal.Parse($"{dgvItems.CurrentRow.Cells[colPrice.Name].Value}");
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            try
            {
                string strTitle = txtTitle.GetFilteredString();
                if (string.IsNullOrEmpty(strTitle)) return;
                ItemTitle title = new ItemTitle
                { item_name = strTitle };
                new ItemTitleR().Add(title);
                MessageBox.Show("تم إضافة القائمة بنجاح");
                txtTitle.Clear();
                ShowTitles();
            }
            catch
            { MessageBox.Show(Helper.wrongmessage); }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtNameSearch.GetFilteredString();
            if (string.IsNullOrEmpty(keyword))
            {
                ShowItems(new ItemR().Items);
                return;
            }
            ShowItems(new ItemR().Items.Where(i => i.item_name.Contains(keyword)).ToList());
        }

        private void btnMiniMize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;

        private void btnExit_Click(object sender, EventArgs e)
            => this.Hide();
    }
}