using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance{
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set {BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.BillInfo where idBill = " + id );

            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);
                listBillInfo.Add(billInfo);

            }
            return listBillInfo;
        }

        public List<BillInfo> GetListBillInfo1()
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.BillInfo");

            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);
                listBillInfo.Add(billInfo);

            }
            return listBillInfo;
        }

        public void DeleteBillInfoByStaffID(int id)

        {
            string query = "EXEC DeleteBillForDeleteStaff @staffid ";

            DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public void InsertBillInfo(int idBill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertBillInfo @idBill , @idFood , @count" , new object[] { idBill, idfood , count});
        }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.BillInfo where idFood = " + id);
        }

        public void DeleteBillInfoByBillID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.BillInfo where idBill = " + id);
        }
    }
}
