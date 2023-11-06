using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Wel3a.BL;

namespace Wel3a.IL
{
    public partial class frmMoneyMovings : Form
    {
        public frmMoneyMovings()
        {
            InitializeComponent();
            ConfigurateDesign();
        }

        private void ConfigurateDesign()
        {
            new DragControl().TargetControl = pnlHeader;
            new DragControl().TargetControl = lblTitle;
            Helper.MakeBtnsElipse(this);
            dtpDay.MaxDate = DateTime.Now;
            dtpDay.SetCustomDateFormat();
        }

        private void frmSafeMoney_Load(object sender, EventArgs e)
            => ShowMovements(new MoneyMovingR().MoneyMovings
                .Where(a => a.account_id == Program.account.account_id).ToList());

        private void dtpDay_ValueChanged(object sender, EventArgs e)
            => ShowMovements(new MoneyMovingR().MoneyMovings
                .Where(a => a.account_id == Program.account.account_id).ToList());

        private void ShowMovements(List<MoneyMoving> movings)
        {
            try
            {
                movings = movings
                    .Where(m => (m.moving_date == dtpDay.Value.GetStringOfDate())
                    && (m.account_id == Program.account.account_id)).ToList();
                AddPushes(movings);
                AddPulls(movings);
                CalculateRest();
            }
            catch { MessageBox.Show(Helper.wrongmessage); }
        }

        private void CalculateRest()
        {
            double pushes = double.Parse(lblPushesSum.Text);
            double pulls = double.Parse(lblPullsSum.Text);
            lblRestOfDay.Text = $"{pushes - pulls}";
        }

        private void AddPulls(List<MoneyMoving> movings)
        {
            dgvPull.Rows.Clear();
            List<MoneyMoving> pullMovings = movings
                .Where(m => m.moving_type == MoneyMovingType.مصروفات
                && m.account_id == Program.account.account_id)
                .ToList();
            foreach (MoneyMoving moving in pullMovings)
            {
                object[] row = new object[4];
                row[0] = $"{moving.moving_id}";
                row[1] = moving.moving_value;
                row[2] = moving.moving_direction;
                row[3] = moving.moving_hint;
                dgvPull.Rows.Add(row);
            }
            CalculatePullsSum();
        }

        private void CalculatePullsSum()
        {
            dgvPull.AllowUserToAddRows = false;
            double sum = 0;
            foreach (DataGridViewRow row in dgvPull.Rows)
                sum += double.Parse($"{row.Cells[colPullValue.Name].Value}");
            lblPullsSum.Text = $"{sum}";
            dgvPull.AllowUserToAddRows = true;
        }

        private void AddPushes(List<MoneyMoving> movings)
        {
            dgvPush.Rows.Clear();
            List<MoneyMoving> pushMovings = movings
                .Where(m => m.moving_type == MoneyMovingType.متحصلات
                && m.account_id == Program.account.account_id)
                .ToList();
            foreach (MoneyMoving moving in pushMovings)
            {
                object[] row = new object[4];
                row[0] = $"{moving.moving_id}";
                row[1] = moving.moving_value;
                row[2] = moving.moving_direction;
                row[3] = moving.moving_hint;
                dgvPush.Rows.Add(row);
            }
            CalculatePushesSum();
        }

        private void CalculatePushesSum()
        {
            dgvPush.AllowUserToAddRows = false;
            double sum = 0;
            foreach (DataGridViewRow row in dgvPush.Rows)
                sum += double.Parse($"{row.Cells[colPushValue.Name].Value}");
            lblPushesSum.Text = $"{sum}";
            dgvPush.AllowUserToAddRows = true;
        }

        private void btnEndDay_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox
                    .Show("هل تريد إنهاء اليوم وترحيل الأموال المتبقية ليوم الغد ؟",
                    "تأكيد ترحيل الأموال", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                double pushes = double.Parse(lblPushesSum.Text);
                double pulls = double.Parse(lblPullsSum.Text);
                if (pushes - pulls <= 0) return;
                MoneyMoving moving = new MoneyMoving
                {
                    moving_date = dtpDay.Value.GetStringOfDate(),
                    moving_hint = "ترحيل",
                    moving_type = MoneyMovingType.مصروفات,
                    moving_value = pushes - pulls,
                    moving_direction = "الخزينة",
                    account_id = Program.account.account_id
                };
                new MoneyMovingR().Add(moving);
                moving.moving_date = dtpDay.Value.AddDays(1).GetStringOfDate();
                moving.moving_hint = "مرحل";
                moving.moving_direction = "الخزينة";
                moving.moving_type = MoneyMovingType.متحصلات;
                moving.account_id = Program.account.account_id;
                new MoneyMovingR().Add(moving);
                MessageBox.Show("تمت العملية بنجاح");
                List<MoneyMoving> movings = new MoneyMovingR().MoneyMovings
                    .Where(m => m.moving_date == dtpDay.Value.GetStringOfDate())
                    .ToList();
                AddPushes(movings);
                AddPulls(movings);
                CalculateRest();
            }
            catch { MessageBox.Show(Helper.wrongmessage); }
        }

        private void dgvPush_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPush.Rows[e.RowIndex];
            DataGridViewCell cell = dgvPush.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell == null) return;
            if (string.IsNullOrEmpty(dgvPush.Columns[cell.ColumnIndex].HeaderText)) return;
            if (cell.Value == null) return;
            MoneyMoving moving = GetPushMoneyMoving(row);
            switch (moving.moving_id)
            {
                case -1:
                    new MoneyMovingR().Add(moving);
                    int newMovingID = new MoneyMovingR().MoneyMovings.Max(m => m.moving_id);
                    row.Cells[colPushMovementID.Name].Value = newMovingID;
                    break;
                default:
                    new MoneyMovingR().Update(moving);
                    break;
            }
        }

        private void dgvPull_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPull.Rows[e.RowIndex];
            DataGridViewCell cell = dgvPull.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell == null) return;
            if (string.IsNullOrEmpty(dgvPull.Columns[cell.ColumnIndex].HeaderText)) return;
            if (cell.Value == null) return;
            MoneyMoving moving = GetPullMoneyMoving(row);
            switch (moving.moving_id)
            {
                case -1:
                    new MoneyMovingR().Add(moving);
                    int newMovingID = new MoneyMovingR().MoneyMovings.Max(m => m.moving_id);
                    row.Cells[colPullMovementID.Name].Value = newMovingID;
                    break;
                default:
                    new MoneyMovingR().Update(moving);
                    break;
            }
        }

        private MoneyMoving GetPullMoneyMoving(DataGridViewRow row)
        {
            string strMovingID = $"{row.Cells[colPullMovementID.Name].Value}".Trim();
            string strMovingValue = $"{row.Cells[colPullValue.Name].Value}".Trim();
            return new MoneyMoving
            {
                moving_hint = $"{row.Cells[colPullHint.Name].Value}".Trim(),
                moving_date = dtpDay.Value.GetStringOfDate(),
                moving_id = (string.IsNullOrEmpty(strMovingID)) ? -1 : int.Parse(strMovingID),
                moving_value = (string.IsNullOrEmpty(strMovingValue)) ? 0 : int.Parse(strMovingValue),
                moving_type = MoneyMovingType.مصروفات,
                moving_direction = $"{row.Cells[colPullDirection.Name].Value}".Trim(),
                account_id = Program.account.account_id
            };
        }

        private MoneyMoving GetPushMoneyMoving(DataGridViewRow row)
        {
            string strMovingID = $"{row.Cells[colPushMovementID.Name].Value}".Trim();
            string strMovingValue = $"{row.Cells[colPushValue.Name].Value}".Trim();
            return new MoneyMoving
            {
                moving_date = dtpDay.Value.GetStringOfDate(),
                moving_id = (string.IsNullOrEmpty(strMovingID)) ? -1 : int.Parse(strMovingID),
                moving_value = (string.IsNullOrEmpty(strMovingValue)) ? 0 : int.Parse(strMovingValue),
                moving_type = MoneyMovingType.متحصلات,
                moving_direction = $"{row.Cells[colPushDirection.Name].Value}".Trim(),
                moving_hint = $"{row.Cells[colPushHint.Name].Value}".Trim(),
                account_id = Program.account.account_id
            };
        }

        private void btnMiniMize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;

        private void btnExit_Click(object sender, EventArgs e)
            => this.Close();
    }
}