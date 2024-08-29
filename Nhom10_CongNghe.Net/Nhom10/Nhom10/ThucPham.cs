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
    public partial class ThucPham : Form
    {
        BSThucPham tp = new BSThucPham();
        public ThucPham()
        {
            InitializeComponent();
        }

        private void ThucPham_Load(object sender, EventArgs e)
        {
            tp.LoadDuLieu(dgv_nguyenLieu);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Thêm", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                tp.ThemTP(txt_maTP.Text.Trim(), txt_tenTP.Text.Trim(), txt_dvt.Text.Trim());
                tp.LoadDuLieu(dgv_nguyenLieu);
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
                tp.SuaTP(txt_maTP.Text.Trim(), txt_tenTP.Text.Trim(), txt_dvt.Text.Trim());
                tp.LoadDuLieu(dgv_nguyenLieu);
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
                tp.XoaTP(txt_maTP.Text.Trim());
                tp.LoadDuLieu(dgv_nguyenLieu);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void dgv_nguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_nguyenLieu.CurrentCell.RowIndex;
            txt_maTP.Text = dgv_nguyenLieu.Rows[r].Cells[0].Value.ToString();
            txt_tenTP.Text = dgv_nguyenLieu.Rows[r].Cells[1].Value.ToString();
            txt_dvt.Text = dgv_nguyenLieu.Rows[r].Cells[2].Value.ToString();
        }
    }
}
