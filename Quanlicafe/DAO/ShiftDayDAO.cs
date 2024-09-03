using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class ShiftDayDAO
    {
        private static ShiftDayDAO instance;

        public static ShiftDayDAO Instance
        {
            get { if (instance == null) instance = new ShiftDayDAO(); return ShiftDayDAO.instance; }  
            private set { ShiftDayDAO.instance = value; } 
        }

        private ShiftDayDAO() { }

        public List<ShiftDay> GetShiftDayList()
        {
            List<ShiftDay> listShiftDay = new List<ShiftDay>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.ShiftDetail");

            foreach (DataRow row in data.Rows)
            {
                ShiftDay shiftDay = new ShiftDay(row);
                listShiftDay.Add(shiftDay);


            }
            return listShiftDay;
        }

        public List<ShiftDay> GetShiftDayListByID(int id)
        {
            List<ShiftDay> listShiftDay = new List<ShiftDay>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.ShiftDetail where staffid = " + id + "");

            foreach (DataRow row in data.Rows)
            {
                ShiftDay shiftDay = new ShiftDay(row);
                listShiftDay.Add(shiftDay);

            }
            return listShiftDay;
        }

        public List<ShiftDay> GetShiftDayListInOneDay(string shiftday)
        {
            List<ShiftDay> listShiftDay = new List<ShiftDay>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.ShiftDetail where shiftday = '" + shiftday + "' ");

            foreach (DataRow row in data.Rows)
            {
                ShiftDay shiftDay = new ShiftDay(row);
                listShiftDay.Add(shiftDay);

            }
            return listShiftDay;
        }

        public int GetStaffIDCurrentShift(string currenttime)
        {
            string query = "select sd.staffid from dbo.ShiftDetail sd inner join dbo.Staffshift ss on sd.shiftid = ss.id where ss.starttime <= '" + currenttime + "' and ss.endtime >= '" + currenttime + "' and DATEDIFF(day, sd.shiftday,GETDATE()) = 0 ";

            if (DataProvider.Instance.ExecuteScalar(query) == null)
            {
                return -1;
            }

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public bool InsertDay(int staffid, int shiftid, string day)
        {
            string query = ("Insert into dbo.ShiftDetail (staffid, shiftid, shiftday) values (" + staffid + ", " + shiftid + ",  '" + day + "' )");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDay(int staffid, int shiftid, string day)
        {
            string query = ("Update dbo.ShiftDetail set staffid = " + staffid + ", shiftid = " + shiftid + ", shiftday = '" + day + "' where shiftday = '" + day + "' and shiftid = " + shiftid + "");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDay(int staffid, int shiftid, string day)
        {

            string query = string.Format("Delete from dbo.ShiftDetail where staffid = {0} and shiftid = {1} and shiftday = '{2}' ", staffid, shiftid, day);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteDayByStaffID(int staffid)
        {
            DataProvider.Instance.ExecuteQuery("Delete from dbo.ShiftDetail where staffid = " + staffid + "");
        }
    }
}
