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

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui long dien thong tin", "thong bao", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Xin Chao Admin!", "Thong bao", MessageBoxButtons.OK);
                    this.Hide();
                    FormTrangChu frm = new FormTrangChu();
                    frm.ShowDialog();
                    this.Show();
                    return;
                }
                else if (username == "Nv" && password == "Nv")
                {
                    MessageBox.Show("Xin Chao Nhan Vien!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            DataClasses1DataContext data = new DataClasses1DataContext();
            NguoiDung user = data.NguoiDungs.SingleOrDefault(d => d.username == username);


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
                        this.Hide();
                    }
                    else if (user.levelID != 1)
                    {
                        FormTrangChu.level = "Nv";
                        FormTrangChu trangChu = new FormTrangChu();
                        trangChu.Show();
                        this.Hide();
                    }
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
    }
}
