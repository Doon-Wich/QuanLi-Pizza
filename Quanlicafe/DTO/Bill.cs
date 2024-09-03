using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn,DateTime? dateCheckOut,int Status, int discount , int staffid, int customerid)
        {
            this.Id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.Status = Status;
            this.Staffid = staffid;
            this.Discount = discount;
            this.Customerid = customerid;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];
            var DateCheckOutTemp = row["dateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.dateCheckOut = (DateTime?)DateCheckOutTemp;
            this.Status = (int)row["Status"];

            if(row["discount"].ToString() != "")
            this.Discount = (int)row["discount"];

            this.Staffid = (int)row["staffid"];
            this.Customerid = (int)row["customerid"];

        }
        private int customerid;

        private int staffid;

        private int discount;

        private int Status;

        private DateTime? dateCheckOut;

        private DateTime? dateCheckIn;

        private int id;

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status1 { get => Status; set => Status = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Staffid { get => staffid; set => staffid = value; }
        public int Customerid { get => customerid; set => customerid = value; }
    }
}
