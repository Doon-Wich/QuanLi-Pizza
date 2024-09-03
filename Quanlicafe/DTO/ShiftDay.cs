using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class ShiftDay
    {
        public ShiftDay(int staffid, int shiftid, DateTime? shiftday)
        {
            this.staffid = staffid;
            this.shiftid = shiftid;
            this.shiftday = shiftday;
        }

        public ShiftDay(DataRow row)
        {
            this.staffid = (int)row["staffid"];
            this.shiftid = (int)row["shiftid"];
            this.shiftday = (DateTime?)row["shiftday"];
        }

        private DateTime? shiftday;

        private int shiftid;

        private int staffid;

        public int Staffid { get => staffid; set => staffid = value; }
        public int Shiftid { get => shiftid; set => shiftid = value; }
        public DateTime? Shiftday { get => shiftday; set => shiftday = value; }
    }
}
