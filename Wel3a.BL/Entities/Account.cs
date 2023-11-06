using System.Collections.Generic;
using System.Linq;

namespace Wel3a.BL
{
    public enum AccountType
    {
        Admin,
        Secreatary
    }

    public class Account
    {
        #region fields
        public int account_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public AccountType account_type { get; set; }
        #endregion

        #region Fields In Database
        public static string TABLE_NAME { get; set; } = "accounts";
        public static string ACCOUNT_ID { get; set; } = "account_id";
        public static string USERNAME { get; set; } = "username";
        public static string PASSWORD { get; set; } = "password";
        public static string NAME { get; set; } = "name";
        public static string ACCOUNT_TYPE { get; set; } = "account_type";
        #endregion

        #region Helper Properities
        public List<AccountRight> rights
        {
            get
            {
                return new AccountRightR().AccountRights.Where(r => r.account_id == this.account_id).ToList();
            }
        }
        #endregion
    }
}
