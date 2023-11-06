using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore.IL
{
    public partial class BorderedTextBox : UserControl
    {
        public BorderedTextBox()
        {
            InitializeComponent();
        }

        public string CurrentText
        {
            get
            {
                return textBox5.Text;
            }
            set
            {
                if (value == null)
                    textBox5.Text = "";
                else
                    textBox5.Text = value;
            }
        }

        private void BorderedTextBox_Paint(object sender, PaintEventArgs e)
        {
            this.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(0, 115, 207)), 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
