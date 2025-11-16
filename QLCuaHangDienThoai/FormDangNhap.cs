using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QLCuaHangDienThoai
{
    public partial class FormDangNhap : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            string username = textBox_TaiKhoan.Text;
            string password = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // Xử lý đăng nhập tạm thời admin / NV
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Xin chào Admin!", "Thông báo", MessageBoxButtons.OK);

                this.Hide();
                FormTrangChu frm = new FormTrangChu();
                frm.ShowDialog();
                this.Show();
                return;
            }
            else if (username == "Nv" && password == "Nv")
            {
                MessageBox.Show("Xin chào Nhân Viên!", "Thông báo", MessageBoxButtons.OK);

                this.Hide();
                FormTrangChu frm = new FormTrangChu();
                frm.ShowDialog();
                this.Show();
                return;
            }

            // Kiểm tra trong CSDL
            NguoiDung user = db.NguoiDungs.SingleOrDefault(d => d.username == username);

            if (user != null)
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(password + user.randomkey);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                if (hashString == user.password)
                {
                    // Mở FormTrangChu
                    this.Hide();
                    FormTrangChu frm = new FormTrangChu();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy dangky = new FormDangKy();
            this.Hide();
            dangky.ShowDialog();
            this.Show();
            return;
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau quenmatkhau = new FormQuenMatKhau();
            this.Hide();
            quenmatkhau.ShowDialog();
            this.Show();
        }
        private void checkBox_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HienThiMatKhau.Checked)
                textBox_MatKhau.UseSystemPasswordChar = true;
            else
                textBox_MatKhau.UseSystemPasswordChar = false;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}