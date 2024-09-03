using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class StaffDetailDAO
    {
        private static StaffDetailDAO instance;
        
        public static StaffDetailDAO Instance
        {
            get { if (instance == null) instance = new StaffDetailDAO(); return StaffDetailDAO.instance; }
            private set { StaffDetailDAO.instance = value; }
        }

        private StaffDetailDAO() { }

        public List<StaffDetail> GetStaffDetailList()
        {
            List<StaffDetail> listDetail = new List<StaffDetail>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.StaffDetail");

            foreach (DataRow row in data.Rows)
            {
                StaffDetail detail = new StaffDetail(row);
                listDetail.Add(detail);


            }
            return listDetail;
        }

        

        public bool InsertDetail(int staffid,int totalhour, int salary)
        {
            string query = ("Insert into dbo.StaffDetail (totalhour, salary, staffid) values ('" + totalhour + "', '" + salary + "',  '" + staffid + "' )");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDetail(int staffid, int totalhour, int salary)
        {
            string query = ("Update dbo.StaffDetail set totalhour = '" + totalhour + "', salary = '" + salary + "', staffid = '" + staffid + "' ");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDetail(int staffid)
        {

            string query = string.Format("Delete from dbo.StaffDetail where staffid = {0}", staffid);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
