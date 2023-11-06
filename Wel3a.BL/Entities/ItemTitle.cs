namespace Wel3a.BL
{
    public class ItemTitle
    {
        #region fields
        public int title_id { get; set; }
        public string item_name { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "items_titles";
        public static string TITLE_ID { get; set; } = "title_id";
        public static string ITEM_NAME { get; set; } = "item_name";

        #endregion
    }
}