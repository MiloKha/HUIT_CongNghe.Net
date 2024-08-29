using Nhom10.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class QuenMatKhau : Form
    {
        BSDangNhap dn = new BSDangNhap();
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_thayDoi_Click(object sender, EventArgs e)
        {
            dn.doiMatKhau(txt_mkCu.Text.Trim(), txt_mkMoi.Text.Trim(), txt_xacNhanMK.Text.Trim());
            DangNhap frm = new DangNhap();
            frm.ShowDialog();
        }

        private void lbl_troVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            txt_xacNhanMK.PasswordChar = '*';
            txt_mkMoi.PasswordChar = '*';
        }

        private void chek_showMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_xacNhanMK.PasswordChar == '*' || txt_mkMoi.PasswordChar == '*')
            {
                txt_xacNhanMK.PasswordChar = '\0';
                txt_mkMoi.PasswordChar = '\0';
            }
            else
            {
                txt_xacNhanMK.PasswordChar = '*';
                txt_mkMoi.PasswordChar = '*';
            }
        }

    }
}
