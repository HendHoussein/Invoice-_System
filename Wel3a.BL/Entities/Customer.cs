namespace Wel3a.BL
{
    public class Customer
    {
        #region Fields
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string customer_notes { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "customers";
        public static string CUSTOMER_ID { get; set; } = "customer_id";
        public static string CUSTOMER_NAME { get; set; } = "customer_name";
        public static string CUSTOMER_PHONE { get; set; } = "customer_phone";
        public static string CUSTOMER_NOTES { get; set; } = "customer_notes";
        #endregion
    }
}
