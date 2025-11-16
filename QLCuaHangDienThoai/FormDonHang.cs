using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormDonHang : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Danh sách tạm lưu chi tiết đơn hàng khi tạo mới
        private System.Collections.Generic.List<ChiTietDonHang> listChiTiet = new System.Collections.Generic.List<ChiTietDonHang>();

        public FormDonHang()
        {
            InitializeComponent();
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadComboBoxSanPham();
            dtpNgayMua.Value = DateTime.Today;
        }

        // === LOAD DỮ LIỆU ===
        private void LoadComboBoxNhanVien()
        {
            cboMaNV.Items.Clear();
            var dsNV = db.NhanViens.Select(nv => nv.MaNV).OrderBy(m => m);
            foreach (var ma in dsNV) cboMaNV.Items.Add(ma);
        }

        private void LoadComboBoxSanPham()
        {
            cboSanPham.Items.Clear();
            var dsSP = from sp in db.SanPhams
                       join kho in db.KhoHangs on sp.MaSP equals kho.MaSP
                       where kho.Soluong > 0
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           kho.Soluong
                       };

            foreach (var sp in dsSP)
            {
                cboSanPham.Items.Add($"{sp.MaSP} | {sp.TenSP} | SL còn: {sp.Soluong}");
            }
        }

        // === LẤY MÃ SP TỪ COMBOBOX ===
        private string LayMaSP()
        {
            if (string.IsNullOrEmpty(cboSanPham.Text)) return null;
            return cboSanPham.Text.Split('|')[0].Trim();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtMaDH.Clear();
            txtTenKH.Clear();
            txtSDTKH.Clear();
            txtDiaChi.Clear();
            txtSoluong.Clear();
            cboMaNV.Text = "";
            cboSanPham.Text = "";
            dtgrvHienThiListSPChon.Rows.Clear();
            listChiTiet.Clear();
            btn_XemChiTietDH.Visible = false;
            btn_XuatHoaDon.Visible = false;

            LoadComboBoxNhanVien();
            LoadComboBoxSanPham();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Mã đơn hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cboSanPham_Enter(object sender, EventArgs e)
        {
            if (cboSanPham.Text.Contains("Tồn:")) cboSanPham.Text = "";
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã đơn hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = LayMaSP();
            if (maSP == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoluong.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải là số dương!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kho = db.KhoHangs.FirstOrDefault(k => k.MaSP == maSP);
            if (kho == null || kho.Soluong < sl)  // ← SỬA: Soluong
            {
                MessageBox.Show($"Kho chỉ còn {kho?.Soluong ?? 0} sản phẩm!", "Hết hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sp = db.SanPhams.FirstOrDefault(s => s.MaSP == maSP);
            if (sp == null) return;

            double donGia = (double)sp.Giaban;
            double thanhTien = sl * donGia;

            dtgrvHienThiListSPChon.Rows.Add(maSP, sp.TenSP, sl, donGia.ToString("N0"), thanhTien.ToString("N0"));

            listChiTiet.Add(new ChiTietDonHang
            {
                MaDH = txtMaDH.Text,
                MaSP = maSP,
                SoLuong = sl,
                DonGia = thanhTien
            });

            txtSoluong.Clear();
            MessageBox.Show("Đã thêm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            if (dtgrvHienThiListSPChon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dtgrvHienThiListSPChon.SelectedRows[0];
            string maSP = row.Cells[0].Value.ToString();

            dtgrvHienThiListSPChon.Rows.Remove(row);
            listChiTiet.RemoveAll(ct => ct.MaSP == maSP);

            MessageBox.Show("Đã xóa sản phẩm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void btn_HuyDonHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Nhập Mã đơn hàng cần hủy!", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Hủy đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var donHang = db.DonHangs.FirstOrDefault(d => d.MaDH == txtMaDH.Text);
            if (donHang == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chiTiets = db.ChiTietDonHangs.Where(ct => ct.MaDH == txtMaDH.Text).ToList();
            foreach (var ct in chiTiets)
            {
                var kho = db.KhoHangs.FirstOrDefault(k => k.MaSP == ct.MaSP);
                if (kho != null) kho.Soluong += ct.SoLuong; 
            }

            db.ChiTietDonHangs.DeleteAllOnSubmit(chiTiets);
            db.DonHangs.DeleteOnSubmit(donHang);
            db.SubmitChanges();

            MessageBox.Show("Hủy đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiForm();
        }

        private void btn_TaoDonHang_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            if (db.DonHangs.Any(d => d.MaDH == txtMaDH.Text))
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var donHang = new DonHang
            {
                MaDH = txtMaDH.Text,
                TenKH = txtTenKH.Text,
                SDTKH = txtSDTKH.Text,
                DiaChi = txtDiaChi.Text,
                NgayMua = dtpNgayMua.Value,
                MaNV = cboMaNV.Text
            };

            db.DonHangs.InsertOnSubmit(donHang);

            foreach (var ct in listChiTiet)
            {
                db.ChiTietDonHangs.InsertOnSubmit(ct);

                var kho = db.KhoHangs.FirstOrDefault(k => k.MaSP == ct.MaSP);
                if (kho != null) kho.Soluong -= ct.SoLuong;  // ← SỬA: Soluong
            }

            db.SubmitChanges();

            MessageBox.Show("Tạo đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_XemChiTietDH.Visible = true;
            btn_XuatHoaDon.Visible = true;

            LamMoiForm();
        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
            var dh = new DonHang
            {
                MaDH = txtMaDH.Text,
                MaNV = cboMaNV.Text,
                TenKH = txtTenKH.Text,
                SDTKH = txtSDTKH.Text,
                DiaChi = txtDiaChi.Text,
                NgayMua = dtpNgayMua.Value
            };

            // DÙNG dynamic – KHÔNG CẦN CLASS
            var listSP = dtgrvHienThiListSPChon.Rows
                .Cast<DataGridViewRow>()
                .Select(r => new
                {
                    MaSP = r.Cells[0].Value?.ToString(),
                    TenSP = r.Cells[1].Value?.ToString(),
                    SoLuong = Convert.ToInt32(r.Cells[2].Value),
                    GiaBan = Convert.ToDouble(r.Cells[3].Value),
                    ThanhTien = Convert.ToDouble(r.Cells[4].Value)
                } as dynamic)
                .ToList();

            FormXuatHoaDon.donHang = dh;
            FormXuatHoaDon.listSanPham = listSP;
            new FormXuatHoaDon().ShowDialog();
        }

        private void btn_XemChiTietDH_Click(object sender, EventArgs e)
        {
            var dh = new DonHang
            {
                MaDH = txtMaDH.Text,
                MaNV = cboMaNV.Text,
                TenKH = txtTenKH.Text,
                SDTKH = txtSDTKH.Text,
                DiaChi = txtDiaChi.Text,
                NgayMua = dtpNgayMua.Value
            };

            // DÙNG dynamic – KHÔNG CẦN CLASS
            var listSP = dtgrvHienThiListSPChon.Rows
                .Cast<DataGridViewRow>()
                .Select(r => new
                {
                    MaSP = r.Cells[0].Value?.ToString(),
                    TenSP = r.Cells[1].Value?.ToString(),
                    SoLuong = Convert.ToInt32(r.Cells[2].Value),
                    GiaBan = Convert.ToDouble(r.Cells[3].Value),
                    ThanhTien = Convert.ToDouble(r.Cells[4].Value)
                } as dynamic)
                .ToList();

            var form = new FormChiTietDH(dh, listSP);
            form.ShowDialog();
        }
    }
}
