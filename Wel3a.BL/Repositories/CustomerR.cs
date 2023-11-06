using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;

namespace Wel3a.BL
{
    public class CustomerR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);
        public List<Customer> Customers
        {
            get
            {
                db.Open();
                string query = $"select * from {Customer.TABLE_NAME}";
                DataTable table = db.GetData(query);
                List<Customer> customers = new List<Customer>();
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    Customer customer = new Customer
                    {
                        customer_id = int.Parse($"{table.Rows[x][Customer.CUSTOMER_ID]}"),
                        customer_name = $"{table.Rows[x][Customer.CUSTOMER_NAME]}",
                        customer_phone = $"{table.Rows[x][Customer.CUSTOMER_PHONE]}",
                        customer_notes = $"{table.Rows[x][Customer.CUSTOMER_NOTES]}"
                    };
                    customers.Add(customer);
                }
                db.Close();
                return customers;
            }
        }

        public void Add(Customer customer)
        {
            int id = GetNewID();
            string query = $"insert into {Customer.TABLE_NAME} (" +
            $"{Customer.CUSTOMER_ID}, " +
            $"{Customer.CUSTOMER_NAME}, " +
            $"{Customer.CUSTOMER_PHONE}, " +
            $"{Customer.CUSTOMER_NOTES}) values(" +
            $"'{id}'," +
            $"'{customer.customer_name}'," +
            $"'{customer.customer_phone}'," +
            $"'{customer.customer_notes}')";
            db.Open();
            db.Run(query);
            db.Close();
        }

        private int GetNewID()
        {
            string query = $"select max({Customer.CUSTOMER_ID})+1 " +
                $"from {Customer.TABLE_NAME};";
            db.Open();
            string strID = $"{db.GetData(query).Rows[0][0]}";
            if (string.IsNullOrEmpty(strID)) return 1;
            return int.Parse(strID);
        }

        public void Update(Customer customer)
        {
            string query = $"update {Customer.TABLE_NAME} set " +
                $"{ Customer.CUSTOMER_ID} = '{customer.customer_id}', " +
                $"{ Customer.CUSTOMER_NAME} = '{customer.customer_name}', " +
                $"{ Customer.CUSTOMER_PHONE} = '{customer.customer_phone}', " +
                $"{ Customer.CUSTOMER_NOTES} = '{customer.customer_notes}' " +
                $"where {Customer.CUSTOMER_ID}={customer.customer_id}";
            db.Open();
            db.Run(query);
            db.Close();
        }

        public void Delete(int id)
        {
            db.Open(); string querry = $"delete from {Customer.TABLE_NAME} where {Customer.CUSTOMER_ID}={id}";
            db.Run(querry);
            db.Close();
        }
    }
}