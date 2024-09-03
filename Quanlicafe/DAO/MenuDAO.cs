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
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance {
            get { if (MenuDAO.instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }   
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            DataTable data = DataProvider.Instance.ExecuteQuery
                ("SELECT f.name, bi.count, f.price, (f.price*bi.count) as 'total' from dbo.Bill b inner join dbo.BillInfo bi on bi.idBill = b.id inner join dbo.Food f on bi.idFood = f.id where b.status = 0 AND b.idTable = " + id);

            foreach (DataRow row in data.Rows)
            {
                Menu menu = new Menu(row);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}

