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
    public partial class PhieuNhapThucPham : Form
    {
        BSPhieuNhapTP pn = new BSPhieuNhapTP();
        public PhieuNhapThucPham()
        {
            InitializeComponent();
        }

        private void PhieuNhapThucPham_Load(object sender, EventArgs e)
        {
            pn.LoadDuLieu(dgv_phieuNhap);
            pn.LoadCBO_MANV(cbo_maNV);
            pn.LoadCBO_MANCC(cbo_maNCC);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Thêm", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pn.ThemPN(txt_maPN.Text.Trim(), maskedTextBox1.Text, txt_tenPN.Text.Trim(), cbo_maNV.SelectedValue.ToString().Trim(), cbo_maNCC.SelectedValue.ToString().Trim());
                pn.LoadDuLieu(dgv_phieuNhap);
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
                pn.SuaPN(txt_maPN.Text.Trim(), maskedTextBox1.Text, txt_tenPN.Text.Trim(), cbo_maNV.SelectedValue.ToString().Trim(), cbo_maNCC.SelectedValue.ToString().Trim());
                pn.LoadDuLieu(dgv_phieuNhap);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Xoá", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pn.XoaPN(txt_maPN.Text.Trim());
                pn.LoadDuLieu(dgv_phieuNhap);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_phieuNhap.CurrentCell.RowIndex;
            txt_maPN.Text = dgv_phieuNhap.Rows[r].Cells[0].Value.ToString();
            maskedTextBox1.Text = dgv_phieuNhap.Rows[r].Cells[1].Value.ToString();
            txt_tenPN.Text = dgv_phieuNhap.Rows[r].Cells[2].Value.ToString();
            cbo_maNV.SelectedValue = dgv_phieuNhap.Rows[r].Cells[3].Value.ToString();
            cbo_maNCC.SelectedValue = dgv_phieuNhap.Rows[r].Cells[4].Value.ToString();
        }


    }
}
