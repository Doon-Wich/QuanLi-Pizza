using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlipizza.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (CategoryDAO.instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "Select * from FoodCategory";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                Category category = new Category(row);
                list.Add(category); 

            }
            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            List<Category> list = new List<Category>();

            string query = "Select * from FoodCategory where id = " + id;

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                category = new Category(row);
                return category;

            }
            return category;
        }

        public bool InsertCategory(string name) 
        {
            string query = string.Format("Insert into dbo.FoodCategory(name) values (N'{0}')", name);
            
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("Update dbo.FoodCategory set name = N'{1}' where id = {0}", id, name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            
            List<Food> listfood = FoodDAO.Instance.GetFoodByCategoryID(id);
            
            foreach (Food food in listfood)
            {
                BillInfoDAO.Instance.DeleteBillInfoByFoodID(food.Id);
            }
            FoodDAO.Instance.DeleteFoodByCategoryID(id);
            string query = string.Format("Delete from dbo.FoodCategory where id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

