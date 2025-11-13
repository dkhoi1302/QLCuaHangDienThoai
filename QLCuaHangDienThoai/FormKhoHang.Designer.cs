namespace QLCuaHangDienThoai
{
    partial class FormKhoHang
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
            this.dtgrvHienThiListSPKho = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.btnNhapHang = new CustomButton.VBButton();
            this.btnXoaSP = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPKho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvHienThiListSPKho
            // 
            this.dtgrvHienThiListSPKho.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSPKho.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSPKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSPKho.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgrvHienThiListSPKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListSPKho.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSPKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListSPKho.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListSPKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSPKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.TenSP,
            this.clTenNV,
            this.clHangSP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSPKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSPKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListSPKho.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSPKho.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgrvHienThiListSPKho.Location = new System.Drawing.Point(3, 18);
            this.dtgrvHienThiListSPKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvHienThiListSPKho.Name = "dtgrvHienThiListSPKho";
            this.dtgrvHienThiListSPKho.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListSPKho.RowHeadersVisible = false;
            this.dtgrvHienThiListSPKho.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dtgrvHienThiListSPKho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSPKho.RowTemplate.Height = 28;
            this.dtgrvHienThiListSPKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSPKho.Size = new System.Drawing.Size(997, 471);
            this.dtgrvHienThiListSPKho.TabIndex = 0;
            // 
            // clMaSP
            // 
            this.clMaSP.DataPropertyName = "MaSP";
            this.clMaSP.FillWeight = 62.88284F;
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "Soluong";
            this.clTenNV.FillWeight = 74.69347F;
            this.clTenNV.HeaderText = "Số lượng tồn";
            this.clTenNV.MinimumWidth = 8;
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.ReadOnly = true;
            // 
            // clHangSP
            // 
            this.clHangSP.DataPropertyName = "NgayNhap";
            this.clHangSP.FillWeight = 73.68264F;
            this.clHangSP.HeaderText = "Ngày Nhập";
            this.clHangSP.MinimumWidth = 8;
            this.clHangSP.Name = "clHangSP";
            this.clHangSP.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSPKho);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1003, 491);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm có trong kho";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.btnNhapHang);
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 66);
            this.panel1.TabIndex = 14;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.vbButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 15;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.CausesValidation = false;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(463, 11);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(154, 41);
            this.vbButton2.TabIndex = 13;
            this.vbButton2.Text = "Xuất Excel";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 15;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.CausesValidation = false;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(95, 11);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(154, 41);
            this.vbButton1.TabIndex = 12;
            this.vbButton1.Text = "Refesh";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNhapHang.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnNhapHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhapHang.BorderRadius = 15;
            this.btnNhapHang.BorderSize = 0;
            this.btnNhapHang.CausesValidation = false;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(276, 11);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(154, 41);
            this.btnNhapHang.TabIndex = 10;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextColor = System.Drawing.Color.White;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoaSP.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnXoaSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaSP.BorderRadius = 15;
            this.btnXoaSP.BorderSize = 0;
            this.btnXoaSP.CausesValidation = false;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(644, 11);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(226, 41);
            this.btnXoaSP.TabIndex = 11;
            this.btnXoaSP.Text = "Xóa sản phẩm trong kho";
            this.btnXoaSP.TextColor = System.Drawing.Color.White;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 491);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormKhoHang";
            this.Text = "FormKhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPKho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvHienThiListSPKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton btnNhapHang;
        private CustomButton.VBButton btnXoaSP;
    }
}