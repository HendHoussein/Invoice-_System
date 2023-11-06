using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class AccountR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<Account> Accounts
        {
            get
            {
                db.Open();
                string query = $"select * from {Account.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<Account> accounts = new List<Account>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    Account account = new Account
                    {
                        account_id = int.Parse($"{table.Rows[x][Account.ACCOUNT_ID]}"),
                        username = $"{table.Rows[x][Account.USERNAME]}",
                        password = $"{table.Rows[x][Account.PASSWORD]}",
                        name = $"{table.Rows[x][Account.NAME]}"
                    };
                    string strType = $"{table.Rows[x][Account.ACCOUNT_TYPE]}";
                    AccountType type;
                    Enum.TryParse(strType, out type);
                    account.account_type = type;
                    accounts.Add(account);
                }
                db.Close();
                return accounts;
            }
        }

        public void Add(Account account)
        {
            string query = $"insert into {Account.TABLE_NAME} (" +
                $"{Account.ACCOUNT_ID}, " +
                $"{Account.USERNAME}, " +
                $"{Account.PASSWORD}, " +
                $"{Account.NAME}, " +
                $"{Account.ACCOUNT_TYPE}, values(" +
                $"'{account.account_id}'," +
                $"'{account.username}'," +
                $"'{account.password}'," +
                $"'{account.name}'," +
                $"'{account.account_type}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Update(Account account)
        {
            string query = $"update {Account.TABLE_NAME} set " +
                $"{ Account.ACCOUNT_ID} = '{account.account_id}', " +
                $"{ Account.USERNAME} = '{account.username}', " +
                $"{ Account.PASSWORD} = '{account.password}', " +
                $"{ Account.NAME} = '{account.name}', " +
                $"{ Account.ACCOUNT_TYPE} = '{account.account_type}' " +
                $"where { Account.ACCOUNT_ID}={ account.account_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {Account.TABLE_NAME} where {Account.ACCOUNT_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}