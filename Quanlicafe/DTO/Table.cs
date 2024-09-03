using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.iD = id;
            this.name = name;
            this.status = status;
        }

        public Table(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = (string)row["name"];
            this.status = (string)row["status"];
        }

        private string status;

        private string name;

        private int iD;

        public int ID
        {
            get { return iD; }
            set {  iD = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
