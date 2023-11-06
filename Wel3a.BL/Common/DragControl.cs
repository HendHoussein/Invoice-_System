using System.Drawing;
using System.Windows.Forms;

namespace Wel3a.BL
{
    public class DragControl
    {
        public Control TargetControl 
        {
            set
            {
                value.MouseDown += Control_MouseDown;
                value.MouseMove += Control_MouseMove;                
                value.MouseUp += Control_MouseUp;                
            }
        }

        private bool isMouseDown = false;
        private Point lastLocation;

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            Form form = control.FindForm();
            if (isMouseDown)
            {
                int newX = (form.Location.X - lastLocation.X) + e.X;
                int newY = (form.Location.Y - lastLocation.Y) + e.Y;
                form.Location = new Point(newX, newY);
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            isMouseDown = false;
            control.Cursor = Cursors.Default;
        }
    }
}
