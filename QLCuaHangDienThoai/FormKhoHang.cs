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
    public partial class FormKhoHang : Form
    {
        KhoHangBUS ql = new KhoHangBUS();
        List<KhoHang> listSP;
        public FormKhoHang()
        {
            InitializeComponent();
        }
        public dynamic GetListSP()
        {
            listSP = ql.GetAllSP().ToList();
            var kq = listSP.Select(s => new { s.MaSP, s.TenSP, s.Soluong, s.NgayNhap }).ToList();
            return kq;

        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListSPKho.DataSource = GetListSP();
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public string MaSPdelete = null;

        private void dtgrvHienThiListSPKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadDataGridView();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang a = new FormNhapHang();
            a.ShowDialog();

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            XuatExcel xuatExcel = new XuatExcel();
            string[] titlecolumn = { "Mã SP", "Tên Sản Phẩm", "Số lượng tồn", "Ngày Nhập" };
            xuatExcel.ExportToExcel(dtgrvHienThiListSPKho, "Danh Sách Sản Phẩm Trong Kho", titlecolumn, "Danhsachsanphamkho");
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (listSP.Count != 0)
            {
                if (dtgrvHienThiListSPKho.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng click vào sản phẩm cần xóa");
                }
                else
                {
                    try
                    {
                        if (ql.DeleteSanPham(MaSPdelete))
                        {
                            LoadDataGridView();
                            MessageBox.Show("Xóa sản phẩm khỏi kho thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xảy ra lỗi khi xóa sản phẩm ở kho !", "Thông báo");
                        }
                    }
                    catch { MessageBox.Show("Hiện không thể xóa sản phẩm này vì nó đang là khóa ngoại của bảng khác!"); }
                }
            }
            else
            {
                MessageBox.Show("Hiện không có sản phẩm nào trong kho !", "Thông báo");
            }
        }

        private void dtgrvHienThiListSPKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgrvHienThiListSPKho.Rows[e.RowIndex].Selected = true;
                MaSPdelete = dtgrvHienThiListSPKho.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dtgrvHienThiListSPKho_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListSPKho.CurrentCell = null;
        }
    }
}
