using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class CustomerTypeDAO
    {
        private static CustomerTypeDAO instance;

        public static CustomerTypeDAO Instance
        {
            get { if (instance == null) instance = new CustomerTypeDAO(); return CustomerTypeDAO.instance; }
            private set { CustomerTypeDAO.instance = value; }
        }

        private CustomerTypeDAO() { }

        public List<CustomerType> GetStaffShiftList()
        {

            List<CustomerType> customertypelist = new List<CustomerType>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Customertype");

            foreach (DataRow row in data.Rows)
            {
                CustomerType customertype = new CustomerType(row);


                customertypelist.Add(customertype);

            }

            return customertypelist;
        }

        public string GetCustomerTypeName(int id) 
        {
            return DataProvider.Instance.ExecuteScalar("Select typename from dbo.Customertype where id = " + id + "").ToString();        
        }

        public int GetCustomerTypeDeal(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("Select deal from dbo.Customertype where id = " + id + "");
        }
    }
}
