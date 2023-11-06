using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Wel3a.BL;

namespace Wel3a.IL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            new DragControl().TargetControl = pictureBox1;
            new DragControl().TargetControl = this;
            Program.openningDate = DateTime.Now;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Replace("'", "");
                string password = txtPassword.Text.Replace("'", "");
                Account account = new AccountR().Accounts
                    .SingleOrDefault(a => a.username == username && a.password == password);
                if (account == null)
                {
                    MessageBox.Show("بيانات حساب خاطئة!");
                    return;
                }
                bool accountHasRights = CheckRights(account);
                if (!accountHasRights)
                {
                    MessageBox.Show("هذا الحساب لا يملك الصلاحية لاستخدام النظام!");
                    return;
                }
                Program.account = account;
                Program.openningDate = DateTime.Now;
                this.Hide();
                Program.fMain.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(Helper.wrongmessage);
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckRights(Account account)
            => CheckAccountRight(account);

        private bool CheckAccountRight(Account account)
        {
            bool accountHasRight;
            List<AccountRight> rights = account.rights;
            if (rights.Count == 0 || rights == null) return false;
            AccountRight right = rights[rights.Count - 1];
            if (right.right_type == RightType.Buy) return true;
            DateTime todayDate = DateTime.Now;
            accountHasRight = 
                (todayDate >= right.start_date_of_right.GetDateOfString()) && 
                (todayDate <= right.end_date_of_right.GetDateOfString());
            return accountHasRight;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnLogin.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new a7a(this).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAbout(this).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
            => Application.Exit();
    }
}
