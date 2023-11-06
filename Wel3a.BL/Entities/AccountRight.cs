namespace Wel3a.BL
{
    public enum RightType
    {
        Buy,
        Rent
    }

    public class AccountRight
    {
        #region fields
        public int right_id { get; set; }
        public RightType right_type { get; set; }
        public double money_paid { get; set; }
        public string start_date_of_right { get; set; }
        public string end_date_of_right { get; set; }
        public int account_id { get; set; }
        public string describtion { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "account_rights";
        public static string RIGHT_ID { get; set; } = "right_id";
        public static string RIGHT_TYPE { get; set; } = "right_type";
        public static string MONEY_PAID { get; set; } = "money_paid";
        public static string START_DATE_OF_RIGHT { get; set; } = "start_date_of_right";
        public static string END_DATE_OF_RIGHT { get; set; } = "end_date_of_right";
        public static string ACCOUNT_ID { get; set; } = "account_id";
        public static string DESCRIBTION { get; set; } = "describtion";
        #endregion
    }
}