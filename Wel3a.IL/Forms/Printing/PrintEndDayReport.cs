using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace Wel3a.IL
{
    partial class frmMain
    {
        private void EndDayDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 0;
            Header1(e, margin);
            int lastY = Header2(e);
            Footer(e, lastY);
        }

        private void Header1(PrintPageEventArgs e, int margin)
        {
            Logo(e, margin);
            ResturantName(e, margin);
        }

        private void Logo(PrintPageEventArgs e, int margin)
        {
            string backgroundPath = "Logo.png";
            if (!File.Exists(backgroundPath)) return;
            Image image = Image.FromFile(backgroundPath);
            int logoWidth = 120;
            int logoHeight = 120;
            Rectangle rectangle = new Rectangle(margin, margin, logoWidth, logoHeight);
            e.Graphics.DrawImage(image, rectangle);
        }

        private void ResturantName(PrintPageEventArgs e, int margin)
        {
            string strResturantName = "مطعـــم ولـــعـــة";
            Font font = new Font("Tajawal", 14, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strResturantName, font);
            int x = (e.PageBounds.Width / 2) - (Convert.ToInt32(size.Width) / 2);
            Point point = new Point(x, margin);
            e.Graphics.DrawString(strResturantName, font, Brushes.Black, point);
        }

        private int Header2(PrintPageEventArgs e)
        {
            int margin = 30;
            ReportTitle(e, margin);
            return ReportPerson(e, margin);
        }

        private void ReportTitle(PrintPageEventArgs e, int margin)
        {
            int header1Height = 100;
            string strTitle = $"تقرير المطعم";
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strTitle, font);
            int x = e.PageBounds.Width - Convert.ToInt32(size.Width) - margin;
            Point point = new Point(x, header1Height);
            e.Graphics.DrawString(strTitle, font, Brushes.Black, point);
        }

        private int ReportPerson(PrintPageEventArgs e, int margin)
        {
            int header1Height = 100;
            string strTitle = $"تقرير المطعم";
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strTitle, font);
            int y = header1Height + Convert.ToInt32(size.Height);
            string strPerson = $"تقرير متحصلات ومصروفات المستخدم : {Program.account.name}";
            size = e.Graphics.MeasureString(strPerson, font);
            int x = e.PageBounds.Width - Convert.ToInt32(size.Width) - margin;
            Point point = new Point(x, y);
            e.Graphics.DrawString(strPerson, font, Brushes.Black, point);
            return y + Convert.ToInt32(size.Height);
        }

        private void Footer(PrintPageEventArgs e, int lastY)
        {
            int margin = 30;
            string strData = $"تاريخ التقرير : {lblDate.Text}";
            Font font = new Font("Arial", 10, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strData, font);
            int x = e.PageBounds.Width - margin - Convert.ToInt32(size.Width);
            Point point = new Point(x, lastY + 3);
            e.Graphics.DrawString(strData, font, Brushes.Black, point);

            strData = $"إجمالي الإيرادات : {lblPushes.Text}";
            font = new Font("Arial", 10, FontStyle.Bold);
            lastY += Convert.ToInt32(size.Height) + 3;
            size = e.Graphics.MeasureString(strData, font);
            x = e.PageBounds.Width - margin - Convert.ToInt32(size.Width);
            point = new Point(x, lastY );
            e.Graphics.DrawString(strData, font, Brushes.Black, point);

            strData = $"إجمالي المصروفات : {lblPulles.Text}";
            font = new Font("Arial", 10, FontStyle.Bold);
            lastY += Convert.ToInt32(size.Height) + 3;
            size = e.Graphics.MeasureString(strData, font);
            x = e.PageBounds.Width - margin - Convert.ToInt32(size.Width);
            point = new Point(x, lastY);
            e.Graphics.DrawString(strData, font, Brushes.Black, point);

            strData = $"الإجمالي المتبقي : {double.Parse(lblPushes.Text) - double.Parse(lblPulles.Text)}";
            font = new Font("Arial", 10, FontStyle.Bold);
            lastY += Convert.ToInt32(size.Height) + 3;
            size = e.Graphics.MeasureString(strData, font);
            x = e.PageBounds.Width - margin - Convert.ToInt32(size.Width);
            point = new Point(x, lastY);
            e.Graphics.DrawString(strData, font, Brushes.Black, point);
        }
    }
}