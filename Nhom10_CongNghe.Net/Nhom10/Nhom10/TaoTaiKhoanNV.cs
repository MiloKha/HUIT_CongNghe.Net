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
    public partial class TaoTaiKhoanNV : Form
    {
        BSDangNhap dn = new BSDangNhap();
        public TaoTaiKhoanNV()
        {
            InitializeComponent();
        }

        private void lbl_troVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_taoTK_Click(object sender, EventArgs e)
        {
            dn.TaoTaiKhoan(txt_taiKhoan, txt_mkMoi, txt_xacNhanMK, cbo_maNV.SelectedValue.ToString().Trim());
        }

        private void TaoTaiKhoanNV_Load(object sender, EventArgs e)
        {
            txt_taiKhoan.Focus();
            txt_mkMoi.PasswordChar = '*';
            txt_xacNhanMK.PasswordChar = '*';
            dn.LoadCBO_MANV(cbo_maNV);
        }

        private void chek_showMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_mkMoi.PasswordChar == '*' || txt_xacNhanMK.PasswordChar == '*')
            {
                txt_mkMoi.PasswordChar = '\0';
                txt_xacNhanMK.PasswordChar = '\0';
            }
            else
            {
                txt_mkMoi.PasswordChar = '*';
                txt_xacNhanMK.PasswordChar = '*';
            }
        }
    }
}
