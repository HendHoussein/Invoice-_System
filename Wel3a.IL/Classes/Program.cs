using Wel3a.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wel3a.IL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new frmLogin());
        }

        public static frmMain fMain = new frmMain();
        public static Account account { get; set; }
        public static DateTime openningDate { get; set; }

        public static void AddWindow(Form form, string frmText)
        {
            form.MdiParent = Program.fMain;
            form.Text = frmText;
            form.Location = new System.Drawing.Point(0, 0);
            form.Show();
        }
    }
}
