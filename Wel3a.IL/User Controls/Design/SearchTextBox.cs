using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrugStore.IL
{
    public partial class SearchTextBox : UserControl
    {
        struct DrawBorder
        {
            public int RecWidth1;
            public int RecHeigh1;
            public int RecWidth2;
            public int RecHeigh2;
        }

        DrawBorder db1;

        public SearchTextBox()
        {
            InitializeComponent();

            db1.RecWidth1 = 526;
            db1.RecHeigh1 = 27;
            db1.RecWidth2 = 524;
            db1.RecHeigh2 = 25;
        }

        public string CurrentText
        {
            get
            {
                return textBox1.Text;
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                    textBox1.Text = string.Empty;
                else
                    textBox1.Text = value;
            }
        }

        private void SearchTextBox_SizeChanged(object sender, EventArgs e)
        {
            int TextBoxWidth, PictureBoxWidth;
            PictureBoxWidth = pictureBox1.Width;
            TextBoxWidth = this.Width - PictureBoxWidth;
            TextBoxWidth -= 3;
            textBox1.Width = TextBoxWidth;

            Point TextBoxLocation = new Point(4, 3);
            Point PictureBoxLocation = new Point(TextBoxWidth, 4);

            textBox1.Location = TextBoxLocation;
            pictureBox1.Location = PictureBoxLocation;

            db1.RecWidth1 = this.Width - 2;
            db1.RecHeigh1 = this.Height - 2;
            db1.RecWidth2 = this.Width - 4;
            db1.RecHeigh2 = this.Height - 4;

            SearchTextBox_Paint(this, null);
        }

        private void SearchTextBox_Paint(object sender, PaintEventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);

            this.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(0, 115, 207)), 0, 0, db1.RecWidth1, db1.RecHeigh1);
            this.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(0, 115, 207)), 1, 1, db1.RecWidth2, db1.RecHeigh2);
        }
    }
}
