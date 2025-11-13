using System;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormDangNhap : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormDangNhap()
        {
            InitializeComponent();
        }
        public static string user;
        public static string password;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBox_TaiKhoan.Text.Trim();
            string password = textBox_MatKhau.Text.Trim();
            user = textBox_TaiKhoan.Text;
            password = textBox_MatKhau.Text;

            if (user == "" || password == "")
            {
                MessageBox.Show("Vui long dien thong tin", "thong bao", MessageBoxButtons.OK);
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var user = db.NguoiDungs
                             .FirstOrDefault(u => u.username == username && u.password == password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormTrangChu frm = new FormTrangChu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = !checkBox_HienThiMatKhau.Checked;
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy dangky = new FormDangKy();
            this.Hide();
            dangky.ShowDialog();
            this.Close();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau quenmatkhau = new FormQuenMatKhau();
            this.Hide();
            quenmatkhau.ShowDialog();
            this.Close();
        }
    }
}
