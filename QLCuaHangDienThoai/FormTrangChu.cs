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
    public partial class FormTrangChu : Form
    {
        public static string level;
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            ThoiGian.Enabled = true;

        }
        private void ThoiGian_Tick_1(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToString("dd//MM//yyyy HH:mm:ss");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản không  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Hide();
            FormDangNhap login = new FormDangNhap();
            login.ShowDialog();
            this.Close();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            FormSanPham frmSP = new FormSanPham();
            frmSP.ShowDialog();
        }

        private void btn_Nhacc_Click(object sender, EventArgs e)
        {
            FormNhaCC frmNhaCC =  new FormNhaCC();
            frmNhaCC.ShowDialog();
        }

        private void btn_AddDH_Click(object sender, EventArgs e)
        {
            FormDonHang frmDonHang = new FormDonHang();
            frmDonHang.ShowDialog();
        }

        private void btn_Khohang_Click(object sender, EventArgs e)
        {
            FormKhoHang frmKhoHang = new FormKhoHang();
            frmKhoHang.ShowDialog();
        }

        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien frmNhanVien = new FormNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            FormThongKe frmThongKe = new FormThongKe();
            frmThongKe.ShowDialog();
        }
    }
}
