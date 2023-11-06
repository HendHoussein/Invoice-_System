using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore.IL.User_Controls.Design
{
    public partial class DetailsCard : UserControl
    {
        public DetailsCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value ?? "";
            }
        }

        public string Details
        {
            get
            {
                return lblDetails.Text;
            }
            set
            {
                lblDetails.Text = value ?? "";
            }
        }
    }
}
