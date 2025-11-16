using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormNhaCC : Form
    {
        DataClasses1DataContext ql = new DataClasses1DataContext();
        public FormNhaCC()
        {
            InitializeComponent();
        }

        private void pictureBox1_TimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem?.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDuLieu();
                return;
            }

            var ketQua = ql.NhaCCs
                           .Where(n => n.MaNCC.Contains(tuKhoa) || n.TenNCC.Contains(tuKhoa) ||n.SDTLH.Contains(tuKhoa) ||n.Email.Contains(tuKhoa)).OrderBy(n => n.MaNCC);

            dataGridView_NhaCC.DataSource = ketQua.ToList();
        }
        private void LoadDuLieu()
        {
            dataGridView_NhaCC.AutoGenerateColumns = true;
            var ds = ql.NhaCCs
               .OrderBy(n => n.MaNCC)
               .Select(n => new
               {
                   MaNCC = n.MaNCC,
                   TenNCC = n.TenNCC,
                   SDTLH = n.SDTLH,
                   Email = n.Email
               });

            dataGridView_NhaCC.DataSource = ds.ToList();
            if (dataGridView_NhaCC.Rows.Count > 0)
            {
                dataGridView_NhaCC.Rows[0].Selected = true;
                HienThiDong(0);
            }
        }

        private void HienThiDong(int idrow)
        {
            var row = dataGridView_NhaCC.Rows[idrow];
            string maNCC = row.Cells["MaNCC"].Value?.ToString() ?? "";


            if (string.IsNullOrEmpty(maNCC))
            {
                XoaForm();
                return;
            }

            NhaCC ncc = ql.NhaCCs.FirstOrDefault(p => p.MaNCC == maNCC);
            if (ncc != null)
            {
                txtMaNhaCC.Text = ncc.MaNCC;
                txtTenNhaCC.Text = ncc.TenNCC ?? "";
                txtSDT.Text = ncc.SDTLH ?? "";
                txtEmail.Text = ncc.Email ?? "";
            }
            else
            {
                XoaForm();
            }
        }

        // === TẠO NHÀ CUNG CẤP TỪ FORM ===
        private NhaCC TaoNhaCC()
        {
            string maNCC = txtMaNhaCC.Text.Trim();
            string tenNCC = txtTenNhaCC.Text.Trim();
            string hotline = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(maNCC) ||
                string.IsNullOrEmpty(tenNCC))
            {
                MessageBox.Show("Mã và Tên nhà cung cấp không được để trống!", "Thiếu dữ liệu",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new NhaCC
            {
                MaNCC = maNCC,
                TenNCC = tenNCC,
                SDTLH = hotline,
                Email = email
            };
        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhaCC ncc = TaoNhaCC();
            if (ncc == null) return;

            // Kiểm tra trùng mã
            if (ql.NhaCCs.Any(n => n.MaNCC == ncc.MaNCC))
            {
                MessageBox.Show($"Mã nhà cung cấp '{ncc.MaNCC}' đã tồn tại!", "Trùng mã",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ql.NhaCCs.InsertOnSubmit(ncc);
            ql.SubmitChanges();
            LoadDuLieu();
            XoaForm();
            MessageBox.Show("Thêm nhà cung cấp thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhaCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa!", "Chưa chọn",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhaCC ncc = TaoNhaCC();
            if (ncc == null) return;

            NhaCC nccUpdate = ql.NhaCCs.Where(n => n.MaNCC == txtMaNhaCC.Text).SingleOrDefault();

            if (nccUpdate != null)
            {
                nccUpdate.TenNCC = ncc.TenNCC;
                nccUpdate.SDTLH = ncc.SDTLH;
                nccUpdate.Email = ncc.Email;

                ql.SubmitChanges();
                LoadDuLieu();
                MessageBox.Show("Sửa thành công!", "Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhaCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNCC = txtMaNhaCC.Text;

            // Kiểm tra có sản phẩm dùng MaNCC này không
            if (ql.SanPhams.Any(sp => sp.MaNCC == maNCC))
            {
                MessageBox.Show($"Không thể xóa!\nNhà cung cấp '{maNCC}' đang được sử dụng trong sản phẩm.", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show($"Xóa nhà cung cấp '{maNCC}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhaCC ncc = ql.NhaCCs.Where(n => n.MaNCC == maNCC).SingleOrDefault();

                if (ncc != null)
                {
                    ql.NhaCCs.DeleteOnSubmit(ncc);
                    ql.SubmitChanges();
                    LoadDuLieu();
                    XoaForm();
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void XoaForm()
        {
            txtMaNhaCC.Clear();
            txtTenNhaCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNhaCC.Focus();
        }
        private void btn_Reset_Click(object sender, EventArgs e) 
        {
            XoaForm();
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            XuatExcel a = new XuatExcel();
            string[] listTitle = { "Mã NCC", "Tên NCC", "Số ĐT Liên Hệ", "Email" };
            a.ExportToExcel(dataGridView_NhaCC, "Danh Sách Nhà Cung Cấp", listTitle, "DanhSach_NhaCungCap");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_NhaCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView_NhaCC.Rows.Count) return;

            HienThiDong(e.RowIndex);
        }
    }
}
