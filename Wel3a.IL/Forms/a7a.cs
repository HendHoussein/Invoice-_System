using Wel3a.BL;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Wel3a.IL
{
    public partial class a7a : Form
    {
        Form form;
        public a7a(Form form)
        {
            InitializeComponent();
            Helper.MakeBtnsElipse(this);
            this.form = form;
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            new DragControl().TargetControl = pictureBox1;
            new DragControl().TargetControl = this;
        }

        private void a7a_Load(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(this.Width, this.Height);
            //DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            //bitmap.Save("E:\\Diagram.png",ImageFormat.Png);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strPW = txtPW.Text;
            if (strPW == "012371213901276224083011")
                btnStart.Visible = true;
            else btnStart.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            try
            {
                UpdateProductsTable();
                UpdateItemsTable();
                MessageBox.Show("Done");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UpdateItemsTable()
        {
            string query = $"ALTER TABLE items " +
                $"ADD COLUMN IF NOT EXISTS item_barcode VARCHAR(100) NULL " +
                $"AFTER `item_id`;";
            new ModelR().RunQuery(query);
        }

        private void UpdateProductsTable()
        {
            string query = $"ALTER TABLE products " +
                $"ADD COLUMN IF NOT EXISTS product_sell_price DECIMAL(9,2) NULL " +
                $"AFTER product_buy_price;";
            new ModelR().RunQuery(query);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }
}
