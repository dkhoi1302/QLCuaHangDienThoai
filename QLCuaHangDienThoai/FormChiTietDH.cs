using System;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormChiTietDH : Form
    {
        public DonHang donHang;
        public System.Collections.Generic.List<dynamic> listSanPham;
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormChiTietDH(DonHang dh, System.Collections.Generic.List<dynamic> listSP)
        {
            InitializeComponent();
            donHang = dh;
            listSanPham = listSP;
        }

        private void FormChiTietDH_Load(object sender, EventArgs e)
        {
            if (donHang == null)
            {
                MessageBox.Show("Không có dữ liệu đơn hàng!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // ======== Hiển thị thông tin đơn hàng ========
            lblMaHD.Text = donHang.MaDH.ToString();
            lblMaNV.Text = donHang.MaNV.ToString();
            lblTenKH.Text = donHang.TenKH ?? "";
            lblSDTKH.Text = donHang.SDTKH ?? "";
            lblDiachi.Text = donHang.DiaChi ?? "";
            lblNgaymua.Text = donHang.NgayMua?.ToString("dd/MM/yyyy") ?? "Chưa xác định";

            // ======== Lấy danh sách sản phẩm đã mua ========
            dtgrvHienThiListSPChon.Rows.Clear();

            var listSanPham = from ct in db.ChiTietDonHangs
                              join sp in db.SanPhams on ct.MaSP equals sp.MaSP
                              where ct.MaDH == donHang.MaDH
                              select new
                              {
                                  sp.MaSP,
                                  sp.TenSP,
                                  ct.SoLuong,
                                  ct.DonGia, // đổi thành GiaBan nếu bảng của bạn dùng tên khác
                                  ThanhTien = ct.SoLuong * ct.DonGia
                              };

            foreach (var item in listSanPham)
            {
                dtgrvHienThiListSPChon.Rows.Add(
                    item.MaSP,
                    item.TenSP,
                    item.SoLuong,
                    item.DonGia,
                    item.ThanhTien
                );
            }

            dtgrvHienThiListSPChon.CurrentCell = null; // bỏ chọn mặc định
        }
    }
}
