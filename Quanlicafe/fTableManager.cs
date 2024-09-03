using Quanlipizza.DTO;
using Quanlipizza.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MaterialSkin.Controls;
using System.Diagnostics.CodeAnalysis;

namespace Quanlipizza
{
    public partial class fTableManager : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fTableManager(Account acc)
        {
            this.LoginAccount = acc;

            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);

            LoadTable();

            LoadCategory();

            LoadTableList();

            ChangeAccount();

            DisplayCurrentCustomer();

            string current = DateTime.Now.ToString();

            int idStaff = ShiftDayDAO.Instance.GetStaffIDCurrentShift(current);

            if (idStaff == -1)
            {
                txbStaffName.Text = "Hiện không có nhân viên nào !";
            }
            else
            {
                txbStaffName.Text = StaffDAO.Instance.GetStaffNameByID(idStaff);
            }

        }

        #region Method

        void SetControls(bool edit)
        {
            btnAddPoint.Enabled = edit;
        }


        void ChangeAccount()
        {
            if (this.LoginAccount.Type == 1)
                adminToolStripMenuItem.Enabled = true;
            else
            {
                adminToolStripMenuItem.Enabled = false;
            }
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ") ";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCatagory.DataSource = listCategory;
            cbCatagory.DisplayMember = "Name";
        }

        void LoadFoodByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.GetTableList();
            foreach (Table table in tablelist)
            {
                Button button = new Button() { Width = TableDAO.Width, Height = TableDAO.Height };
                button.Text = table.Name + Environment.NewLine + table.Status;
                button.Click += btn_Click;
                button.Tag = table;


                switch (table.Status)
                {
                    case "Trống":
                        button.BackColor = Color.White;
                        break;
                    default:
                        button.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(button);
            }
        }

        void Show_Bill(int id)
        {
            float totalPrice = 0;
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            DataTable dt = new DataTable();
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            Show_Bill(TableID);
        }

        private void LoadTableList()
        {
            cbSwitchTable.Items.Clear();
            List<Table> listTable = TableDAO.Instance.GetTableList();
            cbSwitchTable.DataSource = listTable;
            cbSwitchTable.DisplayMember = "Name";
        }

        

        private void thôngtinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản " + " (" + e.Acc.DisplayName + ") ";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            f.DeleteFood += f_DeleteFood;
            f.InsertCategory += f_InsertCategory;
            f.UpdateCategory += f_UpdateCategory;
            f.DeleteCategory += f_DeleteCategory;
            f.InsertTable += f_InsertTable;
            f.UpdateTable += f_UpdateTable;
            f.DeleteTable += f_DeleteTable;
            f.ShowDialog();
        }

        void f_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        void f_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        void f_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        void f_InsertCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
        }

        void f_UpdateCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
        }

        void f_DeleteCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
            LoadTable();
        }
        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodByCategoryID((cbCatagory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
        }

        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodByCategoryID((cbCatagory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodByCategoryID((cbCatagory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                Show_Bill(((lsvBill).Tag as Table).ID);
            LoadTable();
        }

       

        #endregion

        #region Events

        private void cbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodByCategoryID(id);
        }

        int OldCusID = 0;
        bool isOldCus = false;
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            string name = txbCustomerName.Text.TrimEnd().TrimStart();
            string phonenum = txbCustomerPhone.Text.TrimEnd().TrimStart();
            string address = txbCustomerAddress.Text.TrimEnd().TrimStart();
            List<Customer> customerlist = CustomerDAO.Instance.GetCustomerList();
            
            if ((txbCustomerName.Text.Trim() == "") || (txbCustomerPhone.Text.Trim() == "") || (txbCustomerAddress.Text.Trim() == ""))
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            foreach (Customer customer in customerlist)
            {
                if ((customer.Name == name) && (customer.Phonenum == phonenum))
                {
                    OldCusID = customer.Id;
                    CustomerDAO.Instance.UpdateCustomerPoint(customer.Id);
                    MessageBox.Show("Tích điểm thành công cho khách hàng " + customer.Name + "");
                    if ((customer.Point + 1) == 5)
                    {
                        string type = CustomerTypeDAO.Instance.GetCustomerTypeName(customer.Typeid);
                        MessageBox.Show("Khách hàng " + customer.Name + " đã trở thành " + type + "");
                        nmDiscount.Value = CustomerTypeDAO.Instance.GetCustomerTypeDeal(customer.Typeid);
                        int discount = CustomerTypeDAO.Instance.GetCustomerTypeDeal(customer.Typeid);
                        MessageBox.Show("Quý Khách " + customer.Name + " nhận được mã giảm giá " + discount + "%");
                    }
                    if ((customer.Point + 1) > 5)
                    {
                        int discount = CustomerTypeDAO.Instance.GetCustomerTypeDeal(customer.Typeid);
                        MessageBox.Show("Quý Khách " + customer.Name + " nhận được mã giảm giá " + discount + "%");
                        nmDiscount.Value = discount;
                    }
                    isOldCus = true;
                    break;
                }
            }

            if (!isOldCus)
            {
                if (CustomerDAO.Instance.InsertCustomer(name, phonenum, address))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm khách hàng !!!");
                }
            }
            DisplayCurrentCustomer();
            SetControls(false);
        }

        void DisplayCurrentCustomer()
        {
            if (isOldCus)
            {
                txbCurrentCustomer.Text = CustomerDAO.Instance.GetCustomerNameByID(OldCusID);
            }
            else
            {
                int checkexists = (int)DataProvider.Instance.ExecuteScalar("Select count(*) from dbo.Customer");
                if (checkexists > 0)
                {
                    int currentcusid = CustomerDAO.Instance.GetCustomerID();
                    txbCurrentCustomer.Text = CustomerDAO.Instance.GetCustomerNameByID(currentcusid);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Table table = lsvBill.Tag as Table;

            string current = DateTime.Now.ToString();

            int idStaff = ShiftDayDAO.Instance.GetStaffIDCurrentShift(current);

            if (idStaff == -1)
            {
                MessageBox.Show("Hiện tại cửa hàng đã đóng, Quý khách vui lòng quay lại vào ngày hôm sau !!!");
                return;
            }
            else

            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillByID(table.ID);
            int idFood = (cbFood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;
            int customerid = 0;
            if (isOldCus)
            {
                customerid = OldCusID;
            }
            else
            {
                int checkexists = (int)DataProvider.Instance.ExecuteScalar("Select count(*) from dbo.Customer");
                if (checkexists > 0)
                {
                    customerid = CustomerDAO.Instance.GetCustomerID();
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm khách hàng !!");
                    return ;
                }
                
            }



            if (count == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (idBill == -1)
            {
                string currenttime = DateTime.Now.ToString();
                int staffid = ShiftDayDAO.Instance.GetStaffIDCurrentShift(currenttime);
                BillDAO.Instance.InsertBill(table.ID, staffid, customerid);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetmaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            Show_Bill(table.ID);

            LoadTable();
            int checkexists1 = (int)DataProvider.Instance.ExecuteScalar("Select count(*) from dbo.Bill where customerid = " + customerid + "");
            if(checkexists1 > 0)
            {
                SetControls(true);
            }
            else
            {
                SetControls(false);
            }
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if ((lsvBill.Tag as Table) == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillByID(table.ID);

            int discount = (int)nmDiscount.Value;

            string price = txbTotalPrice.Text.Trim();
            price = price.Split()[0];
            string[] chuoi_tach = price.Split(new Char[] { '.' });
            string chuoi_ketqua = "";
            foreach (string s in chuoi_tach)
            {

                if (s.Trim() != "")
                    chuoi_ketqua += s;
            }
            double totalPrice = Convert.ToDouble(chuoi_ketqua);

            double finaltotalPrice = totalPrice - (totalPrice / 100) * discount;



            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn thanh toán hoá đơn cho bàn {0}\n Tổng tiền - (Tổng tiền / 100) * Giảm giá = {1} -  ({1} / 100) * {2} = {3}", table.Name, totalPrice, discount, finaltotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Checkout(idBill, discount, (float)finaltotalPrice);
                    Show_Bill(table.ID);

                    LoadTable();
                }
            }
            nmFoodCount.Value = 0;
            nmDiscount.Value = 0;
            txbCustomerAddress.Clear();
            txbCustomerName.Clear();
            txbCustomerPhone.Clear();

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            string status1 = (lsvBill.Tag as Table).Status;
            string status2 = (cbSwitchTable.SelectedItem as Table).Status;
            string name1 = (lsvBill.Tag as Table).Name;
            string name2 = (cbSwitchTable.SelectedItem as Table).Name;
            int customerid = 0;
            int checkexists = (int)DataProvider.Instance.ExecuteScalar("Select count(*) from dbo.Customer"); 
            if (checkexists > 0)
            {
                customerid = CustomerDAO.Instance.GetCustomerID();
            }
            else
            {
                MessageBox.Show("Vui lòng thêm khách hàng !!");
                return;
            }
            if (status1 == "Trống" && status2 == "Trống")
            {
                MessageBox.Show("Vui lòng thêm món vào " + name1 + " hoặc " + name2 + " ");
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2, customerid);
                LoadTable();
            }
        }

        #endregion

    }
}
        





