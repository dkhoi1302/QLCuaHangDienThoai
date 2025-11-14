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
        public static string user;
        public static string password;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBox_TaiKhoan.Text.Trim();
            string password = textBox_MatKhau.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui long dien thong tin", "thong bao", MessageBoxButtons.OK);
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataClasses1DataContext data = new DataClasses1DataContext();
            NguoiDung user = data.NguoiDungs.SingleOrDefault(d=>d.username==username);


            if (user != null)
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(password + user.randomkey);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                if (hashString == user.password)
                {
                    if (user.levelID == 1)
                    {
                        FormTrangChu.level = "admin";
                        FormTrangChu trangChu = new FormTrangChu();
                        trangChu.Show();
                        this.Close();
                    }
                    else if(user.levelID !=1) 
                    {
                        FormTrangChu.level = "admin";
                        FormTrangChu trangChu = new FormTrangChu();
                        trangChu.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo",
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
            this.Show();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau quenmatkhau = new FormQuenMatKhau();
            this.Hide();
            quenmatkhau.ShowDialog();
            this.Show();
        }
    }
}
