using Wel3a.BL;
using System;
using System.Windows.Forms;

namespace Wel3a.IL
{
    public partial class NotificationCard : UserControl
    {
        public NotificationCard()
        {
            InitializeComponent();
        }

        private void NotificationCard_Load(object sender, EventArgs e)
        {
            //Product product = notification.product;
            //Item item = notification.item;
            //if (notification.seen == 1) btnDeleteNotification.Enabled = false;
            //lblItemName.Text = $"{item.item_name_ar} / {item.item_name_en}";
            //lblText1.Text = notification.notification_text1;
            //lblText2.Text = notification.notification_text2;
            //if (product == null)
            //{
            //    lblExpiredDate.Text = lblStore.Text = "ــــــــــــ";
            //    return;
            //}
            //lblExpiredDate.Text = product.product_expired_date;
            //lblStore.Text = product.store.store_name;
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}
