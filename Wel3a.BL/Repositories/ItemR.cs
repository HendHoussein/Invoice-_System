using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class ItemR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<Item> Items
        {
            get
            {
                db.Open();
                string query = $"select * from {Item.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<Item> itemss = new List<Item>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    Item item = new Item
                    {
                        item_id = int.Parse($"{table.Rows[x][Item.ITEM_ID]}"),
                        title_id = int.Parse($"{table.Rows[x][Item.TITLE_ID]}"),
                        item_price = double.Parse($"{table.Rows[x][Item.ITEM_PRICE]}"),
                        item_name = $"{table.Rows[x][Item.ITEM_NAME]}"
                    };
                    itemss.Add(item);
                }
                db.Close();
                return itemss;
            }
        }

        public void Add(Item item)
        {
            string query = $"insert into {Item.TABLE_NAME} (" +
            $"{Item.TITLE_ID}, " +
            $"{Item.ITEM_NAME}, " +
            $"{Item.ITEM_PRICE}) values(" +
            $"'{item.title_id}'," +
            $"'{item.item_name}'," +
            $"'{item.item_price}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Update(Item item)
        {
            string query = $"update {Item.TABLE_NAME} set " +
             $"{ Item.ITEM_ID} = '{item.item_id}', " +
            $"{ Item.TITLE_ID} = '{item.title_id}', " +
            $"{ Item.ITEM_NAME} = '{item.item_name}', " +
            $"{ Item.ITEM_PRICE} = '{item.item_price}' " +
            $"where { Item.ITEM_ID}={ item.item_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {Item.TABLE_NAME} " +
                $"where {Item.ITEM_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}