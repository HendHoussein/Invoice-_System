using System.Linq;

namespace Wel3a.BL
{
    public class Item
    {
        #region fields
        public int item_id { get; set; }
        public int title_id { get; set; }
        public double item_price { get; set; }
        public string item_name { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "items";
        public static string ITEM_ID { get; set; } = "item_id";
        public static string TITLE_ID { get; set; } = "title_id";
        public static string ITEM_PRICE { get; set; } = "item_price";
        public static string ITEM_NAME { get; set; } = "item_name";

        #endregion

        #region Helper
        public ItemTitle title
        {
            get
                => new ItemTitleR().ItemTitles
                .SingleOrDefault(t => t.title_id == this.title_id);
        }
        #endregion
    }
}