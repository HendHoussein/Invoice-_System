using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySqlControl;

namespace Wel3a.BL
{
    public class InvoiceR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);

        public void Add(Invoice invoice)
        {
            int newID = GetNewID();
            invoice.invoice_id = newID;
            string query = $"insert into {Invoice.TABLE_NAME} (" +
                $"{Invoice.INVOICE_ID}, " +
                $"{Account.ACCOUNT_ID}, " +
                $"{Invoice.INVOICE_NUMBER}, " +
                $"{Invoice.INVOICE_DATE}, " +
                $"{Invoice.INVOICE_TOTAL}, " +
                $"{Customer.CUSTOMER_ID}, " +
                $"{Invoice.INVOICE_PAID}, " +
                $"{Invoice.INVOICE_REST}) values( " +
                $"'{invoice.invoice_id}'," +
                $"'{invoice.account_id}'," +
                $"'{invoice.invoice_number}'," +
                $"'{invoice.invoice_date}'," +
                $"'{invoice.invoice_total}'," +
                $"'{invoice.cutomer_id}'," +
                $"'{invoice.invoice_paid}'," +
                $"'{invoice.invoice_rest}')";
            db.Open();
            db.Run(query);
            db.Close();
            AddInvoiceLines(invoice);
        }

        private void AddInvoiceLines(Invoice invoice)
        {
            string values = string.Empty;
            for (int x = 0; x < invoice.invoiceLines.Count; x++)
            {
                values += $"({invoice.invoice_id}, " +
                    $"{invoice.invoiceLines[x].item_id}, " +
                    $"{invoice.invoiceLines[x].line_sell_price}, " +
                    $"{invoice.invoiceLines[x].line_quantity})";
                if (x != invoice.invoiceLines.Count - 1)
                    values += ", ";
            }
            new SellingInvoiceLineR().AddRange(values);
        }

        private int GetNewID()
        {
            string query = $"select max({Invoice.INVOICE_ID})+1 " +
                $"from {Invoice.TABLE_NAME};";
            db.Open();
            string strID = $"{db.GetData(query).Rows[0][0]}";
            if (string.IsNullOrEmpty(strID)) return 1;
            return int.Parse(strID);
        }

        public int GetNewINvoiceNumber(int accountID)
        {
            string query = $"select max({Invoice.INVOICE_NUMBER})+1 " +
                $"from {Invoice.TABLE_NAME} " +
                $"where ({Invoice.INVOICE_DATE}='{DateTime.Now.GetStringOfDate()}') " +
                $"And ({Account.ACCOUNT_ID}={accountID});";
            db.Open();
            string strID = $"{db.GetData(query).Rows[0][0]}";
            if (string.IsNullOrEmpty(strID)) return 1;
            return int.Parse(strID);
        }
    }
}