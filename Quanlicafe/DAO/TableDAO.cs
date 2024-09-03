using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }


        public static int Width = 90;
        public static int Height = 90;
        public List<Table> GetTableList()
        {

            List<Table> tablelist = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Tablefood");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);


                tablelist.Add(table);

            }

            return tablelist;
        }

        public void SwitchTable(int id1, int id2, int customerid)
        {
            DataProvider.Instance.ExecuteQuery("EXEC switchtable @idtable1 , @idtable2 , @customerid ", new object[]{id1 , id2, customerid});
        }

        public bool InsertTable(string name)
        {
            string query = string.Format("Insert into dbo.Tablefood ( name, status) values (N'{0}', N'Trống')", name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int idTable, string name)
        {
            string query = string.Format("Update dbo.Tablefood set name = N'{1}' where id = {0}", idTable, name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int idTable)
        { 
            string query = string.Format("Delete from dbo.Tablefood where id = {0}", idTable);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
    
