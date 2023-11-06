using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Wel3a.IL
{
    partial class frmSellingInvoice
    {
        private void InvoiceDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 0;
            Header1(e, margin);
            Header2(e);
            int lastY = Details(e);
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

        private void Header2(PrintPageEventArgs e)
        {
            int margin = 30;
            InvoiceNumber(e, margin);
            InvoiceDate(e, margin);
        }

        private void InvoiceNumber(PrintPageEventArgs e, int margin)
        {
            int header1Height = 100;
            string strInvoiceNumber = $"رقم الفاتورة : {txtInvoiceNumber.Text}";
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strInvoiceNumber, font);
            int x = e.PageBounds.Width - Convert.ToInt32(size.Width) - margin;
            Point point = new Point(x, header1Height);
            e.Graphics.DrawString(strInvoiceNumber, font, Brushes.Black, point);
        }

        private void InvoiceDate(PrintPageEventArgs e, int margin)
        {
            int header1Height = 100;
            string strInvoiceNumber = $"رقم الفاتورة : {txtInvoiceNumber.Text}";
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strInvoiceNumber, font);
            int y = header1Height + Convert.ToInt32(size.Height);
            string strInvoiceDate = $"التاريخ : {lblDate.Text}";
            size = e.Graphics.MeasureString(strInvoiceDate, font);
            int x = e.PageBounds.Width - Convert.ToInt32(size.Width) - margin;
            Point point = new Point(x, y);
            e.Graphics.DrawString(strInvoiceDate, font, Brushes.Black, point);
        }

        private int Details(PrintPageEventArgs e)
        {
            int margin = 34;
            #region Main Rectangle
            #region Rectangle
            int headersHeigh = 145;
            int rectHeight = 20;
            int rectWidth = e.PageBounds.Width - margin;
            Rectangle rectangle = new
                Rectangle(0, headersHeigh, rectWidth, rectHeight);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
            #endregion
            #region Rectangle Texts
            #region Sub Total Text
            int subTotalWidth = (rectWidth / 4) - 20;
            string strSubTotal = "المجموع";
            Font font = new Font("Arial", 10, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strSubTotal, font);
            int x = subTotalWidth - Convert.ToInt32(size.Width) - 1;
            Point point = new Point(x, headersHeigh + 1);
            e.Graphics.DrawString(strSubTotal, font, Brushes.Black, point);
            #endregion
            #region Sub Total Line
            Point point1 = new Point(subTotalWidth, headersHeigh);
            Point point2 = new Point(subTotalWidth, headersHeigh + rectHeight);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Quantity Text
            int quantityWidth = (rectWidth / 4) - 30;
            string strQuantity = "الكمية";
            size = e.Graphics.MeasureString(strQuantity, font);
            x = subTotalWidth + quantityWidth - Convert.ToInt32(size.Width) - 1;
            point = new Point(x, headersHeigh + 1);
            e.Graphics.DrawString(strQuantity, font, Brushes.Black, point);
            #endregion
            #region Quantity Line
            point1 = new Point(subTotalWidth + quantityWidth, headersHeigh);
            point2 = new Point(subTotalWidth + quantityWidth, headersHeigh + rectHeight);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Price Text
            int priceWidth = (rectWidth / 4) - 30;
            string strPrice = "السعر";
            size = e.Graphics.MeasureString(strPrice, font);
            x = subTotalWidth + quantityWidth + priceWidth - Convert.ToInt32(size.Width) - 1;
            point = new Point(x, headersHeigh + 1);
            e.Graphics.DrawString(strPrice, font, Brushes.Black, point);
            #endregion
            #region Price Line
            point1 = new Point(subTotalWidth + quantityWidth + priceWidth, headersHeigh);
            point2 = new Point(subTotalWidth + quantityWidth + priceWidth, headersHeigh + rectHeight);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Item Text
            int itemWidth = rectWidth - subTotalWidth - quantityWidth - priceWidth;
            string strItem = "الصنف";
            size = e.Graphics.MeasureString(strItem, font);
            x = subTotalWidth + quantityWidth + priceWidth + itemWidth
                - Convert.ToInt32(size.Width) - 1;
            point = new Point(x, headersHeigh + 1);
            e.Graphics.DrawString(strItem, font, Brushes.Black, point);
            #endregion
            #region Item Line
            point1 = new Point(subTotalWidth + quantityWidth + priceWidth + itemWidth, headersHeigh);
            point2 = new Point(subTotalWidth + quantityWidth + priceWidth + itemWidth, headersHeigh + rectHeight);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion
            #endregion
            #endregion

            #region Invoice Lines
            font = new Font("Arial", 10, FontStyle.Regular);
            int y = headersHeigh + rectHeight + 1;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row == null) continue;
                #region Item Sub Total
                strSubTotal = $"{row.Cells[colItemSubTotal.Name].Value}";
                size = e.Graphics.MeasureString(strSubTotal, font);
                x = subTotalWidth - Convert.ToInt32(size.Width) - 1;
                point = new Point(x, y);
                e.Graphics.DrawString(strSubTotal, font, Brushes.Black, point);
                #endregion

                #region Quantity Text
                strQuantity = $"{row.Cells[colItemQuantity.Name].Value}";
                size = e.Graphics.MeasureString(strQuantity, font);
                x = subTotalWidth + quantityWidth - Convert.ToInt32(size.Width) - 1;
                point = new Point(x, y);
                e.Graphics.DrawString(strQuantity, font, Brushes.Black, point);
                #endregion

                #region Price Text
                strPrice = $"{row.Cells[colItemPrice.Name].Value}";
                size = e.Graphics.MeasureString(strPrice, font);
                x = subTotalWidth + quantityWidth + priceWidth - Convert.ToInt32(size.Width) - 1;
                point = new Point(x, y);
                e.Graphics.DrawString(strPrice, font, Brushes.Black, point);
                #endregion

                #region Item Text
                strItem = $"{row.Cells[colItemName.Name].Value}";
                SplitTextToLines(ref strItem, itemWidth, e, font);
                size = e.Graphics.MeasureString(strItem, font);
                x = subTotalWidth + quantityWidth + priceWidth + itemWidth
                    - Convert.ToInt32(size.Width) - 1;
                point = new Point(x, y);
                e.Graphics.DrawString(strItem, font, Brushes.Black, point);
                #endregion

                y = y + Convert.ToInt32(size.Height) + 1;

                #region Sepirator Line
                point1 = new Point(0, y);
                point2 = new Point(rectWidth, y);
                e.Graphics.DrawLine(Pens.Black, point1, point2);
                #endregion
            }

            #region Previous Sub Total Line
            point1 = new Point(0, headersHeigh + rectHeight);
            point2 = new Point(0, y);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Sub Total Line
            point1 = new Point(subTotalWidth, headersHeigh + rectHeight);
            point2 = new Point(subTotalWidth, y);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Quantity Line
            point1 = new Point(subTotalWidth + quantityWidth, headersHeigh + rectHeight);
            point2 = new Point(subTotalWidth + quantityWidth, y);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Price Line
            point1 = new Point(subTotalWidth + quantityWidth + priceWidth, headersHeigh + rectHeight);
            point2 = new Point(subTotalWidth + quantityWidth + priceWidth, y);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion

            #region Item Line
            point1 = new Point(subTotalWidth + quantityWidth + priceWidth + itemWidth, headersHeigh + rectHeight);
            point2 = new Point(subTotalWidth + quantityWidth + priceWidth + itemWidth, y);
            e.Graphics.DrawLine(Pens.Black, point1, point2);
            #endregion
            #endregion
            return y;
        }

        private void SplitTextToLines(ref string text, int areaWidth, PrintPageEventArgs e, Font font)
        {
            string[] words = text.Split(' ');
            text = string.Empty;
            string strTest1 = string.Empty;
            string strTest2 = string.Empty;
            foreach (string word in words)
            {
                strTest2 += $"{word} ";
                int textWidth =
                    Convert.ToInt32(e.Graphics.MeasureString(strTest2, font).Width);
                if (textWidth > areaWidth)
                {
                    text += $"\n{strTest1}";
                    strTest1 = strTest2 = $"{word} ";
                }
                else
                    strTest1 = strTest2;
            }
            text += $"\n{strTest1}";
            text = $"{text.Trim()}";
        }

        private void Footer(PrintPageEventArgs e, int lastY)
        {
            int margin = 30;
            string strTotalAmmount = $"إجمالي الفاتورة   {lblInvoiceTotla.Text}";
            Font font = new Font("Arial", 10, FontStyle.Bold);
            SizeF size = e.Graphics.MeasureString(strTotalAmmount, font);
            int x = e.PageBounds.Width - margin - Convert.ToInt32(size.Width);
            Point point = new Point(x, lastY + 3);
            e.Graphics.DrawString(strTotalAmmount, font, Brushes.Black, point);
        }
    }
}