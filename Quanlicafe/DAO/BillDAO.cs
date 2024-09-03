using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Quanlipizza.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        
        public int GetUncheckBillByID(int id)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from dbo.Bill where idTable = " + id + " and status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }

        public bool CustomerCheck(int id)
        {
            string query = string.Format("Select * from dbo.Bill where customerid = " + id + "");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void Checkout(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1 , discount = " + discount + " , totalPrice = " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteQuery(query);  
        }

        public void InsertBill(int idTable, int idStaff, int Customerid)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertBill @idTable , @staffid , @customerid ", new object[] { idTable , idStaff, Customerid });
        }

        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListBillByDate @checkin , @checkout", new object[] {checkin, checkout });
        } 

        public int GetmaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) from dbo.Bill");
            }
            catch
            {
                return -1;
            }
        }

        public void DeleteBillByTableID(int id)
        {
            string query = "Delete from dbo.Bill where idTable = " + id + "";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteBillByStaffID(int id)

        {
            string query = "Delete from dbo.Bill where staffid = " + id + "";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        

        public List<int> GetUnCheckedBillByTableIDForDelete(int id)
        {
            List<int> list = new List<int>();
            DataTable data =  DataProvider.Instance.ExecuteQuery("select * from dbo.Bill where idTable = " + id + " and status = 1");
            
            foreach (DataRow row in data.Rows)
            {
                Bill bill = new Bill(row);
                list.Add(bill.Id);
            }

            return list;
        }
    }
}
