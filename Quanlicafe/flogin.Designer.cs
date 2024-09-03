namespace Quanlipizza
{
    partial class flogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            txbUserName = new TextBox();
            txbPassWord = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLogin = new Button();
            btnExit = new Button();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(172, 27);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(337, 27);
            txbUserName.TabIndex = 0;
            txbUserName.Text = "Cayman";
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(172, 38);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(337, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.Text = "54321";
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbUserName);
            panel1.Location = new Point(320, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 95);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbPassWord);
            panel2.Location = new Point(320, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 95);
            panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(492, 296);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(679, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.png");
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(43, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 201);
            panel3.TabIndex = 7;
            // 
            // flogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(889, 345);
            Controls.Add(panel3);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += flogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbUserName;
        private TextBox txbPassWord;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnLogin;
        private Button btnExit;
        private ImageList imageList1;
        private Panel panel3;
    }
}
