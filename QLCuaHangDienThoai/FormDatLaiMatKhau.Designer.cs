namespace QLCuaHangDienThoai
{
    partial class FormDatLaiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_XacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtBox_NhapMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtBox_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btn_DatLaiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(90, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mật Khẩu Mới";
            // 
            // label_XacNhanMatKhau
            // 
            this.label_XacNhanMatKhau.AutoSize = true;
            this.label_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_XacNhanMatKhau.Location = new System.Drawing.Point(90, 187);
            this.label_XacNhanMatKhau.Name = "label_XacNhanMatKhau";
            this.label_XacNhanMatKhau.Size = new System.Drawing.Size(189, 25);
            this.label_XacNhanMatKhau.TabIndex = 1;
            this.label_XacNhanMatKhau.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtBox_NhapMatKhauMoi
            // 
            this.txtBox_NhapMatKhauMoi.Location = new System.Drawing.Point(354, 83);
            this.txtBox_NhapMatKhauMoi.Name = "txtBox_NhapMatKhauMoi";
            this.txtBox_NhapMatKhauMoi.Size = new System.Drawing.Size(379, 22);
            this.txtBox_NhapMatKhauMoi.TabIndex = 2;
            // 
            // txtBox_XacNhanMatKhau
            // 
            this.txtBox_XacNhanMatKhau.Location = new System.Drawing.Point(354, 201);
            this.txtBox_XacNhanMatKhau.Name = "txtBox_XacNhanMatKhau";
            this.txtBox_XacNhanMatKhau.Size = new System.Drawing.Size(379, 22);
            this.txtBox_XacNhanMatKhau.TabIndex = 3;
            // 
            // btn_DatLaiMatKhau
            // 
            this.btn_DatLaiMatKhau.AutoSize = true;
            this.btn_DatLaiMatKhau.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DatLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DatLaiMatKhau.Location = new System.Drawing.Point(305, 323);
            this.btn_DatLaiMatKhau.Name = "btn_DatLaiMatKhau";
            this.btn_DatLaiMatKhau.Size = new System.Drawing.Size(173, 35);
            this.btn_DatLaiMatKhau.TabIndex = 4;
            this.btn_DatLaiMatKhau.Text = "Đặt Lại Mật Khẩu";
            this.btn_DatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DatLaiMatKhau.Click += new System.EventHandler(this.btn_DatLaiMatKhau_Click);
            // 
            // FormDatLaiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DatLaiMatKhau);
            this.Controls.Add(this.txtBox_XacNhanMatKhau);
            this.Controls.Add(this.txtBox_NhapMatKhauMoi);
            this.Controls.Add(this.label_XacNhanMatKhau);
            this.Controls.Add(this.label1);
            this.Name = "FormDatLaiMatKhau";
            this.Text = "FormDatLaiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_XacNhanMatKhau;
        private System.Windows.Forms.TextBox txtBox_NhapMatKhauMoi;
        private System.Windows.Forms.TextBox txtBox_XacNhanMatKhau;
        private System.Windows.Forms.Button btn_DatLaiMatKhau;
    }
}