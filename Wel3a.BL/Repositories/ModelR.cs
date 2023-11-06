using MySqlControl;

namespace Wel3a.BL
{
    public class ModelR
    {
        MySqlClass db = new MySqlClass(Helper.connectionString);

        public void RunQuery(string query)
        {
            db.Open();
            db.Run(query);
            db.Close();
        }
    }
}