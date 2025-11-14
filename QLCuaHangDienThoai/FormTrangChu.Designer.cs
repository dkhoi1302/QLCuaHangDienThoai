namespace QLCuaHangDienThoai
{
    partial class FormTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNhacc = new CustomButton.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongke = new CustomButton.VBButton();
            this.btnKhohang = new CustomButton.VBButton();
            this.btnNhanvien = new CustomButton.VBButton();
            this.btnAddDH = new CustomButton.VBButton();
            this.btnLogout = new CustomButton.VBButton();
            this.btnSanPham = new CustomButton.VBButton();
            this.btnTrangchu = new CustomButton.VBButton();
            this.label_Xinchao = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnNhacc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnKhohang);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Controls.Add(this.btnAddDH);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Controls.Add(this.label_Xinchao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.panel1.Size = new System.Drawing.Size(235, 704);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 3);
            this.label5.TabIndex = 13;
            // 
            // btnNhacc
            // 
            this.btnNhacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnNhacc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnNhacc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhacc.BorderRadius = 20;
            this.btnNhacc.BorderSize = 0;
            this.btnNhacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhacc.FlatAppearance.BorderSize = 0;
            this.btnNhacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhacc.ForeColor = System.Drawing.Color.White;
            this.btnNhacc.Image = global::QLCuaHangDienThoai.Properties.Resources.group;
            this.btnNhacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacc.Location = new System.Drawing.Point(10, 247);
            this.btnNhacc.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhacc.Name = "btnNhacc";
            this.btnNhacc.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnNhacc.Size = new System.Drawing.Size(214, 62);
            this.btnNhacc.TabIndex = 12;
            this.btnNhacc.Text = "    Nhà cung cấp";
            this.btnNhacc.TextColor = System.Drawing.Color.White;
            this.btnNhacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhacc.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(30, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 2);
            this.label4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 631);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 2);
            this.label2.TabIndex = 1;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnThongke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnThongke.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongke.BorderRadius = 20;
            this.btnThongke.BorderSize = 0;
            this.btnThongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = global::QLCuaHangDienThoai.Properties.Resources.trend;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(10, 521);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(183, 58);
            this.btnThongke.TabIndex = 10;
            this.btnThongke.Text = "    Thống kê";
            this.btnThongke.TextColor = System.Drawing.Color.White;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = false;
            // 
            // btnKhohang
            // 
            this.btnKhohang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnKhohang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnKhohang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhohang.BorderRadius = 20;
            this.btnKhohang.BorderSize = 0;
            this.btnKhohang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhohang.FlatAppearance.BorderSize = 0;
            this.btnKhohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhohang.ForeColor = System.Drawing.Color.White;
            this.btnKhohang.Image = global::QLCuaHangDienThoai.Properties.Resources.product;
            this.btnKhohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhohang.Location = new System.Drawing.Point(12, 383);
            this.btnKhohang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhohang.Name = "btnKhohang";
            this.btnKhohang.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnKhohang.Size = new System.Drawing.Size(183, 59);
            this.btnKhohang.TabIndex = 9;
            this.btnKhohang.Text = "    Kho hàng";
            this.btnKhohang.TextColor = System.Drawing.Color.White;
            this.btnKhohang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhohang.UseVisualStyleBackColor = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnNhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnNhanvien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhanvien.BorderRadius = 20;
            this.btnNhanvien.BorderSize = 0;
            this.btnNhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = global::QLCuaHangDienThoai.Properties.Resources.group;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(12, 445);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnNhanvien.Size = new System.Drawing.Size(183, 64);
            this.btnNhanvien.TabIndex = 8;
            this.btnNhanvien.Text = "    Nhân viên";
            this.btnNhanvien.TextColor = System.Drawing.Color.White;
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            // 
            // btnAddDH
            // 
            this.btnAddDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnAddDH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnAddDH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddDH.BorderRadius = 20;
            this.btnAddDH.BorderSize = 0;
            this.btnAddDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDH.FlatAppearance.BorderSize = 0;
            this.btnAddDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDH.ForeColor = System.Drawing.Color.White;
            this.btnAddDH.Image = global::QLCuaHangDienThoai.Properties.Resources.shopping_cart;
            this.btnAddDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDH.Location = new System.Drawing.Point(10, 311);
            this.btnAddDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDH.Name = "btnAddDH";
            this.btnAddDH.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAddDH.Size = new System.Drawing.Size(214, 61);
            this.btnAddDH.TabIndex = 3;
            this.btnAddDH.Text = "    Tạo đơn hàng";
            this.btnAddDH.TextColor = System.Drawing.Color.White;
            this.btnAddDH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDH.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::QLCuaHangDienThoai.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(0, 647);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(235, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSanPham.BorderRadius = 20;
            this.btnSanPham.BorderSize = 0;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::QLCuaHangDienThoai.Properties.Resources.shopping_cart;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(10, 181);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(183, 54);
            this.btnSanPham.TabIndex = 6;
            this.btnSanPham.Text = "    Sản phẩm";
            this.btnSanPham.TextColor = System.Drawing.Color.White;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnTrangchu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnTrangchu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangchu.BorderRadius = 20;
            this.btnTrangchu.BorderSize = 0;
            this.btnTrangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangchu.FlatAppearance.BorderSize = 0;
            this.btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangchu.ForeColor = System.Drawing.Color.White;
            this.btnTrangchu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangchu.Image")));
            this.btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangchu.Location = new System.Drawing.Point(10, 115);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTrangchu.Size = new System.Drawing.Size(183, 52);
            this.btnTrangchu.TabIndex = 1;
            this.btnTrangchu.Text = "    Trang Chủ";
            this.btnTrangchu.TextColor = System.Drawing.Color.White;
            this.btnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangchu.UseVisualStyleBackColor = false;
            // 
            // label_Xinchao
            // 
            this.label_Xinchao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.label_Xinchao.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Xinchao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Xinchao.Location = new System.Drawing.Point(32, 10);
            this.label_Xinchao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Xinchao.Name = "label_Xinchao";
            this.label_Xinchao.Size = new System.Drawing.Size(179, 42);
            this.label_Xinchao.TabIndex = 0;
            this.label_Xinchao.Text = "Xin Chào";
            this.label_Xinchao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.lblDateTime);
            this.panel4.Controls.Add(this.lblPhanQuyen);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(235, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 21, 25, 0);
            this.panel4.Size = new System.Drawing.Size(1097, 62);
            this.panel4.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateTime.Location = new System.Drawing.Point(955, 21);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 42, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(117, 17);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Thời gian hiện tại";
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.lblPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhanQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhanQuyen.Location = new System.Drawing.Point(339, 25);
            this.lblPhanQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(38, 20);
            this.lblPhanQuyen.TabIndex = 4;
            this.lblPhanQuyen.Text = "Null";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QLCuaHangDienThoai.Properties.Resources.user;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(72, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 29);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(251, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức Vụ :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(103, 25);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Null";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(235, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1097, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1332, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(-300, -300);
            this.MaximumSize = new System.Drawing.Size(1354, 759);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private CustomButton.VBButton btnNhacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton btnThongke;
        private CustomButton.VBButton btnKhohang;
        private CustomButton.VBButton btnNhanvien;
        private CustomButton.VBButton btnAddDH;
        private CustomButton.VBButton btnLogout;
        private CustomButton.VBButton btnSanPham;
        private CustomButton.VBButton btnTrangchu;
        private System.Windows.Forms.Label label_Xinchao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Timer ThoiGian;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}