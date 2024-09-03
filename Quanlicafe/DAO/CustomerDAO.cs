using Quanlipizza.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if(instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }  
            private set { CustomerDAO.instance = value; }  
        }

        private CustomerDAO() { }

        public List<Customer> GetCustomerList()
        {

            List<Customer> customerlist = new List<Customer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Customer");

            foreach (DataRow row in data.Rows)
            {
                Customer customer = new Customer(row);


                customerlist.Add(customer);

            }

            return customerlist;
        }

        public void UpdateCustomerPoint(int id)
        {
            DataProvider.Instance.ExecuteQuery("Update dbo.Customer set point = point + 1 where id = " + id + "");
        }

        public int GetCustomerID()
        {
            string query = "Select MAX(id) from dbo.Customer";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public string GetCustomerNameByID(int id)
        {
            string query = "Select name from dbo.Customer where id = " + id + "";
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        public bool InsertCustomer(string name, string phonenum, string address)
        {
            string query = string.Format("Insert into dbo.Customer ( name, phonenum, address, point, typeid) values (N'" + name + "', '" + phonenum + "', N'" + address + "', 1, 1)");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCustomer( int id,string name, string phonenum, string address, int point, int typeid)
        {
            string query = "Update dbo.Customer set name = N'" + name + "', phonenum = '" + phonenum + "', address = N'" + address + "', point = '" + point + "', typeid = '" + typeid + "' where id = " + id + "";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteCustomerByID(int id)
        {
            DataProvider.Instance.ExecuteQuery("Delete from dbo.Customer where id = " + id + "");
        }

        public bool DeleteCustomer(int id)
        {
            string query = string.Format("Delete from dbo.Customer where id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
