using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.id = id;
            this.billID = billID;
            this.foodID = foodID;
            this.count = count;
        }

        public BillInfo(DataRow row)
        {
            this.id = (int)row["id"];
            this.billID = (int)row["idbill"];
            this.foodID = (int)row["idfood"];
            this.count = (int)row["count"];
        }

        private int count;

        private int foodID;

        private int billID;

        private int id;

        public int Id { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
