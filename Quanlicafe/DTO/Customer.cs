using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class Customer
    {
        public Customer(int id, string name, string phonenum, string address, int point, int typeid)
        {
            this.id = id;
            this.name = name;
            this.phonenum = phonenum;
            this.address = address;
            this.point = point;
            this.typeid = typeid;
        }

        public Customer(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.phonenum = row["phonenum"].ToString();
            this.address = row["address"].ToString();
            this.point = (int)row["point"];
            this.typeid = (int)row["typeid"];
        }

        private int id;

        private string name;

        private string phonenum;

        private string address;

        private int point;

        private int typeid;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }
        public string Address { get => address; set => address = value; }
        public int Point { get => point; set => point = value; }
        public int Typeid { get => typeid; set => typeid = value; }
    }
}
