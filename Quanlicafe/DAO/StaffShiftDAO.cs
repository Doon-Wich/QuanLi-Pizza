using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class StaffShiftDAO
    {
        private static StaffShiftDAO instance;

        public static StaffShiftDAO Instance
        {
            get { if (instance == null) instance = new StaffShiftDAO(); return StaffShiftDAO.instance; }
            private set { StaffShiftDAO.instance = value; }
        }

        private StaffShiftDAO() { }

        public List<Staffshift> GetStaffShiftList()
        {

            List<Staffshift> shiftlist = new List<Staffshift>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Staffshift");

            foreach (DataRow row in data.Rows)
            {
                Staffshift shift = new Staffshift(row);


                shiftlist.Add(shift);

            }

            return shiftlist;
        }

        public void UpdateTime(int id) 
        {
            DataProvider.Instance.ExecuteQuery("EXEC Updatetime @id ", new object[] {id });
        }

        public bool UpdateShift(int id, string name, int salary, string s, string e)
        {
            string query = ("Update dbo.Staffshift set shiftname = N'" + name + "' , salary = "+ salary +", starttime = '" + s + "', endtime = '" + e + "'  where id = " + id +" ");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
