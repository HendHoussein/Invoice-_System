using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class AccountRightR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<AccountRight> AccountRights
        {
            get
            {
                db.Open();
                string query = $"select * from {AccountRight.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<AccountRight> accountRights = new List<AccountRight>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    AccountRight accountRight = new AccountRight
                    {
                        right_id = int.Parse($"{table.Rows[x][AccountRight.RIGHT_ID]}"),
                        money_paid = double.Parse($"{table.Rows[x][AccountRight.MONEY_PAID]}"),
                        start_date_of_right = $"{table.Rows[x][AccountRight.START_DATE_OF_RIGHT]}",
                        end_date_of_right = $"{table.Rows[x][AccountRight.END_DATE_OF_RIGHT]}",
                        account_id = int.Parse($"{table.Rows[x][AccountRight.ACCOUNT_ID]}"),
                        describtion = $"{table.Rows[x][AccountRight.DESCRIBTION]}"
                    };
                    string strType = $"{table.Rows[x][AccountRight.RIGHT_TYPE]}";
                    RightType type;
                    Enum.TryParse(strType, out type);
                    accountRight.right_type = type;
                    accountRights.Add(accountRight);
                }
                db.Close();
                return accountRights;
            }
        }

        public void Add(AccountRight accountRight)
        {
            string query = $"insert into {AccountRight.TABLE_NAME} (" +
                $"{AccountRight.RIGHT_ID}, " +
                $"{AccountRight.RIGHT_TYPE}, " +
                $"{AccountRight.MONEY_PAID}, " +
                $"{AccountRight.START_DATE_OF_RIGHT}, " +
                $"{AccountRight.END_DATE_OF_RIGHT}, " +
                $"{AccountRight.ACCOUNT_ID}, " +
                $"{AccountRight.DESCRIBTION}) values(" +
                $"'{accountRight.right_id}'," +
                $"'{accountRight.right_type}'," +
                $"'{accountRight.money_paid}'," +
                $"'{accountRight.start_date_of_right}'," +
                $"'{accountRight.end_date_of_right}'," +
                $"'{accountRight.account_id}'," +
                $"'{accountRight.describtion}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Update(AccountRight accountRight)
        {
            string query = $"update {AccountRight.TABLE_NAME} set " +
                $"{ AccountRight.RIGHT_ID} = '{accountRight.right_id}', " +
                $"{ AccountRight.RIGHT_TYPE} = '{accountRight.right_type}', " +
                $"{ AccountRight.MONEY_PAID} = '{accountRight.money_paid}', " +
                $"{ AccountRight.START_DATE_OF_RIGHT} = '{accountRight.start_date_of_right}', " +
                $"{ AccountRight.END_DATE_OF_RIGHT} = '{accountRight.end_date_of_right}', " +
                $"{ AccountRight.ACCOUNT_ID} = '{accountRight.account_id}', " +
                $"{ AccountRight.DESCRIBTION} = '{accountRight.describtion}' " +
                $"where { AccountRight.RIGHT_ID}={ accountRight.right_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {AccountRight.TABLE_NAME} where {AccountRight.RIGHT_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}