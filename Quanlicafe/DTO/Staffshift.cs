using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Quanlipizza.DTO
{
    public class Staffshift
    {
        public Staffshift(int id, string shiftname, DateTime? starttime, DateTime? endtime, int salary)
        {
            this.id = id;
            this.shiftName = shiftname;
            this.startTime = starttime;
            this.endTime = endtime;
            this.salary = salary;
        }

        public Staffshift(DataRow row)
        {
            this.id = (int)row["id"];
            this.shiftName = row["shiftname"].ToString();
            this.startTime = (DateTime?)row["starttime"];
            this.endTime = (DateTime?)row["endtime"];
            this.salary = (int)row["salary"];
        }

        private int id;

        private string shiftName;

        private DateTime? startTime;

        private DateTime? endTime;

        private int salary;
        public int Id { get => id; set => id = value; }
      
        public int Salary { get => salary; set => salary = value; }
        public string ShiftName { get => shiftName; set => shiftName = value; }
        public DateTime? StartTime { get => startTime; set => startTime = value; }
        public DateTime? EndTime { get => endTime; set => endTime = value; }
    }
}
