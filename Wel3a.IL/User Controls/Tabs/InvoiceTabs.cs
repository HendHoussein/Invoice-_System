using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Wel3a.BL;

namespace Wel3a.IL
{
    public partial class InvoiceTabs : UserControl
    {
        public InvoiceTabs()
        {
            InitializeComponent();
        }

        private void InvoiceTabs_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is Button)
                    new BunifuElipse().TargetControl = control;
            if (Program.account.account_type == AccountType.Secreatary)
                btnItems.Visible = false;
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
            => Program.AddWindow(new frmSellingInvoice(), "فاتورة بيع");

        private void btnShowAdd_Click(object sender, EventArgs e)
            => Program.AddWindow(new frmMoneyMovings(), "اليوميات");

        private void btnItems_Click(object sender, EventArgs e)
            => Program.AddWindow(new frmItems(), "الصناف");
    }
}
