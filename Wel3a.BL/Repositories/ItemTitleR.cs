using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class ItemTitleR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<ItemTitle> ItemTitles
        {
            get
            {
                db.Open();
                string query = $"select * from {ItemTitle.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<ItemTitle> ItemTitles = new List<ItemTitle>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    ItemTitle ItemTitle = new ItemTitle
                    {
                        title_id = int.Parse($"{table.Rows[x][ItemTitle.TITLE_ID]}"),
                        item_name = $"{table.Rows[x][ItemTitle.ITEM_NAME]}",
                    };
                    ItemTitles.Add(ItemTitle);
                }
                db.Close();
                return ItemTitles;
            }
        }

        public void Add(ItemTitle itemTitle)
        {
            string query = $"insert into {ItemTitle.TABLE_NAME} (" +
            $"{ItemTitle.ITEM_NAME}) values(" +
            $"'{itemTitle.item_name}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Update(ItemTitle itemTitle)
        {
            string query = $"update {ItemTitle.TABLE_NAME} set " +
             $"{ ItemTitle.TITLE_ID} = '{itemTitle.title_id}', " +
            $"{ ItemTitle.ITEM_NAME} = '{itemTitle.item_name}' " +
            $"where { ItemTitle.TITLE_ID}={ itemTitle.title_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {ItemTitle.TABLE_NAME} where {ItemTitle.TITLE_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}