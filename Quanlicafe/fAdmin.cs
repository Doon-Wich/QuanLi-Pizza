using MaterialSkin.Controls;
using Quanlipizza.DAO;
using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanlipizza
{
    public partial class fAdmin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        BindingSource foodlist = new BindingSource();

        BindingSource categorylist = new BindingSource();

        BindingSource tablelist = new BindingSource();

        BindingSource accountlist = new BindingSource();

        BindingSource stafflist = new BindingSource();

        BindingSource staffshiftlist = new BindingSource();

        BindingSource staffdetaillist = new BindingSource();

        BindingSource shiftdaylist = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);

            Load();
        }

        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listfood = FoodDAO.Instance.SearchFoodByName(name);

            return listfood;
        }

        void Load()
        {
            dtgvFood.DataSource = foodlist;

            dtgvCategory.DataSource = categorylist;

            dtgvTable.DataSource = tablelist;

            dtgvAccount.DataSource = accountlist;

            dtgvStaff.DataSource = stafflist;

            dtgvShift.DataSource = staffshiftlist;

            dtgvSalary.DataSource = staffdetaillist;

            dtgvShiftDay.DataSource = shiftdaylist;

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            LoadDateTimePickerBill();

            LoadFoodList();

            LoadCategoryList();

            LoadTableList();

            LoadAccountList();

            LoadStaffList();

            LoadStaffShiftList();

            LoadStaffDetailList();

            LoadShiftDayList();

            AddFoodBinding();

            AddCategoryBinding();

            AddTableBinding();

            AddAccountBinding();

            AddStaffBinding();

            AddStaffShiftBinding();

            AddStaffDetailBinding();

            LoadCategoryIntoCombobox(cbFoodCategory);

            LoadStatusIntoCombobox(cbTableStatus);

            LoadGenderIntoCombobox(cbGender);

            LoadStaffIDIntoCombobox(cbStaffIDShiftDay);

            UpdateTime();

        }
        void UpdateTime()
        {
            List<Staffshift> shiftlist = new List<Staffshift>();
            shiftlist = StaffShiftDAO.Instance.GetStaffShiftList();
            foreach (Staffshift shift in shiftlist)
            {
                StaffShiftDAO.Instance.UpdateTime(shift.Id);
            }
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Today;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
        }

        #endregion

        #region events

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            dtgvFood.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void btnViewBIll_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }

        void LoadFoodList()
        {
            foodlist.DataSource = FoodDAO.Instance.GetFoodList();
        }

        void LoadCategoryList()
        {
            categorylist.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void LoadTableList()
        {
            tablelist.DataSource = TableDAO.Instance.GetTableList();
        }

        void LoadAccountList()
        {
            accountlist.DataSource = AccountDAO.Instance.GetAccountList();
        }

        void LoadStaffList()
        {
            stafflist.DataSource = StaffDAO.Instance.GetStaffList();
        }

        void LoadStaffShiftList()
        {
            staffshiftlist.DataSource = StaffShiftDAO.Instance.GetStaffShiftList();
        }

        void LoadStaffDetailList()
        {
            staffdetaillist.DataSource = StaffDetailDAO.Instance.GetStaffDetailList();
        }

        void LoadShiftDayList()
        {
            shiftdaylist.DataSource = ShiftDayDAO.Instance.GetShiftDayList();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddStaffBinding()
        {
            txbStaffID.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbStaffName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "StaffName", true, DataSourceUpdateMode.Never));
            txbAddress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Phonenum", true, DataSourceUpdateMode.Never));
            dtpDayin.DataBindings.Add(new Binding("Value", dtgvStaff.DataSource, "Dayin", true, DataSourceUpdateMode.Never));
        }

        void AddStaffShiftBinding()
        {
            txbShiftID.DataBindings.Add(new Binding("Text", dtgvShift.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbShiftName.DataBindings.Add(new Binding("Text", dtgvShift.DataSource, "ShiftName", true, DataSourceUpdateMode.Never));
            nmSalary.DataBindings.Add(new Binding("Value", dtgvShift.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            dtpStartTime.DataBindings.Add(new Binding("Value", dtgvShift.DataSource, "StartTime", true, DataSourceUpdateMode.Never));
            dtpEndTime.DataBindings.Add(new Binding("Value", dtgvShift.DataSource, "EndTime", true, DataSourceUpdateMode.Never));
        }

        void AddStaffDetailBinding()
        {
            txbStaffIDSalary.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "StaffID", true, DataSourceUpdateMode.Never));
            txbTotalSalary.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            nmTotalHours.DataBindings.Add(new Binding("Value", dtgvSalary.DataSource, "TotalHour", true, DataSourceUpdateMode.Never));
        }

        private void dtgvShiftDay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            cbStaffIDShiftDay.Text = dtgvShiftDay.Rows[r].Cells[0].Value.ToString();
            txbShiftIDShiftDay.Text = dtgvShiftDay.Rows[r].Cells[1].Value.ToString();
            dtpShiftDay.Text = dtgvShiftDay.Rows[r].Cells[2].Value.ToString();
        }

        void LoadStaffIDIntoCombobox(ComboBox cb)
        {
            cb.DataSource = StaffDAO.Instance.GetStaffList();
            cb.DisplayMember = "id";
        }

        private void cbStaffIDShiftDay_TextChanged(object sender, EventArgs e)
        {
            int id = (cbStaffIDShiftDay.SelectedItem as Staff).Id;
            dtgvShiftDay.DataSource = ShiftDayDAO.Instance.GetShiftDayListByID(id);
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadStatusIntoCombobox(ComboBox cb)
        {
            cb.Items.Add("Trống");
            cb.Items.Add("Có Người");
        }

        void LoadGenderIntoCombobox(ComboBox cb)
        {
            cb.Items.Add("Nam");
            cb.Items.Add("Nữ");
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cbFoodCategory.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (Category item in cbFoodCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbFoodCategory.SelectedIndex = index;
            }
        }

        private void txbTableID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvTable.SelectedCells.Count > 0)
            {
                string status = dtgvTable.SelectedCells[0].OwningRow.Cells["status"].Value.ToString();
                cbTableStatus.Text = status;
            }
        }
        private void txbStaffID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvStaff.SelectedCells.Count > 0)
            {
                try
                {
                    string gender = dtgvStaff.SelectedCells[0].OwningRow.Cells["gender"].Value.ToString();
                    cbGender.Text = gender;
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int foodCategory = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (int)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, foodCategory, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món !");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbFoodID.Text);
            string name = txbFoodName.Text;
            int foodCategory = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (int)nmFoodPrice.Value;
            if (FoodDAO.Instance.UpdateFood(id, name, foodCategory, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món !");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công");
                LoadFoodList();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá món !");
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategory.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadCategoryList();
                LoadFoodList();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (insertCategory != null)
                {
                    insertCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục !");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string name = txbCategory.Text;
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadCategoryList();
                LoadFoodList();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (updateCategory != null)
                {
                    updateCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục !");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xoá danh mục thành công");
                LoadCategoryList();
                LoadFoodList();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (deleteCategory != null)
                {
                    deleteCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xoá sửa danh mục !");
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;

            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableList();
                if (insertTable != null)
                {
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn!");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = txbTableName.Text;
            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadTableList();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn!");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = txbTableName.Text;
            if (BillDAO.Instance.GetUncheckBillByID(id) == -1)
            {
                List<int> list = BillDAO.Instance.GetUnCheckedBillByTableIDForDelete(id);
                foreach (int i in list)
                {
                    BillInfoDAO.Instance.DeleteBillInfoByBillID(i);
                }
                BillDAO.Instance.DeleteBillByTableID(id);
                if (TableDAO.Instance.DeleteTable(id))
                {

                    MessageBox.Show("Xoá bàn thành công");
                    LoadTableList();
                    if (deleteTable != null)
                    {
                        deleteTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xoá bàn!");
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá bàn vì " + name + " đang có người !");
                return;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string displayname = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;
            if (AccountDAO.Instance.InsertAccount(username, displayname, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản !");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string displayname = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;
            if (AccountDAO.Instance.UpdateAccount(username, displayname, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản !");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if (loginAccount.UserName.Equals(username))
            {
                MessageBox.Show("Tài khoản hiện đang được đăng nhập !");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xoá tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá tài khoản !");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi đặt lại mật khẩu!");
            }
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string name = txbStaffName.Text;
            string gender = cbGender.Text;
            string address = txbAddress.Text;
            string phonenum = txbPhoneNumber.Text;
            string dayin = DateTime.Now.ToString();
            if (StaffDAO.Instance.InsertStaff(name, gender, dayin, address, phonenum))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadStaffList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên !");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbStaffID.Text);
            string name = txbStaffName.Text;
            string gender = cbGender.Text;
            string address = txbAddress.Text;
            string phonenum = txbPhoneNumber.Text;
            string dayin = dtpDayin.Value.ToString();
            if (StaffDAO.Instance.UpdateStaff(id, name, gender, dayin, address, phonenum))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                LoadStaffList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên !");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbStaffID.Text);
            if (StaffDAO.Instance.DeleteStaff(id))
            {
                MessageBox.Show("Xoá nhân viên thành công");
                LoadStaffList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá nhân viên !");
            }
        }

        private void btnShowShift_Click(object sender, EventArgs e)
        {
            LoadStaffShiftList();
        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbShiftID.Text);
            string name = txbShiftName.Text;
            int salary = (int)nmSalary.Value;
            string stat = dtpStartTime.Value.ToString();
            string end = dtpEndTime.Value.ToString();
            if (StaffShiftDAO.Instance.UpdateShift(id, name, salary, stat, end))
            {
                MessageBox.Show("Sửa ca thành công");
                LoadStaffShiftList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa ca!");
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            if ((!IsNumber(txbStaffIDSalary.Text)) || (txbStaffIDSalary.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu !");
                return;
            }
            int staffid = Convert.ToInt32(txbStaffIDSalary.Text);

            int salary = 0;
            int totalhour = 0;
            List<StaffDetail> detaillist = StaffDetailDAO.Instance.GetStaffDetailList();
            List<Staff> stafflist = StaffDAO.Instance.GetStaffList();
            List<Staffshift> shiftlist = StaffShiftDAO.Instance.GetStaffShiftList();
            bool existstaff = false;
            foreach (Staff staff in stafflist)
            {

                if (staff.Id == staffid)
                {
                    existstaff = true;
                    break;
                }
            }
            if (existstaff == false)
            {
                MessageBox.Show("Không tồn tại nhân viên !");
                return;
            }



            foreach (StaffDetail detail in detaillist)
            {

                if (detail.Staffid == staffid)
                {
                    MessageBox.Show("Mã nhân viên không được trùng !");
                    return;
                }

            }
            if (StaffDetailDAO.Instance.InsertDetail(staffid, totalhour, salary))
            {
                MessageBox.Show("Thêm chi tiết nhân viên thành công");
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm chi tiết nhân viên");
            }
        }


        private void btnDeleteSalary_Click(object sender, EventArgs e)
        {
            int staffid = Convert.ToInt32(txbStaffIDSalary.Text);

            if (StaffDetailDAO.Instance.DeleteDetail(staffid))
            {
                MessageBox.Show("Xoá chi tiết nhân viên thành công");
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá chi tiết nhân viên");
            }
        }

        private void btnAddShiftDay_Click(object sender, EventArgs e)
        {
            int staffid = Convert.ToInt32(cbStaffIDShiftDay.Text);
            int shiftid = Convert.ToInt32(txbShiftIDShiftDay.Text);
            DateTime shiftday = dtpShiftDay.Value;
            string txtshiftday = dtpShiftDay.Value.ToString();
            List<ShiftDay> Shiftdaylist1 = ShiftDayDAO.Instance.GetShiftDayList();
            List<ShiftDay> Shiftdaylist2 = ShiftDayDAO.Instance.GetShiftDayListInOneDay(txtshiftday);
            foreach (ShiftDay day in Shiftdaylist1)
            {
                if (day.Shiftday == shiftday)
                {
                    foreach (ShiftDay id in Shiftdaylist2)
                    {
                        if (id.Shiftid == shiftid)
                        {
                            MessageBox.Show("Ca này đã có nhân viên làm !");
                            return;
                        }
                    }
                }
            }
            if (ShiftDayDAO.Instance.InsertDay(staffid, shiftid, shiftday.ToString()))
            {
                MessageBox.Show("Thêm ca thành công ");
                LoadShiftDayList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm ca !!");
            }
        }

        private void btnEditShiftDay_Click(object sender, EventArgs e)
        {
            int staffid = Convert.ToInt32(cbStaffIDShiftDay.Text);
            int shiftid = Convert.ToInt32(txbShiftIDShiftDay.Text);
            DateTime shiftday = dtpShiftDay.Value;
            List<ShiftDay> Shiftdaylist = ShiftDayDAO.Instance.GetShiftDayList();
            foreach (ShiftDay day in Shiftdaylist)
            {
                if (day.Shiftday == shiftday)
                {
                    foreach (ShiftDay id in Shiftdaylist)
                    {
                        if (id.Shiftid == shiftid)
                        {
                            MessageBox.Show("Ca này đã có nhân viên làm !");
                            return;
                        }
                    }
                }
            }
            if (ShiftDayDAO.Instance.UpdateDay(staffid, shiftid, shiftday.ToString()))
            {
                MessageBox.Show("Sửa ca thành công ");
                LoadShiftDayList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa ca !!");
            }
        }

        private void btnDeleteShiftDay_Click(object sender, EventArgs e)
        {
            int staffid = Convert.ToInt32(cbStaffIDShiftDay.Text);
            int shiftid = Convert.ToInt32(txbShiftIDShiftDay.Text);
            string shiftday = dtpShiftDay.Value.ToString();
            if (ShiftDayDAO.Instance.DeleteDay(staffid, shiftid, shiftday))
            {
                MessageBox.Show("Xoá ca thành công ");
                LoadShiftDayList();
                LoadStaffDetailList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá ca !!");
            }
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        #endregion

    }
}

