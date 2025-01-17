﻿using Quanlipizza.DAO;
using Quanlipizza.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Quanlipizza
{
    public partial class fAccountProfile : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fAccountProfile(Account acc)
        {
            this.LoginAccount = acc;

            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);

            ChangeAccount(this.LoginAccount);
        }

        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPassWord.Text;
            string reenterPass = txbRepeatPassWord.Text;
            string username = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại đúng mật khẩu với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu !");
                }
            }
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
