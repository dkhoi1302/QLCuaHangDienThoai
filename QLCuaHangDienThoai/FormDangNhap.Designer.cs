namespace QLCuaHangDienThoai
{
    partial class FormDangNhap
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
            this.panel_DangNhap = new System.Windows.Forms.Panel();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label_MKhau = new System.Windows.Forms.Label();
            this.label_TKhoan = new System.Windows.Forms.Label();
            this.checkBox_HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.panel_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DangNhap
            // 
            this.panel_DangNhap.BackColor = System.Drawing.Color.White;
            this.panel_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_DangNhap.Controls.Add(this.linkLabel_DangKy);
            this.panel_DangNhap.Controls.Add(this.linkLabel_QuenMatKhau);
            this.panel_DangNhap.Controls.Add(this.btn_Thoat);
            this.panel_DangNhap.Controls.Add(this.btn_DangNhap);
            this.panel_DangNhap.Controls.Add(this.label_MKhau);
            this.panel_DangNhap.Controls.Add(this.label_TKhoan);
            this.panel_DangNhap.Controls.Add(this.checkBox_HienThiMatKhau);
            this.panel_DangNhap.Controls.Add(this.textBox_MatKhau);
            this.panel_DangNhap.Controls.Add(this.textBox_TaiKhoan);
            this.panel_DangNhap.Controls.Add(this.label_Welcome);
            this.panel_DangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_DangNhap.Location = new System.Drawing.Point(638, 0);
            this.panel_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_DangNhap.Name = "panel_DangNhap";
            this.panel_DangNhap.Size = new System.Drawing.Size(419, 536);
            this.panel_DangNhap.TabIndex = 10;
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(305, 339);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(72, 20);
            this.linkLabel_DangKy.TabIndex = 12;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng Ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.AutoSize = true;
            this.linkLabel_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(3, 339);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(139, 20);
            this.linkLabel_QuenMatKhau.TabIndex = 11;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu ?";
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AutoSize = true;
            this.btn_Thoat.Location = new System.Drawing.Point(177, 469);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 34);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AutoSize = true;
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DangNhap.Location = new System.Drawing.Point(159, 428);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(121, 35);
            this.btn_DangNhap.TabIndex = 9;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click_1);
            // 
            // label_MKhau
            // 
            this.label_MKhau.AutoSize = true;
            this.label_MKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MKhau.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_MKhau.Location = new System.Drawing.Point(37, 244);
            this.label_MKhau.Name = "label_MKhau";
            this.label_MKhau.Size = new System.Drawing.Size(88, 20);
            this.label_MKhau.TabIndex = 8;
            this.label_MKhau.Text = "Mật Khẩu";
            // 
            // label_TKhoan
            // 
            this.label_TKhoan.AutoSize = true;
            this.label_TKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TKhoan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_TKhoan.Location = new System.Drawing.Point(31, 198);
            this.label_TKhoan.Name = "label_TKhoan";
            this.label_TKhoan.Size = new System.Drawing.Size(93, 20);
            this.label_TKhoan.TabIndex = 7;
            this.label_TKhoan.Text = "Tài Khoản";
            // 
            // checkBox_HienThiMatKhau
            // 
            this.checkBox_HienThiMatKhau.AutoSize = true;
            this.checkBox_HienThiMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_HienThiMatKhau.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_HienThiMatKhau.Location = new System.Drawing.Point(145, 283);
            this.checkBox_HienThiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HienThiMatKhau.Name = "checkBox_HienThiMatKhau";
            this.checkBox_HienThiMatKhau.Size = new System.Drawing.Size(188, 28);
            this.checkBox_HienThiMatKhau.TabIndex = 5;
            this.checkBox_HienThiMatKhau.Text = "Hiện Thị Mật Khẩu";
            this.checkBox_HienThiMatKhau.UseVisualStyleBackColor = false;
            this.checkBox_HienThiMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_HienThiMatKhau_CheckedChanged);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_MatKhau.Location = new System.Drawing.Point(145, 238);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MatKhau.Multiline = true;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(242, 32);
            this.textBox_MatKhau.TabIndex = 4;
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(145, 193);
            this.textBox_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TaiKhoan.Multiline = true;
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(242, 31);
            this.textBox_TaiKhoan.TabIndex = 3;
            // 
            // label_Welcome
            // 
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Welcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Welcome.Location = new System.Drawing.Point(139, 48);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(185, 53);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Welcome";
            this.label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangDienThoai.Properties.Resources._6c0c47c3282dfc661d3fbc0b9edf4c0b;
            this.ClientSize = new System.Drawing.Size(1057, 536);
            this.Controls.Add(this.panel_DangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel_DangNhap.ResumeLayout(false);
            this.panel_DangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label_MKhau;
        private System.Windows.Forms.Label label_TKhoan;
        private System.Windows.Forms.CheckBox checkBox_HienThiMatKhau;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TaiKhoan;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

