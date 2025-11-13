using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    internal class sendemail
    {
        // ĐỔI THÀNH bool ĐỂ TRẢ VỀ KẾT QUẢ (THÀNH CÔNG / THẤT BẠI)
        public static bool SendOTP(string toEmail, string otp)
        {
            // BƯỚC 1: Kiểm tra email hợp lệ → KHÔNG THROW EXCEPTION
            if (string.IsNullOrWhiteSpace(toEmail) || !IsValidEmail(toEmail.Trim()))
            {
                return false; // Email sai → trả false, không gửi
            }

            string fromEmail = "dangkhoi13022006@gmail.com";
            string password = "jdcb bkut rvvv zpby"; // App Password (đúng rồi)

            try
            {
                var fromAddress = new MailAddress(fromEmail, "Cửa hàng điện thoại");
                var toAddress = new MailAddress(toEmail);

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail, password),
                    Timeout = 20000 // 20 giây timeout
                };

                using (var mail = new MailMessage(fromAddress, toAddress)
                {
                    Subject = "Mã OTP xác thực tài khoản",
                    Body = $"<h3>Mã OTP của bạn là:</h3><h2 style='color:blue;'>{otp}</h2><p>Có hiệu lực trong <b>5 phút</b>.</p>",
                    IsBodyHtml = true
                })
                {
                    smtp.Send(mail);
                }

                return true; // Gửi thành công
            }
            catch (Exception)
            {
                // Lỗi mạng, mật khẩu, SMTP → im lặng trả false
                return false;
            }
        }

        // HÀM KIỂM TRA EMAIL CHUẨN (giữ Regex + cải thiện)
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Chuẩn hóa: loại bỏ khoảng trắng
            email = email.Trim();

            // Regex cơ bản + kiểm tra .NET MailAddress (chuẩn nhất)
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}