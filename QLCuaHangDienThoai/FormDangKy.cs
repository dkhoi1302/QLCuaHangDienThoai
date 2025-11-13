using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormDangKy : Form
    {
        string taikhoan, matkhau, email, otp;
        private string currentOTP;
        private DateTime otpSentTime;

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btn_LayOTP_Click(object sender, EventArgs e)
        {
            email = textBox_Email.Text;
            currentOTP = new Random().Next(1000, 9999).ToString();
            otpSentTime = DateTime.Now;
            otp = currentOTP;
            sendemail.SendOTP(email, otp);
        }
        public FormDangKy()
        {
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "" || textBox_MatKhau.Text == "" || textBox_TaiKhoan.Text == "" || textBox_XacNhanMatKhau.Text == "")
            {
                MessageBox.Show("vui long dien day du thong tin", "thong bao", MessageBoxButtons.OK);
                return;
            }

            if (textBox_MatKhau.Text != textBox_XacNhanMatKhau.Text)
            {
                MessageBox.Show("vui long dien dung mat khau", "thong bao", MessageBoxButtons.OK);
                textBox_MatKhau.Focus();
                return;

            }
            if (textBox_Otp.Text != currentOTP || DateTime.Now.Subtract(otpSentTime).TotalMinutes > 5)
            {
                MessageBox.Show("OTP không hợp lệ hoặc đã hết hạn!");
                return;
            }
            taikhoan = textBox_TaiKhoan.Text;
            var existingUser = db.NguoiDungs.FirstOrDefault(d => d.username == taikhoan);

            if (existingUser != null)
            {
                MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_TaiKhoan.Focus();
                return;
            }
            matkhau = textBox_XacNhanMatKhau.Text;
            email = textBox_Email.Text;
            Random rd = new Random();
            otp = rd.Next(1000, 9999).ToString();

            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(matkhau + otp);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();


            NguoiDung nv = new NguoiDung();
            nv.username = taikhoan;

            nv.password = hashString;
            nv.email = email;
            nv.OTP = otp;
            nv.randomkey = otp;
            nv.DateCreate = DateTime.Now;
            nv.OTPDateSend = DateTime.Now;
            nv.Active = false;
            nv.DateActive = null;
            nv.levelID = 0;
            db.NguoiDungs.InsertOnSubmit(nv);
            db.SubmitChanges();
            MessageBox.Show("tao tai khoan thanh cong", "thong bao", MessageBoxButtons.OK);
            this.Close();
        }
    }
}