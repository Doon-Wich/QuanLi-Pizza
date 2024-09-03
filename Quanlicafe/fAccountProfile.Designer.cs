namespace Quanlipizza
{
    partial class fAccountProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            txbUserName = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            txbDisplayName = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            txbPassWord = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txbNewPassWord = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            txbRepeatPassWord = new TextBox();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbUserName);
            panel1.Location = new Point(19, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 71);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập:";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(189, 24);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(560, 27);
            txbUserName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbDisplayName);
            panel2.Location = new Point(19, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 71);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(189, 24);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(560, 27);
            txbDisplayName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txbPassWord);
            panel3.Location = new Point(19, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 71);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 27);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(189, 24);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(560, 27);
            txbPassWord.TabIndex = 0;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txbNewPassWord);
            panel4.Location = new Point(19, 298);
            panel4.Name = "panel4";
            panel4.Size = new Size(760, 71);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 27);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu mới:";
            // 
            // txbNewPassWord
            // 
            txbNewPassWord.Location = new Point(189, 24);
            txbNewPassWord.Name = "txbNewPassWord";
            txbNewPassWord.Size = new Size(560, 27);
            txbNewPassWord.TabIndex = 0;
            txbNewPassWord.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txbRepeatPassWord);
            panel5.Location = new Point(19, 375);
            panel5.Name = "panel5";
            panel5.Size = new Size(760, 71);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 27);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 2;
            label5.Text = "Nhập lại:";
            // 
            // txbRepeatPassWord
            // 
            txbRepeatPassWord.Location = new Point(189, 24);
            txbRepeatPassWord.Name = "txbRepeatPassWord";
            txbRepeatPassWord.Size = new Size(560, 27);
            txbRepeatPassWord.TabIndex = 0;
            txbRepeatPassWord.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(663, 454);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(69, 36);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(504, 454);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(93, 36);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 499);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txbUserName;
        private Panel panel2;
        private Label label2;
        private TextBox txbDisplayName;
        private Panel panel3;
        private Label label3;
        private TextBox txbPassWord;
        private Panel panel4;
        private Label label4;
        private TextBox txbNewPassWord;
        private Panel panel5;
        private Label label5;
        private TextBox txbRepeatPassWord;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
    }
}