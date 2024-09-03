using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }

        public List<Staff> GetStaffList()
        {

            List<Staff> stafflist = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Staff");

            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);


                stafflist.Add(staff);

            }

            return stafflist;
        }

        public string GetStaffNameByID(int id)
        {
            return DataProvider.Instance.ExecuteScalar("Select staffname from dbo.Staff where id = " + id + "").ToString();
        }


        public bool InsertStaff(string name, string gender, string dayin, string address, string phonenum)
        {
            string query = ("Insert into dbo.Staff(staffname, gender, dayin, address, phonenum) values ( N'" + name + "', N'" + gender + "', '" + dayin + "', N'" + address + "', '" + phonenum + "')");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateStaff(int id,string name, string gender, string dayin, string address, string phonenum)
        {
            string query = ("Update dbo.Staff set staffname = N'" + name + "', gender = N'" + gender + "', dayin = N'" + dayin + "', address = N'" + address + "', phonenum = '" + phonenum + "' where id = " + id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteStaff(int id)
        {
            StaffDetailDAO.Instance.DeleteDetail(id);

            ShiftDayDAO.Instance.DeleteDayByStaffID(id);

            List<BillInfo> listbillinfo = BillInfoDAO.Instance.GetListBillInfo1();

            foreach (BillInfo info in listbillinfo)
            {
                BillInfoDAO.Instance.DeleteBillInfoByStaffID(id);
            }

            BillDAO.Instance.DeleteBillByStaffID(id);

            string query = string.Format("Delete from dbo.Staff where id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
