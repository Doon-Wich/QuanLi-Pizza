using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DTO
{
    public class Staff
    {
        public Staff(int id, string staffName, string gender , DateTime? dayin, string address, string phonenum) 
        {
            this.id = id;
            this.staffName = staffName;
            this.gender = gender;
            this.dayin = dayin;
            this.address = address;
            this.phonenum = phonenum;
        }

        public Staff(DataRow row)
        {
            this.id = (int)row["id"];
            this.staffName = row["staffName"].ToString();
            this.gender = row["gender"].ToString();

            var Dayintemp = row["dayin"];
            if (Dayintemp.ToString() != "")
                this.dayin = (DateTime?)Dayintemp;
          
            this.address = row["address"].ToString();
            this.phonenum = row["phonenum"].ToString();
        }

        private string phonenum;

        private string address;

        private DateTime? dayin;

        private string gender;

        private string staffName;

        private int id;

        public int Id { get => id; set => id = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime? Dayin { get => dayin; set => dayin = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }

    }
}
