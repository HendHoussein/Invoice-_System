using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class MoneyMovingR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<MoneyMoving> MoneyMovings
        {
            get
            {
                db.Open();
                string query = $"select * from {MoneyMoving.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<MoneyMoving> moneyMovings = new List<MoneyMoving>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    MoneyMoving moneyMoving = new MoneyMoving
                    {
                        moving_id = int.Parse($"{table.Rows[x][MoneyMoving.MOVING_ID]}"),
                        moving_date = $"{table.Rows[x][MoneyMoving.MOVING_DATE]}",
                        moving_value = double.Parse($"{table.Rows[x][MoneyMoving.MOVING_VALUE]}"),
                        moving_hint = $"{table.Rows[x][MoneyMoving.MOVING_HINT]}",
                        moving_direction = $"{table.Rows[x][MoneyMoving.MOVING_DIRECTION]}",
                        account_id = int.Parse($"{table.Rows[x][Account.ACCOUNT_ID]}")
                    };
                    string strType = $"{table.Rows[x][MoneyMoving.MOVING_TYPE]}";
                    MoneyMovingType type;
                    Enum.TryParse(strType, out type);
                    moneyMoving.moving_type = type;
                    moneyMovings.Add(moneyMoving);
                }
                db.Close();
                return moneyMovings;
            }
        }

        public void Add(MoneyMoving moneyMoving)
        {
            string query = $"insert into {MoneyMoving.TABLE_NAME} (" +
                $"{MoneyMoving.MOVING_DATE}, " +
                $"{MoneyMoving.MOVING_VALUE}, " +
                $"{MoneyMoving.MOVING_TYPE}, " +
                $"{MoneyMoving.MOVING_HINT}, " +
                $"{Account.ACCOUNT_ID}, " +
                $"{MoneyMoving.MOVING_DIRECTION}) values(" +
                $"'{moneyMoving.moving_date}'," +
                $"'{moneyMoving.moving_value}'," +
                $"'{moneyMoving.moving_type}'," +
                $"'{moneyMoving.moving_hint}'," +
                $"'{moneyMoving.account_id}'," +
                $"'{moneyMoving.moving_direction}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Update(MoneyMoving moneyMoving)
        {
            string query = $"update {MoneyMoving.TABLE_NAME} set " +
                $"{ MoneyMoving.MOVING_ID} = '{moneyMoving.moving_id}', " +
                $"{ MoneyMoving.MOVING_DATE} = '{moneyMoving.moving_date}', " +
                $"{ MoneyMoving.MOVING_VALUE} = '{moneyMoving.moving_value}', " +
                $"{ MoneyMoving.MOVING_HINT} = '{moneyMoving.moving_hint}', " +
                $"{ Account.ACCOUNT_ID} = '{moneyMoving.account_id}', " +
                $"{ MoneyMoving.MOVING_DIRECTION} = '{moneyMoving.moving_direction}' " +
                $"where { MoneyMoving.MOVING_ID}={ moneyMoving.moving_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {MoneyMoving.TABLE_NAME} " +
                $"where {MoneyMoving.MOVING_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}