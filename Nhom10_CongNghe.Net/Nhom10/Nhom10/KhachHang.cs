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
    public partial class KhachHang : Form
    {
        BSKhachHang kh = new BSKhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            kh.LoadDuLieu(dgv_khachHang);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Thêm", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                kh.ThemKH(txt_maKH.Text.Trim(), txt_tenKH.Text.Trim(), txt_SDT.Text.Trim());
                kh.LoadDuLieu(dgv_khachHang);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Sửa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                kh.SuaKH(txt_maKH.Text.Trim(), txt_tenKH.Text.Trim(), txt_SDT.Text.Trim());
                kh.LoadDuLieu(dgv_khachHang);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_khachHang.CurrentCell.RowIndex;
            txt_maKH.Text = dgv_khachHang.Rows[r].Cells[0].Value.ToString();
            txt_tenKH.Text = dgv_khachHang.Rows[r].Cells[1].Value.ToString();
            txt_SDT.Text = dgv_khachHang.Rows[r].Cells[2].Value.ToString();
        }

        private void lbl_troVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
