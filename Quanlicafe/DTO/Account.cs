using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class Account
    {
        public Account(string UserName, string DisplayName, int type ,string PassWord = null) 
        { 
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.Type = type;
            this.PassWord = PassWord;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.PassWord = row["passWord"].ToString(); 
        }

        private int type;

        private string passWord;

        private string displayName;

        private string userName;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
    }
}
