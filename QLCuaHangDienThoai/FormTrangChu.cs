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
    public partial class FormTrangChu : Form
    {
        public static string level;
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            ThoiGian.Enabled = true;
            
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd//MM//yyyy HH:mm:ss");
        }
    }
}
