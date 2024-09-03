using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class StaffDetail
    {
        public StaffDetail(int staffid, int totalhour, int salary) 
        { 
            this.Staffid = staffid;
            this.Totalhour = totalhour;
            this.Salary = salary;
        }

        public StaffDetail(DataRow row)
        {
            this.Staffid = (int)row["staffid"];
            this.Totalhour = (int)row["totalhour"];
            this.Salary = (int)row["salary"];
        }


        private int staffid;

        private int totalhour;

        private int salary;
        public int Staffid { get => staffid; set => staffid = value; }
        public int Totalhour { get => totalhour; set => totalhour = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
