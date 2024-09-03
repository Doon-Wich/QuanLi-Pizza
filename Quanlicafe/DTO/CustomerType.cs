using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class CustomerType
    {
        public CustomerType(int id, string name, int deal) 
        {
            this.Id = id;
            this.Name = name;
            this.Deal = deal;
        }   

        public CustomerType(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Deal = (int)row["deal"];
        }

        private int id;

        private string name;

        private int deal;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Deal { get => deal; set => deal = value; }
    }
}
