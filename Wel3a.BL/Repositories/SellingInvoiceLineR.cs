using MySqlControl;

namespace Wel3a.BL
{
    public class SellingInvoiceLineR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);

        public void AddRange(string values)
        {
            string query = $"insert into {SellingInvoiceLine.TABLE_NAME} (" +
                $"{Invoice.INVOICE_ID}, " +
                $"{Item.ITEM_ID}, " +
                $"{SellingInvoiceLine.LINE_SELL_PRICE}, " +
                $"{SellingInvoiceLine.LINE_QUANTITY}) values {values}";
            db.Open();
            db.Run(query);
            db.Close();
        }
    }
}