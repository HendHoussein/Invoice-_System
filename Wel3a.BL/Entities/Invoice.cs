using System.Collections.Generic;
using System.Linq;

namespace Wel3a.BL
{
    public class Invoice
    {
        #region Fields
        public int invoice_id { get; set; }
        public string invoice_number { get; set; }
        public string invoice_date { get; set; }
        public double invoice_total { get; set; }
        public int cutomer_id { get; set; }
        public double invoice_paid { get; set; }
        public double invoice_rest { get; set; }
        public int account_id { get; set; }
        public List<SellingInvoiceLine> invoiceLines { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "invoices";
        public static string INVOICE_ID { get; set; } = "invoice_id";
        public static string INVOICE_NUMBER { get; set; } = "invoice_number";
        public static string INVOICE_DATE { get; set; } = "invoice_date";
        public static string INVOICE_TOTAL { get; set; } = "invoice_total";
        public static string INVOICE_PAID { get; set; } = "invoice_paid";
        public static string INVOICE_REST { get; set; } = "invoice_rest";
        #endregion

        #region Helper
        public Customer customer 
        {
            get
                => new CustomerR().Customers.SingleOrDefault(c => c.customer_id == cutomer_id);
        }

        public Account account 
        {
            get
                => new AccountR().Accounts.SingleOrDefault(a => a.account_id == account_id);
        }
        #endregion
    }
}
