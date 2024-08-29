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
    public partial class NhaCungCap : Form
    {
        BSNhaCungCap ncc = new BSNhaCungCap();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            ncc.LoadDuLieu(dgv_NCC);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Thêm", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ncc.ThemNCC(txt_maNCC.Text.Trim(), txt_tenNCC.Text.Trim(), txt_diaChi.Text.Trim());
                ncc.LoadDuLieu(dgv_NCC);
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
                ncc.XoaNCC(txt_maNCC.Text.Trim());
                ncc.LoadDuLieu(dgv_NCC);
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
                ncc.SuaNCC(txt_maNCC.Text.Trim(), txt_tenNCC.Text.Trim(), txt_diaChi.Text.Trim());
                ncc.LoadDuLieu(dgv_NCC);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_NCC.CurrentCell.RowIndex;
            txt_maNCC.Text = dgv_NCC.Rows[r].Cells[0].Value.ToString();
            txt_tenNCC.Text = dgv_NCC.Rows[r].Cells[1].Value.ToString();
            txt_diaChi.Text = dgv_NCC.Rows[r].Cells[2].Value.ToString();
        }


       
    }
}
