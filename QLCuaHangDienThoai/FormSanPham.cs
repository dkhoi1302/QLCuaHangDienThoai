using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormSanPham : Form
    {
        DataClasses1DataContext ql = new DataClasses1DataContext();
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void pictureBox_TimKiem(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem?.Text.Trim(); // giả sử có txtTimKiem
            if (string.IsNullOrEmpty(tuKhoa))
            {
                loadDuLieu();
                return;
            }
            var ketQua = ql.SanPhams.Where(p => p.MaSP.Contains(tuKhoa) || p.TenSP.Contains(tuKhoa) ||p.HangSP.Contains(tuKhoa)).OrderBy(p => p.MaSP);
            dataGridView_SanPham.DataSource = ketQua.ToList();
        }

        private void groupBox_TTSanPham_Enter(object sender, EventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            
        }

        private void loadDuLieu()
        {
            var ds = ql.SanPhams
                       .OrderBy(p => p.MaSP)
                       .Select(p => new
                       {
                           p.MaSP,
                           p.MaNCC,
                           p.HangSP,
                           p.TenSP,
                           p.TheLoai,
                           p.XuatXu,
                           p.Giaban
                       });

            dataGridView_SanPham.DataSource = ds.ToList();

            if (ds.Any())
            {
                hienthiDuLieuDong(0);
            }
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1) return;
            hienthiDuLieuDong(idrow);
        }

        private void hienthiDuLieuDong(int idrow)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            string MaSP = dataGridView_SanPham.Rows[idrow].Cells[0].Value.ToString();
            //Hiển thị dữ liệu 
            SanPham sp = db.SanPhams.Where(p => p.MaSP == MaSP).SingleOrDefault();

            if (sp != null)
            {
                txtMaSP.Text = sp.MaSP;
                txtTenSP.Text = sp.TenSP ?? "";
                cbbNCC.Text = sp.MaNCC ?? "";           
                cbbHangSP.Text = sp.HangSP ?? "";      
                cbbXuatxu.Text = sp.XuatXu ?? "";
                txtGiaBan.Text = sp.Giaban.ToString();
                cbbTheloai.Text = sp.TheLoai ?? "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Xóa trắng các ô
                txtMaSP.Text = txtTenSP.Text = cbbTheloai.Text =
                cbbTheloai.Text = txtGiaBan.Text = cbbTheloai.Text = "";
            }
        }
        private SanPham TaoSanPham()
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string giaBanText = txtGiaBan.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(maSP) ||
                string.IsNullOrEmpty(tenSP) ||
                string.IsNullOrEmpty(giaBanText) ||
                string.IsNullOrEmpty(cbbNCC.Text) ||
                string.IsNullOrEmpty(cbbHangSP.Text) ||
                string.IsNullOrEmpty(cbbTheloai.Text) ||
                string.IsNullOrEmpty(cbbXuatxu.Text))
            {
                return null;
            }

            // Kiểm tra giá bán là số
            if (!double.TryParse(giaBanText, out double giaBan))
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new SanPham
            {
                MaSP = maSP,
                MaNCC = cbbNCC.Text,
                TenSP = tenSP,
                HangSP = cbbHangSP.Text,
                XuatXu = cbbXuatxu.Text,
                Giaban = giaBan,
                TheLoai = cbbTheloai.Text
            };
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SanPham sp = TaoSanPham();
            if (sp == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            if (ql.SanPhams.Any(p => p.MaSP == sp.MaSP))
            {
                MessageBox.Show($"Mã sản phẩm '{sp.MaSP}' đã tồn tại!", "Trùng mã",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ql.SanPhams.InsertOnSubmit(sp);
            ql.SubmitChanges();
            loadDuLieu();
            XoaForm();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Chưa chọn",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham sp = TaoSanPham();
            if (sp == null) return;

            SanPham spUpdate = ql.SanPhams
                                  .Where(p => p.MaSP == txtMaSP.Text)
                                  .SingleOrDefault();

            if (spUpdate != null)
            {
                spUpdate.TenSP = sp.TenSP;
                spUpdate.MaNCC = sp.MaNCC;
                spUpdate.HangSP = sp.HangSP;
                spUpdate.XuatXu = sp.XuatXu;
                spUpdate.Giaban = sp.Giaban;
                spUpdate.TheLoai = sp.TheLoai;

                ql.SubmitChanges();
                loadDuLieu();
                XoaForm();
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = txtMaSP.Text;

            if (MessageBox.Show($"Xóa sản phẩm '{maSP}'?\n" +"Tất cả dữ liệu trong kho sẽ bị xóa!","Xác nhận xóa",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 1. Xóa trong KhoHang trước
                var khoHang = ql.KhoHangs.Where(k => k.MaSP == maSP).ToList();
                if (khoHang.Any())
                {
                    ql.KhoHangs.DeleteAllOnSubmit(khoHang);
                }

                // 2. Xóa trong SanPham
                var sp = ql.SanPhams.Where(p => p.MaSP == maSP).SingleOrDefault();
                if (sp != null)
                {
                    ql.SanPhams.DeleteOnSubmit(sp);
                    ql.SubmitChanges();
                    loadDuLieu();
                    XoaForm();
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void XoaForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            cbbNCC.Text = "";
            cbbHangSP.Text = "";
            cbbTheloai.Text = "";
            cbbXuatxu.Text = "";
            txtMaSP.Focus(); // Đưa con trỏ về ô Mã SP
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            XoaForm();
            MessageBox.Show("Đã làm trống form!", "Reset",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
