namespace QLCuaHangDienThoai
{
    partial class FormNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmailNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrvHienThiListNV = new System.Windows.Forms.DataGridView();
            this.quequanNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton1 = new CustomButton.VBButton();
            this.btnDeleteNV = new CustomButton.VBButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.label_MaNV = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_SDT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNV = new CustomButton.VBButton();
            this.btnReset = new CustomButton.VBButton();
            this.btnReplaceNV = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailNV
            // 
            this.EmailNV.DataPropertyName = "Email";
            this.EmailNV.FillWeight = 125.7254F;
            this.EmailNV.HeaderText = "Email";
            this.EmailNV.MinimumWidth = 8;
            this.EmailNV.Name = "EmailNV";
            this.EmailNV.ReadOnly = true;
            // 
            // sdtNV
            // 
            this.sdtNV.DataPropertyName = "SDT";
            this.sdtNV.FillWeight = 84.028F;
            this.sdtNV.HeaderText = "Số Điện Thoại";
            this.sdtNV.MinimumWidth = 8;
            this.sdtNV.Name = "sdtNV";
            this.sdtNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.FillWeight = 126.2221F;
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.FillWeight = 51.13635F;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // dtgrvHienThiListNV
            // 
            this.dtgrvHienThiListNV.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListNV.AllowUserToResizeRows = false;
            this.dtgrvHienThiListNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListNV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvHienThiListNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListNV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListNV.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.sdtNV,
            this.quequanNV,
            this.EmailNV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListNV.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListNV.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgrvHienThiListNV.Location = new System.Drawing.Point(2, 18);
            this.dtgrvHienThiListNV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrvHienThiListNV.Name = "dtgrvHienThiListNV";
            this.dtgrvHienThiListNV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListNV.RowHeadersVisible = false;
            this.dtgrvHienThiListNV.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.dtgrvHienThiListNV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListNV.RowTemplate.Height = 28;
            this.dtgrvHienThiListNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListNV.Size = new System.Drawing.Size(933, 209);
            this.dtgrvHienThiListNV.TabIndex = 0;
            // 
            // quequanNV
            // 
            this.quequanNV.DataPropertyName = "QueQuan";
            this.quequanNV.FillWeight = 112.8881F;
            this.quequanNV.HeaderText = "Quê Quán";
            this.quequanNV.MinimumWidth = 8;
            this.quequanNV.Name = "quequanNV";
            this.quequanNV.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListNV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(937, 229);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnReplaceNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(761, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 261);
            this.panel1.TabIndex = 18;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 14;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(29, 212);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(123, 38);
            this.vbButton1.TabIndex = 18;
            this.vbButton1.Text = "Xuất Excel";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteNV.BorderRadius = 14;
            this.btnDeleteNV.BorderSize = 0;
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.Image = global::QLCuaHangDienThoai.Properties.Resources.delete;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(29, 118);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(123, 37);
            this.btnDeleteNV.TabIndex = 15;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.TextColor = System.Drawing.Color.White;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(28, 231);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 12, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(472, 32);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "    Tìm kiếm";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(202, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 24);
            this.txtName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label_TaiKhoan);
            this.groupBox1.Controls.Add(this.label_MatKhau);
            this.groupBox1.Controls.Add(this.label_MaNV);
            this.groupBox1.Controls.Add(this.label_Email);
            this.groupBox1.Controls.Add(this.label_HoTen);
            this.groupBox1.Controls.Add(this.label_DiaChi);
            this.groupBox1.Controls.Add(this.label_SDT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(937, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.LightGray;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(384, 78);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(112, 24);
            this.txtSDT.TabIndex = 12;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.Color.LightGray;
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQueQuan.Location = new System.Drawing.Point(560, 78);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(112, 24);
            this.txtQueQuan.TabIndex = 11;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.LightGray;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(202, 178);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(140, 24);
            this.txtTaiKhoan.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.LightGray;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(384, 178);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(110, 24);
            this.txtMatKhau.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(28, 178);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.LightGray;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(28, 78);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(129, 24);
            this.txtMaNV.TabIndex = 7;
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TaiKhoan.Location = new System.Drawing.Point(199, 142);
            this.label_TaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(75, 18);
            this.label_TaiKhoan.TabIndex = 6;
            this.label_TaiKhoan.Text = "Tài Khoản";
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MatKhau.Location = new System.Drawing.Point(381, 142);
            this.label_MatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(71, 18);
            this.label_MatKhau.TabIndex = 5;
            this.label_MatKhau.Text = "Mật Khẩu";
            // 
            // label_MaNV
            // 
            this.label_MaNV.AutoSize = true;
            this.label_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaNV.Location = new System.Drawing.Point(25, 44);
            this.label_MaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_MaNV.Name = "label_MaNV";
            this.label_MaNV.Size = new System.Drawing.Size(53, 18);
            this.label_MaNV.TabIndex = 3;
            this.label_MaNV.Text = "Mã NV";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Email.Location = new System.Drawing.Point(25, 142);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(45, 18);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Email";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_HoTen.Location = new System.Drawing.Point(199, 44);
            this.label_HoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(57, 18);
            this.label_HoTen.TabIndex = 2;
            this.label_HoTen.Text = "Họ Tên";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DiaChi.Location = new System.Drawing.Point(557, 44);
            this.label_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(56, 18);
            this.label_DiaChi.TabIndex = 1;
            this.label_DiaChi.Text = "Địa Chỉ";
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SDT.Location = new System.Drawing.Point(381, 44);
            this.label_SDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(102, 18);
            this.label_SDT.TabIndex = 0;
            this.label_SDT.Text = "Số Điện Thoại";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCuaHangDienThoai.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(442, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_TimKiem);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNV.BorderRadius = 14;
            this.btnAddNV.BorderSize = 0;
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.Image = global::QLCuaHangDienThoai.Properties.Resources.add_user;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(29, 21);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAddNV.Size = new System.Drawing.Size(123, 37);
            this.btnAddNV.TabIndex = 14;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.TextColor = System.Drawing.Color.White;
            this.btnAddNV.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 14;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::QLCuaHangDienThoai.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(29, 169);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 38);
            this.btnReset.TabIndex = 17;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnReplaceNV
            // 
            this.btnReplaceNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReplaceNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnReplaceNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReplaceNV.BorderRadius = 14;
            this.btnReplaceNV.BorderSize = 0;
            this.btnReplaceNV.FlatAppearance.BorderSize = 0;
            this.btnReplaceNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceNV.ForeColor = System.Drawing.Color.White;
            this.btnReplaceNV.Image = global::QLCuaHangDienThoai.Properties.Resources.wrench;
            this.btnReplaceNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceNV.Location = new System.Drawing.Point(29, 67);
            this.btnReplaceNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplaceNV.Name = "btnReplaceNV";
            this.btnReplaceNV.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReplaceNV.Size = new System.Drawing.Size(123, 37);
            this.btnReplaceNV.TabIndex = 16;
            this.btnReplaceNV.Text = "Sửa";
            this.btnReplaceNV.TextColor = System.Drawing.Color.White;
            this.btnReplaceNV.UseVisualStyleBackColor = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn EmailNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridView dtgrvHienThiListNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton btnAddNV;
        private CustomButton.VBButton btnDeleteNV;
        private CustomButton.VBButton btnReset;
        private CustomButton.VBButton btnReplaceNV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.Label label_MaNV;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}