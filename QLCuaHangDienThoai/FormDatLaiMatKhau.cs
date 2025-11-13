using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class FormDatLaiMatKhau : Form
    {
        string newpassword;
        string repass;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormDatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_DatLaiMatKhau_Click(object sender, EventArgs e)
        {
            newpassword = txtBox_NhapMatKhauMoi.Text;
            repass = txtBox_XacNhanMatKhau.Text;

            if (txtBox_NhapMatKhauMoi.Text == "" || txtBox_XacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newpassword != repass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FormQuenMatKhau.userfound == null)
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            NguoiDung user = db.NguoiDungs.FirstOrDefault(d => d.username == FormQuenMatKhau.userfound.username);
            if (user != null)
            {
                Random rd = new Random();
                MD5 md5 = MD5.Create();

                byte[] inputBytes = Encoding.ASCII.GetBytes(newpassword + user.randomkey);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                user.password = hashString;

                db.SubmitChanges();
                MessageBox.Show("đổ mật khẩu thành công quay lại đăng nhập ", "thông báo ", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
