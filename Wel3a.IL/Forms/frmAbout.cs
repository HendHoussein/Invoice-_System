using Wel3a.BL;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Wel3a.IL
{
    public partial class frmAbout : Form
    {
        Form form;
        public frmAbout(Form form)
        {
            InitializeComponent();
            Helper.MakeBtnsElipse(this);
            this.form = form;
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            new DragControl().TargetControl = pictureBox1;
            new DragControl().TargetControl = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => System.Diagnostics.Process.Start("https://limatrix.net/");
    }
}
