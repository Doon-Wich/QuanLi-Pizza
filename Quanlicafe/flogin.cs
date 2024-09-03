using MaterialSkin.Controls;
using Quanlipizza.DAO;
using Quanlipizza.DTO;

namespace Quanlipizza
{
    public partial class flogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public flogin()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if (Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Login(string username, string passwork)
        {
            return AccountDAO.Instance.Login(username, passwork);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không !", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        
    }
}
