using System.Linq;

namespace Wel3a.BL
{
    public class SellingInvoiceLine
    {
        #region Fields
        public int line_id { get; set; }
        public int invoice_id { get; set; }
        public int item_id { get; set; }
        public double line_sell_price { get; set; }
        public double line_quantity { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "selling_invoice_lines";
        public static string LINE_ID { get; set; } = "line_id";
        public static string LINE_SELL_PRICE { get; set; } = "line_sell_price";
        public static string LINE_QUANTITY { get; set; } = "line_quantity";
        #endregion
    }
}
