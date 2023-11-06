using System;
using System.Windows.Forms;
using System.Drawing;
using Wel3a.BL;
using System.Collections.Generic;
using System.Linq;

namespace Wel3a.IL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ConfigurateFrmDesign();
        }

        private void ConfigurateFrmDesign()
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            foreach (Control C in this.Controls)
            {
                if (C is MdiClient)
                {
                    C.BackColor = Color.WhiteSmoke;
                }
            }
            this.Location = new Point(5, 5);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - 10);
            new DragControl().TargetControl = pnlHeader;
            new DragControl().TargetControl = pictureBox1;
            new DragControl().TargetControl = lblTitle;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlTabs.Controls.Add(new InvoiceTabs() { Dock = DockStyle.Fill });
            lblWelcoming.Text = $"Welcome {Program.account.name}";
            lblWelcoming.Left = (pnlHeader.Width - lblWelcoming.Width) / 2;
            pictureBox1.Width = pictureBox1.Height = 31;
            lblTitle.Left = pnlHeader.Width - lblTitle.Width - pictureBox1.Width;
            HandleMoneyMovements();
        }

        private static void HandleMoneyMovements()
        {
            DateTime yestarday = DateTime.Now.AddDays(-1);
            DateTime today = DateTime.Now;
            List<MoneyMoving> movings = new MoneyMovingR().MoneyMovings
                .Where(m => m.moving_date == yestarday.GetStringOfDate())
                .ToList();
            double sumOfPushes = movings
                .Where(m => m.moving_type == MoneyMovingType.متحصلات)
                .Sum(m => m.moving_value);
            double sumOfPulls = movings
                .Where(m => m.moving_type == MoneyMovingType.مصروفات)
                .Sum(m => m.moving_value);
            double net = sumOfPushes - sumOfPulls;
            if (net <= 0) return;
            DialogResult result = MessageBox
                .Show("هل تريد ترحيل الرصيد المتبقي من يوميات الأمس ؟", "تأكيد ترحيل يومية", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            MoneyMoving moving = GetYestardayMovement(net, yestarday.GetStringOfDate());
            new MoneyMovingR().Add(moving);
            moving = GetTodayMovement(net, today.GetStringOfDate());
            new MoneyMovingR().Add(moving);
        }

        private static MoneyMoving GetTodayMovement(double net, string date)
        {
            return new MoneyMoving
            {
                moving_date = date,
                moving_hint = "مرحل",
                moving_type = MoneyMovingType.متحصلات,
                moving_value = net,
            };
        }

        private static MoneyMoving GetYestardayMovement(double net, string date)
        {
            return new MoneyMoving
            {
                moving_date = date,
                moving_hint = "ترحيل",
                moving_type = MoneyMovingType.مصروفات,
                moving_value = net
            };
        }

        private void SetMenueButtonsDefaultColor()
        {
            foreach (Control control in pnlSideMinue.Controls)
                if (control is Button)
                    control.BackColor = Color.Transparent;
        }

        private void ClearOldTab()
        {
            foreach (Control control in pnlTabs.Controls)
                if (control.Name != pnlNotificationContainer.Name)
                    control.Dispose();
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            //pnlTabs.Controls.Add(new Itemstebs() { Dock = DockStyle.Right });
            SetMenueButtonsDefaultColor();
            btnAllItems.BackColor = Helper.colorForSelect;
        }

        private void btnAllSuppliers_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            SetMenueButtonsDefaultColor();
            btnAllSuppliers.BackColor = Helper.colorForSelect;
            //Program.AddWindow(Program.fSuppliers, "الموردين");
        }

        private void btnAllCustomers_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            SetMenueButtonsDefaultColor();
            btnAllCustomers.BackColor = Helper.colorForSelect;
            //Program.AddWindow(Program.fCustomer, "العملاء");
        }

        private void btnAllInvoices_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            pnlTabs.Controls.Add(new InvoiceTabs() { Dock = DockStyle.Right });
            SetMenueButtonsDefaultColor();
            btnAllInvoices.BackColor = Helper.colorForSelect;
        }

        private void btnAllMoneySafe_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            //pnlTabs.Controls.Add(new ucMoneySafeTaps() { Dock = DockStyle.Right });
            SetMenueButtonsDefaultColor();
            btnAllMoneySafe.BackColor = Helper.colorForSelect;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ClearOldTab();
            //pnlTabs.Controls.Add(new ucQueries() { Dock = DockStyle.Right });
            SetMenueButtonsDefaultColor();
            btnReports.BackColor = Helper.colorForSelect;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            
        }

        private void timEndDay_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > Program.openningDate.Date)
            {
                IntializeToEndDat(Program.openningDate);
                Program.openningDate = DateTime.Now;
            }
        }

        private void timOpenNotifications_Tick(object sender, EventArgs e)
        {
            if (pnlNotification.Height >= 521)
            {
                timOpenNotifications.Enabled = false;
                btnNotification.Enabled = true;
            }
            pnlNotification.Height += 20;
        }

        private void OpenNotification()
        {
            pnlNotification.Visible = true;
            pnlNotification.Height = 0;
            timOpenNotifications.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            IntializeToEndDat(DateTime.Now);
            Application.Exit();
        }

        private void IntializeToEndDat(DateTime date)
        {
            List<MoneyMoving> pushMovings = new MoneyMovingR().MoneyMovings
                            .Where(m => m.account_id == Program.account.account_id
                           && m.moving_type == MoneyMovingType.متحصلات
                           && m.moving_date == date.GetStringOfDate()).ToList();

            List<MoneyMoving> pullMovings = new MoneyMovingR().MoneyMovings
                .Where(m => m.account_id == Program.account.account_id
               && m.moving_type == MoneyMovingType.مصروفات
               && m.moving_date == date.GetStringOfDate()).ToList();
            EdnDay(pushMovings, pullMovings, date);
        }

        private void EdnDay(List<MoneyMoving> pushMovings, List<MoneyMoving> pullMovings, DateTime date)
        {
            try
            {
                DialogResult result = MessageBox
                    .Show("هل تريد إنهاء اليوم وترحيل الأموال المتبقية ليوم الغد ؟",
                    "تأكيد ترحيل الأموال", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                double pushes = pushMovings.Sum(p => p.moving_value);
                double pulls = pullMovings.Sum(p => p.moving_value);
                if (pushes - pulls <= 0) return;
                MoneyMoving moving = new MoneyMoving
                {
                    moving_date = date.GetStringOfDate(),
                    moving_hint = "ترحيل",
                    moving_type = MoneyMovingType.مصروفات,
                    moving_value = pushes - pulls,
                    moving_direction = "الخزينة",
                    account_id = Program.account.account_id
                };
                new MoneyMovingR().Add(moving);
                moving.moving_date = date.AddDays(1).GetStringOfDate();
                moving.moving_hint = "مرحل";
                moving.moving_direction = "الخزينة";
                moving.moving_type = MoneyMovingType.متحصلات;
                moving.account_id = Program.account.account_id;
                new MoneyMovingR().Add(moving);
                MessageBox.Show("تمت عملية الترحيل");
                PrintEndDayReport(pushes, pulls, date);
            }
            catch { MessageBox.Show(Helper.wrongmessage); }
        }

        private void PrintEndDayReport(double pushes, double pulls, DateTime date)
        {
            lblPulles.Text = $"{pulls}";
            lblPushes.Text = $"{pushes}";
            lblDate.Text = $"{date.GetStringOfDate()}";
            EndDayDocument.Print();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
    }
}
