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
        NhanVienBUS qlnv = new NhanVienBUS();
        KhoHangBUS qlkh = new KhoHangBUS();
        DonHangBUS qldh = new DonHangBUS();
        SanPhamBUS qlsp = new SanPhamBUS();
        public FormDonHang()
        {
            InitializeComponent();
        }
        public string ReturnMaSP(string Thongtin)
        {
            string[] parts = Thongtin.Split('|');
            string MaSP = parts[0].Trim();
            return MaSP;
        }
        public bool TestTextBox()
        {
            if (txtMaDH.Text == "" || txtTenKH.Text == "" && txtDiaChi.Text == "" || txtSDTKH.Text == "" || cboMaNV.Text == "")
            {
                return false;
            }
            return true;
        }
        public DonHang GetDataTextBox()
        {
            DonHang dhnew = new DonHang();
            if (TestTextBox())
            {
                dhnew.MaDH = txtMaDH.Text;
                dhnew.TenKH = txtTenKH.Text;
                dhnew.SDTKH = txtSDTKH.Text;
                dhnew.DiaChi = txtDiaChi.Text;
                dhnew.MaNV = cboMaNV.Text;
                dhnew.NgayMua = dateTimePicker1.Value;
                return dhnew;
            }
            else
            {

                return null;
            }

        }
        public List<ChiTietDonHang> listctdh = new List<ChiTietDonHang>();
        public List<ObjectSP> listctsp = new List<ObjectSP>();


        public ObjectSP LaydulieuSP(string soluong)
        {
            var chitietSP = qlsp.GetListSP().ToList().Find(s => s.MaSP == ReturnMaSP(cboSanPham.Text));
            if (chitietSP != null)
            {
                ObjectSP a = new ObjectSP();
                a.MaSP = chitietSP.MaSP;
                a.TenSP = chitietSP.TenSP;
                a.Soluong = int.Parse(soluong);
                a.Giaban = (double)chitietSP.Giaban;
                a.Thanhtien = a.Soluong * a.Giaban;
                return a;
            }
            return null;

        }
        public void GetDSNV()
        {
            var listMaNV = qlnv.GetListNV().ToList().Select(s => s.MaNV);
            foreach (var nv in listMaNV)
            {
                cboMaNV.Items.Add(nv);
            }

        }
        public void GetSPTrongKho()
        {
            var listSP = qlkh.GetAllSP().ToList().Select(s => s.MaSP + " | " + s.TenSP + " | Số lượng còn:" + s.Soluong).ToList();
            foreach (var x in listSP)
            {
                cboSanPham.Items.Add(x);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            GetDSNV();
            GetSPTrongKho();
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSanPham_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {

                if (cboSanPham.Text != null && txtSoluong.Text != null)
                {
                    if (LaydulieuSP(txtSoluong.Text) != null)
                    {
                        if (txtMaDH.Text != "")

                        {
                            var lispKho = qlkh.GetAllSP();
                            var a = LaydulieuSP(txtSoluong.Text);
                            ChiTietDonHang b = new ChiTietDonHang();
                            b.MaDH = txtMaDH.Text;
                            b.MaSP = a.MaSP;
                            b.SoLuong = a.Soluong;
                            b.DonGia = a.Thanhtien;

                            ObjectSP c = new ObjectSP();//Tạo đội tượng sản phẩm để thêm danh vào danh sách sản phẩm và xuaát hóa đơn
                            c.MaSP = a.MaSP;
                            c.TenSP = a.TenSP;
                            c.Soluong = a.Soluong;
                            c.Giaban = a.Giaban;
                            c.Thanhtien = a.Thanhtien;
                            if (int.Parse(txtSoluong.Text) > 0)
                            {
                                if (lispKho.Find(s => s.MaSP == a.MaSP).Soluong >= int.Parse(txtSoluong.Text))
                                {
                                    dtgrvHienThiListSPChon.Rows.Add(a.MaSP, a.TenSP, a.Soluong, a.Giaban, a.Thanhtien);
                                    listctdh.Add(b);
                                    listctsp.Add(c);
                                    MessageBox.Show("Thêm thành công đơn hàng vào giỏ !");
                                }
                                else
                                {
                                    MessageBox.Show("Số lượng mua phải bé hơn số lượng tồn trong kho");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số lượng mua phải là số dương");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Hãy nhập đầy đủ thông tin đơn hàng trước khi chọn sản phẩm");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chỉ chọn sản phẩm có sẵn trong kho", "Thông báo");
                    }
                }
            }
            catch { MessageBox.Show("Số lượng sản phẩm phải là kiểu int", "Thông báo"); }
        }
        public class Inhoadon
        {
            static public DonHang dh;
            static public List<ObjectSP> listsp;
        }

        private void dtgrvHienThiListSPChon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListSPChon.CurrentCell = null;
        }

        private void dtgrvHienThiListSPChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrvHienThiListSPChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dtgrvHienThiListSPChon.SelectedRows.Count > 0) // Kiểm tra xem có dòng đang được chọn không
            {
                DataGridViewRow selectedRow = dtgrvHienThiListSPChon.Rows[0];
                dtgrvHienThiListSPChon.Rows.Remove(selectedRow);
                string Masp = dtgrvHienThiListSPChon.Rows[0].Cells[0].Value.ToString();//Lấy dữ liệu cột masp dòng đang chọn
                ObjectSP sptgg = listctsp.Find(s => s.MaSP == Masp);
                ChiTietDonHang sptg = listctdh.Find(s => s.MaSP == Masp);
                listctdh.Remove(sptg);
                listctsp.Remove(sptgg);
                MessageBox.Show("Xóa thành công khỏi giỏ hàng");
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm nào !");
            }
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            if (GetDataTextBox() != null)
            {
                if (CheckNVcbb())
                {
                    if (listctdh.Count >= 1)
                    {
                        if (qldh.AddDH(GetDataTextBox()))
                        {
                            foreach (var x in listctdh)
                            {
                                qldh.AddChiTietDH(x);
                                qlkh.GiamSoLuongQL(x.MaSP, (int)x.SoLuong);
                            }

                            btnXemchitiet.Visible = true;
                            btnXuatHoadon.Visible = true;
                            MessageBox.Show("Thêm thành công đơn hàng");
                            listctdh.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Mã đơn hàng này đã tồn tại");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Chưa có sản phẩm nào");
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ chọn nhân viên đang làm việc tại cửa hàng !");
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
            }
        }

        private void btnHuyDH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (txtMaDH.Text != "")
                {
                    var listAllCTDH = qldh.getALLCTDH(txtMaDH.Text);
                    if (qldh.DeleteCTDH(txtMaDH.Text))
                    {
                        qldh.DeleteDH(txtMaDH.Text);
                        ///Cập nhật lại số lượng sản phẩm
                        if (listAllCTDH.Count > 0)
                        {
                            foreach (var i in listAllCTDH)
                            {
                                qlkh.TangSoLuongQL(i.MaSP, (int)i.Soluong);


                            }
                            MessageBox.Show("Xóa đơn hàng thành công !", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thất bại do đơn hàng này không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đơn hàng không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã đơn hàng cần hủy !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtMaDH.Text = "";
            txtSDTKH.Text = "";
            txtSoluong.Text = "";
            txtTenKH.Text = "";
            cboMaNV.Text = "";
            cboSanPham.Text = " Chọn sản phẩm";
            cboSanPham.ForeColor = Color.DarkGray;
            cboMaNV.Items.Clear();
            cboSanPham.Items.Clear();
            GetDSNV();
            GetSPTrongKho();
            listctdh.Clear();
            dtgrvHienThiListSPChon.Rows.Clear();
            btnXemchitiet.Visible = false;
            btnXuatHoadon.Visible = false;

        }

        private void btnXuatHoadon_Click(object sender, EventArgs e)
        {

            Inhoadon.dh = GetDataTextBox();
            Inhoadon.listsp = listctsp;
            FormXuatHoaDon a = new FormXuatHoaDon();
            a.ShowDialog();
        }

        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            ///// Lấy thông tin khách hàng từ các điều khiển trên form
            Inhoadon.dh = GetDataTextBox();
            Inhoadon.listsp = listctsp;
            FormChiTietDH a = new FormChiTietDH(Inhoadon.dh, Inhoadon.listsp);
            a.ShowDialog();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
}

