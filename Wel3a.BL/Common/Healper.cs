using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Wel3a.BL
{
    public static class Helper
    {
        //public static string connectionString { get; set; } =
        //    "SERVER=sql11.freemysqlhosting.net;PORT=3306;DATABASE=sql11463392;UID=sql11463392;PASSWORD=NGU53GIXBn";

        public static string connectionString { get; set; } =
            "SERVER=localhost;PORT=3306;DATABASE=wel3a;UID=root;PASSWORD=";

        public static string wrongmessage { get; set; } = "Something be wrong";

        public static Account account { get; set; }

        public static Color colorForSelect
        {
            get
            {
                return Color.FromArgb(175, 183, 245);
            }
        }

        public static string GetStringOfDate(this DateTime date)
            => date.ToString("dd-MM-yyyy");

        public static DateTime GetDateOfString(this string strDate)
            => DateTime.ParseExact(strDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        public static bool IsCurrentRowValidate(this DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count == 0) return false;
            if (dataGrid.CurrentRow == null) return false;
            return true;
        }

        public static bool IsCurrentItemValidate(this ComboBox box)
        {
            if (box.Items.Count == 0) return false;
            if (box.SelectedIndex < 0) return false;
            return true;
        }

        public static int GetSelectedValue(this ComboBox box)
        {
            if (!box.IsCurrentItemValidate()) return -1;
            string strValue = $"{box.SelectedValue}";
            foreach (char c in strValue)
                if (!char.IsDigit(c))
                    return -1;
            return int.Parse(strValue);
        }

        public static void FillCbx(this ComboBox box, Dictionary<int, string> dicItems)
        {

            box.DataSource = null;
            if (dicItems.Count == 0) return;
            box.DataSource = new BindingSource(dicItems, null);
            box.DisplayMember = "value";
            box.ValueMember = "key";
            box.SelectedIndex = -1;
            try { box.SelectedIndex = 0; }
            catch (Exception) { box.SelectedIndex = -1; }
        }

        public static void SetCustomDateFormat(this DateTimePicker dateTime)
        {
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd-MM-yyyy";
        }

        public static void PreventLitters(this TextBox box)
        {
            box.KeyPress += new KeyPressEventHandler(txtKeyPress);
        }

        private static void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                if (e.KeyChar != '.')
                    e.Handled = true;
        }

        public static void MakeBtnsElipse(Control control)
        {
            List<Button> buttons = new List<Button>();
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                    buttons.Add(c as Button);
                if (c is Panel || c is GroupBox)
                    MakeBtnsElipse(c);
            }
            buttons.ForEach(b => new Bunifu.Framework.UI.BunifuElipse().TargetControl = b);
        }

        public static string GetFilteredString(this TextBox box)
            => box.Text.Replace("'", "");
    }
}
