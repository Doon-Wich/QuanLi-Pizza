using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quanlipizza.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (FoodDAO.instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "Select * from Food where idCategory = " + id;


            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }

            return list;

        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("Select * from dbo.Food where dbo.fuConvertToUnsign1(name) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);


            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodList()
        {
            List<Food> list = new List<Food>();

            string query = "Select * from Food";


            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }

            return list;

        }

        public void DeleteFoodByCategoryID(int idCategory)
        {
            string query = "Delete from dbo.Food where idCategory = " + idCategory;

            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("Insert into dbo.Food ( name, idCategory, price) values (N'{0}', {1}, {2})", name, id, price);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;  
        }

        public bool UpdateFood(int id,string name, int idCategory, float price)
        {
            string query = string.Format("Update dbo.Food set name = N'{1}', idCategory = {2}, price = {3} where id = {0}", id, name, idCategory, price);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
            string query = string.Format("Delete from dbo.Food where id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
