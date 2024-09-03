using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quanlipizza.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }   // get method
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password) {
            string query = "exec dbo.Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,password});

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string username, string displayname, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @userName , @displayName , @passWord , @newPassWord", new object[] { username, displayname, pass, newPass });

            return result > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where userName = '" + userName + "'");

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }

        public List<Account> GetAccountList()
        {

            List<Account> accountlist = new List<Account>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Account");

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);


                accountlist.Add(acc);

            }

            return accountlist;
        }

        public bool InsertAccount(string username, string displayname, int type)
        {
            string query = string.Format("Insert into dbo.Account ( username, displayname, type) values (N'{0}', N'{1}', {2})", username, displayname, type);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string username, string displayname, int type)
        {
            string query = string.Format("Update dbo.Account Set displayname = N'{1}', type = {2} where username = N'{0}'", username, displayname, type);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("Delete from dbo.Account where username = N'{0}'", username);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string username)
        {
            string query = string.Format("Update dbo.Account set password = N'0' where username = N'{0}'",username);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
