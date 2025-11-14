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
    public partial class FormChiTietDH : Form
    {
        public FormChiTietDH()
        {
            private DonHang donHang;
            private List<ObjectSP> listSanPham;
        public FormChiTietDH(DonHang dh, List<ObjectSP> listsp)
        {
            InitializeComponent();
            donHang = dh;
            listSanPham = listsp;
        }

        private void FormChiTietDH_Load(object sender, EventArgs e)
        {
            var ttnv = donHang;
            var listsps = listSanPham;
            lblMaHD.Text = ttnv.MaDH.ToString();
            lblMaNV.Text = ttnv.MaNV.ToString();
            lblTenKH.Text = ttnv.TenKH.ToString();
            lblSDTKH.Text = ttnv.SDTKH.ToString();
            lblDiachi.Text = ttnv.DiaChi.ToString();
            lblNgaymua.Text = ttnv.NgayMua.ToString();
            foreach (var i in listsps)
            {
                dtgrvHienThiListSPChon.Rows.Add(i.MaSP, i.TenSP, i.Soluong, i.Giaban, i.Thanhtien);

            }
        }

        private void dtgrvHienThiListSPChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgrvHienThiListSPChon.CurrentCell = null;
        }
    }
}
