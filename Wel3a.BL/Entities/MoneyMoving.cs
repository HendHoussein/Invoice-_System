namespace Wel3a.BL
{
    public enum MoneyMovingType
    {
        متحصلات,
        مصروفات
    }

    public class MoneyMoving
    {
        #region Fields
        public int moving_id { get; set; }
        public string moving_date { get; set; }
        public double moving_value { get; set; }
        public string moving_direction { get; set; }
        public string moving_hint { get; set; }
        public int account_id { get; set; }
        public MoneyMovingType moving_type { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "money_movings";
        public static string MOVING_ID { get; set; } = "moving_id";
        public static string MOVING_DATE { get; set; } = "moving_date";
        public static string MOVING_VALUE { get; set; } = "moving_value";
        public static string MOVING_DIRECTION { get; set; } = "moving_direction";
        public static string MOVING_HINT { get; set; } = "moving_hint";
        public static string MOVING_TYPE { get; set; } = "moving_type";
        #endregion
    }
}
