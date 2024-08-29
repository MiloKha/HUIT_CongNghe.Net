using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom10.BSLayer;

namespace Nhom10
{
    public partial class DangNhap : Form
    {
        BSDangNhap dn = new BSDangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            dn.DangNhap(txt_taiKhoan, txt_matKhau, DangNhap.ActiveForm);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_matKhau.PasswordChar = '*';
        }

        private void chek_showMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_matKhau.PasswordChar == '*')
            {
                txt_matKhau.PasswordChar = '\0';
            }
            else
            {
                txt_matKhau.PasswordChar = '*';
            }
        }

        
    }
}
