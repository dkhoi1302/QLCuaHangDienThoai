namespace QLCuaHangDienThoai
{
    partial class FormQuenMatKhau
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
            this.btn_OTP = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LayMatKhauMoi = new System.Windows.Forms.Button();
            this.txtBox_OTP = new System.Windows.Forms.TextBox();
            this.txtBox_Tkhoan = new System.Windows.Forms.TextBox();
            this.label_OTP = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OTP
            // 
            this.btn_OTP.AutoSize = true;
            this.btn_OTP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_OTP.Location = new System.Drawing.Point(619, 225);
            this.btn_OTP.Name = "btn_OTP";
            this.btn_OTP.Size = new System.Drawing.Size(99, 35);
            this.btn_OTP.TabIndex = 13;
            this.btn_OTP.Text = "Gửi OTP";
            this.btn_OTP.UseVisualStyleBackColor = false;
            this.btn_OTP.Click += new System.EventHandler(this.btn_OTP_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AutoSize = true;
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(339, 346);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_LayMatKhauMoi
            // 
            this.btn_LayMatKhauMoi.AutoSize = true;
            this.btn_LayMatKhauMoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_LayMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LayMatKhauMoi.Location = new System.Drawing.Point(292, 305);
            this.btn_LayMatKhauMoi.Name = "btn_LayMatKhauMoi";
            this.btn_LayMatKhauMoi.Size = new System.Drawing.Size(175, 35);
            this.btn_LayMatKhauMoi.TabIndex = 11;
            this.btn_LayMatKhauMoi.Text = "Lấy Lại Mật Khẩu";
            this.btn_LayMatKhauMoi.UseVisualStyleBackColor = false;
            this.btn_LayMatKhauMoi.Click += new System.EventHandler(this.btn_LayMatKhauMoi_Click);
            // 
            // txtBox_OTP
            // 
            this.txtBox_OTP.Location = new System.Drawing.Point(339, 169);
            this.txtBox_OTP.Name = "txtBox_OTP";
            this.txtBox_OTP.Size = new System.Drawing.Size(379, 22);
            this.txtBox_OTP.TabIndex = 10;
            // 
            // txtBox_Tkhoan
            // 
            this.txtBox_Tkhoan.Location = new System.Drawing.Point(339, 74);
            this.txtBox_Tkhoan.Name = "txtBox_Tkhoan";
            this.txtBox_Tkhoan.Size = new System.Drawing.Size(379, 22);
            this.txtBox_Tkhoan.TabIndex = 9;
            // 
            // label_OTP
            // 
            this.label_OTP.AutoSize = true;
            this.label_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_OTP.Location = new System.Drawing.Point(83, 165);
            this.label_OTP.Name = "label_OTP";
            this.label_OTP.Size = new System.Drawing.Size(87, 25);
            this.label_OTP.TabIndex = 8;
            this.label_OTP.Text = "Mã OTP";
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TaiKhoan.Location = new System.Drawing.Point(84, 70);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(143, 25);
            this.label_TaiKhoan.TabIndex = 7;
            this.label_TaiKhoan.Text = "Tên Tài Khoản";
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OTP);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LayMatKhauMoi);
            this.Controls.Add(this.txtBox_OTP);
            this.Controls.Add(this.txtBox_Tkhoan);
            this.Controls.Add(this.label_OTP);
            this.Controls.Add(this.label_TaiKhoan);
            this.Name = "FormQuenMatKhau";
            this.Text = "FormQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OTP;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LayMatKhauMoi;
        private System.Windows.Forms.TextBox txtBox_OTP;
        private System.Windows.Forms.TextBox txtBox_Tkhoan;
        private System.Windows.Forms.Label label_OTP;
        private System.Windows.Forms.Label label_TaiKhoan;
    }
}