namespace QLCuaHangDienThoai
{
    partial class FormChiTietDH
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
            this.clGiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ChiTietDonHang = new System.Windows.Forms.Label();
            this.dtgrvHienThiListSPChon = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.lblNgaymua = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label_MaNV = new System.Windows.Forms.Label();
            this.label_MaHoaDon = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_TTinKhachHang = new System.Windows.Forms.Label();
            this.label_SanPham = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_NgayMua = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).BeginInit();
            this.SuspendLayout();
            // 
            // clGiaban
            // 
            this.clGiaban.DataPropertyName = "Giaban";
            this.clGiaban.HeaderText = "Giá Bán";
            this.clGiaban.MinimumWidth = 8;
            this.clGiaban.Name = "clGiaban";
            this.clGiaban.ReadOnly = true;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // label_ChiTietDonHang
            // 
            this.label_ChiTietDonHang.AutoSize = true;
            this.label_ChiTietDonHang.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ChiTietDonHang.Location = new System.Drawing.Point(244, 28);
            this.label_ChiTietDonHang.Name = "label_ChiTietDonHang";
            this.label_ChiTietDonHang.Size = new System.Drawing.Size(295, 38);
            this.label_ChiTietDonHang.TabIndex = 58;
            this.label_ChiTietDonHang.Text = "Chi Tiết Đơn Hàng";
            // 
            // dtgrvHienThiListSPChon
            // 
            this.dtgrvHienThiListSPChon.AllowUserToAddRows = false;
            this.dtgrvHienThiListSPChon.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSPChon.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSPChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSPChon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrvHienThiListSPChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvHienThiListSPChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListSPChon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSPChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListSPChon.ColumnHeadersHeight = 30;
            this.dtgrvHienThiListSPChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSPChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.soluong,
            this.clGiaban,
            this.Thanhtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSPChon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSPChon.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSPChon.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtgrvHienThiListSPChon.Location = new System.Drawing.Point(76, 276);
            this.dtgrvHienThiListSPChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvHienThiListSPChon.Name = "dtgrvHienThiListSPChon";
            this.dtgrvHienThiListSPChon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPChon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListSPChon.RowHeadersVisible = false;
            this.dtgrvHienThiListSPChon.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dtgrvHienThiListSPChon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSPChon.RowTemplate.Height = 28;
            this.dtgrvHienThiListSPChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSPChon.Size = new System.Drawing.Size(649, 146);
            this.dtgrvHienThiListSPChon.TabIndex = 57;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 62.88284F;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.FillWeight = 74.69347F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(544, 107);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(40, 16);
            this.lblMaNV.TabIndex = 56;
            this.lblMaNV.Text = "value";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(226, 171);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(40, 16);
            this.lblTenKH.TabIndex = 55;
            this.lblTenKH.Text = "value";
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.AutoSize = true;
            this.lblSDTKH.Location = new System.Drawing.Point(226, 195);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.Size = new System.Drawing.Size(40, 16);
            this.lblSDTKH.TabIndex = 54;
            this.lblSDTKH.Text = "value";
            // 
            // lblNgaymua
            // 
            this.lblNgaymua.AutoSize = true;
            this.lblNgaymua.Location = new System.Drawing.Point(226, 243);
            this.lblNgaymua.Name = "lblNgaymua";
            this.lblNgaymua.Size = new System.Drawing.Size(40, 16);
            this.lblNgaymua.TabIndex = 52;
            this.lblNgaymua.Text = "value";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(221, 107);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(40, 16);
            this.lblMaHD.TabIndex = 51;
            this.lblMaHD.Text = "value";
            // 
            // label_MaNV
            // 
            this.label_MaNV.AutoSize = true;
            this.label_MaNV.Location = new System.Drawing.Point(413, 107);
            this.label_MaNV.Name = "label_MaNV";
            this.label_MaNV.Size = new System.Drawing.Size(120, 16);
            this.label_MaNV.TabIndex = 50;
            this.label_MaNV.Text = "Mã NV Tiếp Nhận :";
            // 
            // label_MaHoaDon
            // 
            this.label_MaHoaDon.AutoSize = true;
            this.label_MaHoaDon.Location = new System.Drawing.Point(126, 107);
            this.label_MaHoaDon.Name = "label_MaHoaDon";
            this.label_MaHoaDon.Size = new System.Drawing.Size(88, 16);
            this.label_MaHoaDon.TabIndex = 49;
            this.label_MaHoaDon.Text = "Mã Hóa Đơn :";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Location = new System.Drawing.Point(126, 171);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(78, 16);
            this.label_HoTen.TabIndex = 48;
            this.label_HoTen.Text = "Họ Và Tên :";
            // 
            // label_TTinKhachHang
            // 
            this.label_TTinKhachHang.AutoSize = true;
            this.label_TTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TTinKhachHang.Location = new System.Drawing.Point(122, 141);
            this.label_TTinKhachHang.Name = "label_TTinKhachHang";
            this.label_TTinKhachHang.Size = new System.Drawing.Size(166, 17);
            this.label_TTinKhachHang.TabIndex = 47;
            this.label_TTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // label_SanPham
            // 
            this.label_SanPham.AutoSize = true;
            this.label_SanPham.Location = new System.Drawing.Point(126, 195);
            this.label_SanPham.Name = "label_SanPham";
            this.label_SanPham.Size = new System.Drawing.Size(52, 16);
            this.label_SanPham.TabIndex = 46;
            this.label_SanPham.Text = "Phone :";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(126, 219);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(55, 16);
            this.label_DiaChi.TabIndex = 45;
            this.label_DiaChi.Text = "Địa Chỉ :";
            // 
            // label_NgayMua
            // 
            this.label_NgayMua.AutoSize = true;
            this.label_NgayMua.Location = new System.Drawing.Point(126, 243);
            this.label_NgayMua.Name = "label_NgayMua";
            this.label_NgayMua.Size = new System.Drawing.Size(75, 16);
            this.label_NgayMua.TabIndex = 44;
            this.label_NgayMua.Text = "Ngày Mua :";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(226, 219);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 16);
            this.lblDiachi.TabIndex = 53;
            this.lblDiachi.Text = "value";
            // 
            // FormChiTietDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ChiTietDonHang);
            this.Controls.Add(this.dtgrvHienThiListSPChon);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblSDTKH);
            this.Controls.Add(this.lblNgaymua);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.label_MaNV);
            this.Controls.Add(this.label_MaHoaDon);
            this.Controls.Add(this.label_HoTen);
            this.Controls.Add(this.label_TTinKhachHang);
            this.Controls.Add(this.label_SanPham);
            this.Controls.Add(this.label_DiaChi);
            this.Controls.Add(this.label_NgayMua);
            this.Controls.Add(this.lblDiachi);
            this.Name = "FormChiTietDH";
            this.Text = "FormChiTietDH";
            this.Load += new System.EventHandler(this.FormChiTietDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Label label_ChiTietDonHang;
        private System.Windows.Forms.DataGridView dtgrvHienThiListSPChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.Label lblNgaymua;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label_MaNV;
        private System.Windows.Forms.Label label_MaHoaDon;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_TTinKhachHang;
        private System.Windows.Forms.Label label_SanPham;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_NgayMua;
        private System.Windows.Forms.Label lblDiachi;
    }
}