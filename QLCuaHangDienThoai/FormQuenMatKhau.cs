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
    public partial class FormQuenMatKhau : Form
    {
        string email;
        string currentOTP;
        string taikhoan;
        private DateTime otpSentTime;
        public static NguoiDung userfound;
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_OTP_Click(object sender, EventArgs e)
        {
            taikhoan = txtBox_Tkhoan.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();

            userfound = db.NguoiDungs.FirstOrDefault(d => d.username == taikhoan);

            if (userfound == null)
            {
                MessageBox.Show("tài khoản không tồn tại hoặc sai ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (userfound != null)
            {
                email = userfound.email;
            }

            currentOTP = new Random().Next(1000, 9999).ToString();
            otpSentTime = DateTime.Now;
            sendemail.SendOTP(email, currentOTP);

            btn_LayMatKhauMoi.Enabled = true;
            userfound.OTP = currentOTP;
            userfound.OTPDateSend = DateTime.Now;
            db.SubmitChanges();
        }

        private void btn_LayMatKhauMoi_Click(object sender, EventArgs e)
        {
            taikhoan = txtBox_Tkhoan.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();

            userfound = db.NguoiDungs.FirstOrDefault(d => d.username == taikhoan);

            if (txtBox_OTP.Text != currentOTP || DateTime.Now.Subtract(otpSentTime).TotalMinutes > 5)
            {
                MessageBox.Show("OTP không hợp lệ hoặc đã hết hạn!");
                return;
            }
            MessageBox.Show("xác thực OTP thành công vui lòng đổi lại mật khẩu", "thông báo ", MessageBoxButtons.OK);
            FormDatLaiMatKhau frmDatlaimatkhau = new FormDatLaiMatKhau();
            this.Hide();
            frmDatlaimatkhau.ShowDialog();
            this.Close();
        }
    }
}
