namespace Quanlipizza
{
    partial class fTableManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngtinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new MaterialSkin.Controls.MaterialTextBox();
            btnCheckOut = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cbSwitchTable = new MaterialSkin.Controls.MaterialComboBox();
            btnSwitchTable = new MaterialSkin.Controls.MaterialButton();
            nmDiscount = new NumericUpDown();
            txbStaffName = new TextBox();
            panel4 = new Panel();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            cbFood = new MaterialSkin.Controls.MaterialComboBox();
            cbCatagory = new MaterialSkin.Controls.MaterialComboBox();
            nmFoodCount = new NumericUpDown();
            flpTable = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            label1 = new Label();
            imageList2 = new ImageList(components);
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txbCustomerName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txbCustomerAddress = new MaterialSkin.Controls.MaterialTextBox();
            txbCustomerPhone = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btnAddPoint = new MaterialSkin.Controls.MaterialButton();
            txbCurrentCustomer = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1344, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngtinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngtinCáNhânToolStripMenuItem
            // 
            thôngtinCáNhânToolStripMenuItem.Name = "thôngtinCáNhânToolStripMenuItem";
            thôngtinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngtinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngtinCáNhânToolStripMenuItem.Click += thôngtinCáNhânToolStripMenuItem_Click_1;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(424, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 402);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.AutoSizeTable = false;
            lsvBill.BackColor = Color.FromArgb(255, 255, 255);
            lsvBill.BorderStyle = BorderStyle.None;
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7, columnHeader8 });
            lsvBill.Depth = 0;
            lsvBill.FullRowSelect = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.MinimumSize = new Size(200, 100);
            lsvBill.MouseLocation = new Point(-1, -1);
            lsvBill.MouseState = MaterialSkin.MouseState.OUT;
            lsvBill.Name = "lsvBill";
            lsvBill.OwnerDraw = true;
            lsvBill.Size = new Size(534, 396);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số lượng";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Đơn giá";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Thành tiền";
            columnHeader8.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(materialLabel1);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Location = new Point(424, 611);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 105);
            panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.AnimateReadOnly = false;
            txbTotalPrice.BorderStyle = BorderStyle.None;
            txbTotalPrice.Depth = 0;
            txbTotalPrice.Font = new Font("Microsoft Sans Serif", 9.6F);
            txbTotalPrice.LeadingIcon = null;
            txbTotalPrice.Location = new Point(279, 23);
            txbTotalPrice.MaxLength = 50;
            txbTotalPrice.MouseState = MaterialSkin.MouseState.OUT;
            txbTotalPrice.Multiline = false;
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(125, 50);
            txbTotalPrice.TabIndex = 12;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TrailingIcon = null;
            // 
            // btnCheckOut
            // 
            btnCheckOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCheckOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCheckOut.Depth = 0;
            btnCheckOut.HighEmphasis = true;
            btnCheckOut.Icon = null;
            btnCheckOut.Location = new Point(411, 30);
            btnCheckOut.Margin = new Padding(4, 6, 4, 6);
            btnCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.NoAccentTextColor = Color.Empty;
            btnCheckOut.Size = new Size(114, 36);
            btnCheckOut.TabIndex = 11;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCheckOut.UseAccentColor = false;
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click_1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(171, 23);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(65, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Giảm giá";
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.AutoResize = false;
            cbSwitchTable.BackColor = Color.FromArgb(255, 255, 255);
            cbSwitchTable.Depth = 0;
            cbSwitchTable.DrawMode = DrawMode.OwnerDrawVariable;
            cbSwitchTable.DropDownHeight = 174;
            cbSwitchTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSwitchTable.DropDownWidth = 121;
            cbSwitchTable.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbSwitchTable.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.IntegralHeight = false;
            cbSwitchTable.ItemHeight = 43;
            cbSwitchTable.Location = new Point(11, 49);
            cbSwitchTable.MaxDropDownItems = 4;
            cbSwitchTable.MouseState = MaterialSkin.MouseState.OUT;
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(132, 49);
            cbSwitchTable.StartIndex = 0;
            cbSwitchTable.TabIndex = 9;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSwitchTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSwitchTable.Depth = 0;
            btnSwitchTable.HighEmphasis = true;
            btnSwitchTable.Icon = null;
            btnSwitchTable.Location = new Point(20, 6);
            btnSwitchTable.Margin = new Padding(4, 6, 4, 6);
            btnSwitchTable.MouseState = MaterialSkin.MouseState.HOVER;
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.NoAccentTextColor = Color.Empty;
            btnSwitchTable.Size = new Size(112, 36);
            btnSwitchTable.TabIndex = 1;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSwitchTable.UseAccentColor = false;
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(171, 49);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(69, 27);
            nmDiscount.TabIndex = 4;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // txbStaffName
            // 
            txbStaffName.Location = new Point(1080, 30);
            txbStaffName.Name = "txbStaffName";
            txbStaffName.Size = new Size(222, 27);
            txbStaffName.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCatagory);
            panel4.Controls.Add(nmFoodCount);
            panel4.Location = new Point(424, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(540, 121);
            panel4.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(325, 42);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(99, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm món";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbFood
            // 
            cbFood.AutoResize = false;
            cbFood.BackColor = Color.FromArgb(255, 255, 255);
            cbFood.Depth = 0;
            cbFood.DrawMode = DrawMode.OwnerDrawVariable;
            cbFood.DropDownHeight = 174;
            cbFood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFood.DropDownWidth = 121;
            cbFood.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFood.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbFood.FormattingEnabled = true;
            cbFood.IntegralHeight = false;
            cbFood.ItemHeight = 43;
            cbFood.Location = new Point(38, 65);
            cbFood.MaxDropDownItems = 4;
            cbFood.MouseState = MaterialSkin.MouseState.OUT;
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(226, 49);
            cbFood.StartIndex = 0;
            cbFood.TabIndex = 5;
            // 
            // cbCatagory
            // 
            cbCatagory.AutoResize = false;
            cbCatagory.BackColor = Color.FromArgb(255, 255, 255);
            cbCatagory.Depth = 0;
            cbCatagory.DrawMode = DrawMode.OwnerDrawVariable;
            cbCatagory.DropDownHeight = 174;
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.DropDownWidth = 121;
            cbCatagory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCatagory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCatagory.FormattingEnabled = true;
            cbCatagory.IntegralHeight = false;
            cbCatagory.ItemHeight = 43;
            cbCatagory.Location = new Point(38, 10);
            cbCatagory.MaxDropDownItems = 4;
            cbCatagory.MouseState = MaterialSkin.MouseState.OUT;
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(226, 49);
            cbCatagory.StartIndex = 0;
            cbCatagory.TabIndex = 4;
            cbCatagory.SelectedIndexChanged += cbCatagory_SelectedIndexChanged;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(446, 48);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(64, 27);
            nmFoodCount.TabIndex = 3;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 95);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(406, 621);
            flpTable.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(979, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 12;
            label1.Text = "Nhân viên: ";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.SeaShell;
            imageList2.Images.SetKeyName(0, "download.png");
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(1038, 90);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(201, 19);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Nhập thông tin khách hàng :";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(970, 129);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(119, 19);
            materialLabel3.TabIndex = 14;
            materialLabel3.Text = "Tên khách hàng:";
            // 
            // txbCustomerName
            // 
            txbCustomerName.AnimateReadOnly = false;
            txbCustomerName.BorderStyle = BorderStyle.None;
            txbCustomerName.Depth = 0;
            txbCustomerName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txbCustomerName.LeadingIcon = null;
            txbCustomerName.Location = new Point(970, 151);
            txbCustomerName.MaxLength = 50;
            txbCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            txbCustomerName.Multiline = false;
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(352, 50);
            txbCustomerName.TabIndex = 15;
            txbCustomerName.Text = "";
            txbCustomerName.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(970, 217);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(54, 19);
            materialLabel4.TabIndex = 16;
            materialLabel4.Text = "Địa chỉ:";
            // 
            // txbCustomerAddress
            // 
            txbCustomerAddress.AnimateReadOnly = false;
            txbCustomerAddress.BorderStyle = BorderStyle.None;
            txbCustomerAddress.Depth = 0;
            txbCustomerAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txbCustomerAddress.LeadingIcon = null;
            txbCustomerAddress.Location = new Point(970, 239);
            txbCustomerAddress.MaxLength = 50;
            txbCustomerAddress.MouseState = MaterialSkin.MouseState.OUT;
            txbCustomerAddress.Multiline = false;
            txbCustomerAddress.Name = "txbCustomerAddress";
            txbCustomerAddress.Size = new Size(352, 50);
            txbCustomerAddress.TabIndex = 17;
            txbCustomerAddress.Text = "";
            txbCustomerAddress.TrailingIcon = null;
            // 
            // txbCustomerPhone
            // 
            txbCustomerPhone.AnimateReadOnly = false;
            txbCustomerPhone.BorderStyle = BorderStyle.None;
            txbCustomerPhone.Depth = 0;
            txbCustomerPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txbCustomerPhone.LeadingIcon = null;
            txbCustomerPhone.Location = new Point(970, 335);
            txbCustomerPhone.MaxLength = 50;
            txbCustomerPhone.MouseState = MaterialSkin.MouseState.OUT;
            txbCustomerPhone.Multiline = false;
            txbCustomerPhone.Name = "txbCustomerPhone";
            txbCustomerPhone.Size = new Size(352, 50);
            txbCustomerPhone.TabIndex = 18;
            txbCustomerPhone.Text = "";
            txbCustomerPhone.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(970, 313);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(99, 19);
            materialLabel5.TabIndex = 19;
            materialLabel5.Text = "Số điện thoại:";
            // 
            // btnAddPoint
            // 
            btnAddPoint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddPoint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddPoint.Depth = 0;
            btnAddPoint.HighEmphasis = true;
            btnAddPoint.Icon = null;
            btnAddPoint.Location = new Point(1239, 407);
            btnAddPoint.Margin = new Padding(4, 6, 4, 6);
            btnAddPoint.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddPoint.Name = "btnAddPoint";
            btnAddPoint.NoAccentTextColor = Color.Empty;
            btnAddPoint.Size = new Size(64, 36);
            btnAddPoint.TabIndex = 20;
            btnAddPoint.Text = "Thêm";
            btnAddPoint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddPoint.UseAccentColor = false;
            btnAddPoint.UseVisualStyleBackColor = true;
            btnAddPoint.Click += btnAddPoint_Click;
            // 
            // txbCurrentCustomer
            // 
            txbCurrentCustomer.AnimateReadOnly = false;
            txbCurrentCustomer.BorderStyle = BorderStyle.None;
            txbCurrentCustomer.Depth = 0;
            txbCurrentCustomer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txbCurrentCustomer.LeadingIcon = null;
            txbCurrentCustomer.Location = new Point(970, 530);
            txbCurrentCustomer.MaxLength = 50;
            txbCurrentCustomer.MouseState = MaterialSkin.MouseState.OUT;
            txbCurrentCustomer.Multiline = false;
            txbCurrentCustomer.Name = "txbCurrentCustomer";
            txbCurrentCustomer.Size = new Size(352, 50);
            txbCurrentCustomer.TabIndex = 21;
            txbCurrentCustomer.Text = "";
            txbCurrentCustomer.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(970, 498);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(188, 19);
            materialLabel6.TabIndex = 22;
            materialLabel6.Text = "Đang đặt hàng cho khách:";
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1350, 722);
            Controls.Add(materialLabel6);
            Controls.Add(txbCurrentCustomer);
            Controls.Add(btnAddPoint);
            Controls.Add(materialLabel5);
            Controls.Add(txbCustomerPhone);
            Controls.Add(txbCustomerAddress);
            Controls.Add(materialLabel4);
            Controls.Add(txbCustomerName);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(label1);
            Controls.Add(txbStaffName);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lí quán pizza";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngtinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nmDiscount;
        private TextBox c;
        private ImageList imageList1;
        private TextBox txbStaffName;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbCatagory;
        private MaterialSkin.Controls.MaterialComboBox cbFood;
        private ImageList imageList2;
        private MaterialSkin.Controls.MaterialListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialComboBox cbSwitchTable;
        private MaterialSkin.Controls.MaterialButton btnSwitchTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCheckOut;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox txbTotalPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txbCustomerName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txbCustomerAddress;
        private MaterialSkin.Controls.MaterialTextBox txbCustomerPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnAddPoint;
        private MaterialSkin.Controls.MaterialTextBox txbCurrentCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}